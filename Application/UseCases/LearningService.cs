using Application.Common.Interfaces;
using Application.Dtos.Learning;
using Application.Exceptions;
using Application.Interfaces;
using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases
{
    public interface ILearningService
    {
        Task<LearningSyllabusDto?> GetCourseSyllabusAsync(Guid courseId, Guid studentId);
        Task<VideoLessonDto?> GetVideoLessonAsync(Guid itemId, Guid studentId);
        Task SubmitLessonQuestionAsync(Guid studentId, SubmitLessonQuestionRequest request);
        Task<(ModuleItemType ItemType, LessonContentType? ContentType)?> GetItemTypeInfoAsync(Guid itemId);
        Task<ReadingLessonDto?> GetReadingLessonAsync(Guid itemId, Guid studentId);
        Task MarkReadingCompletedAsync(Guid studentId, Guid moduleItemId);

        //Quiz
        Task<QuizIntroDto?> GetQuizIntroAsync(Guid itemId, Guid studentId);
        Task<Guid> StartQuizAttemptAsync(Guid itemId, Guid studentId);
        Task<QuizAttemptDto?> GetQuizAttemptAsync(Guid attemptId, Guid studentId);
        Task<decimal> SubmitQuizAttemptAsync(Guid studentId, SubmitQuizAttemptRequest request);
    }

    public class LearningService : ILearningService
    {
        private readonly IUnitOfWork _uow;
        private readonly ICourseRepository _course;
        private readonly IModuleRepository _module;
        private readonly IProgressRepository _progress;
        private readonly IQuizAttemptRepository _attempt;

        public LearningService(IUnitOfWork uow, ICourseRepository course, IModuleRepository module, IProgressRepository progress, IQuizAttemptRepository attempt)
        {
            _uow = uow;
            _course = course;
            _module = module;
            _progress = progress;
            _attempt = attempt;
        }

        public async Task<LearningSyllabusDto?> GetCourseSyllabusAsync(Guid courseId, Guid studentId)
        {
            var course = await _course.GetSyllabusForStudentAsync(courseId, studentId);
            if (course == null) throw new BusinessRuleException("Coure not found");

            var result = new LearningSyllabusDto(
                course.Id,
                course.Title,
                course.Modules.OrderBy(m => m.OrderIndex).Select(m => new ModuleSyllabusDto(
                    m.Id,
                    m.Title,
                    m.OrderIndex,
                    m.ModuleItems.OrderBy(mi => mi.OrderIndex).Select(mi => new ItemSyllabusDto(
                        mi.Id,
                        GetItemTitle(mi),
                        mi.ItemType,
                        mi.OrderIndex,
                        mi.Progresses.Any(p => p.Status == ProgressStatus.Completed)
                    )).ToList()
                )).ToList()
            );
            return result;
        }

        private string GetItemTitle(ModuleItem mi)
        {
            return mi.ItemType switch
            {
                ModuleItemType.Lesson => mi.Lesson?.Title ?? "Lesson",
                ModuleItemType.Quiz => mi.Quiz?.Title ?? "Quiz",
                ModuleItemType.Assignment => mi.Assignment?.Title ?? "Assignment",
                ModuleItemType.Discussion => mi.Discussion?.Title ?? "Discussion",
                _ => "Unknown"
            };
        }

        public async Task<VideoLessonDto?> GetVideoLessonAsync(Guid itemId, Guid studentId)
        {
            var moduleItem = await _module.GetVideoLessonAsync(itemId);

            if (moduleItem == null || moduleItem.Lesson == null || moduleItem.Lesson.ContentType != LessonContentType.Video)
                throw new BusinessRuleException("Can not find lesson video");

            var isCompleted = await _progress.IsItemCompletedAsync(studentId, itemId);

            var questions = moduleItem.Lesson.LessonQuestions.Select(q => new LessonQuestionDto(
                q.Id,
                q.Content,
                q.LessonOptions.Select(opt => new LessonOptionDto(opt.Id, opt.Content, opt.IsCorrect)).ToList()
            )).ToList();
            return new VideoLessonDto(moduleItem.Id, moduleItem.Lesson.Title, moduleItem.Lesson.VideoUrl, isCompleted, questions);
        }

        public async Task SubmitLessonQuestionAsync(Guid studentId, SubmitLessonQuestionRequest request)
        {
            var moduleItem = await _module.GetVideoLessonAsync(request.ModuleItemId);
            if (moduleItem == null || moduleItem.Lesson == null) throw new BusinessRuleException("Can not find lesson video");

            var selectedOptionIds = request.Answers.Values.ToList();
            var selectedOptions = moduleItem.Lesson.LessonQuestions
                .SelectMany(q => q.LessonOptions)
                .Where(opt => selectedOptionIds.Contains(opt.Id))
                .ToList();

            if (selectedOptions.Count == moduleItem.Lesson.LessonQuestions.Count &&
                selectedOptions.All(opt => opt.IsCorrect))
            {
                var isUpdated = await _progress.UpdateProgressToCompletedAsync(studentId, request.ModuleItemId);
                if (!isUpdated) throw new BusinessRuleException("Cannot update progress");
                await _uow.SaveChangeAsync();
            }
            else
            {
                throw new BusinessRuleException("Your answers are incorrect. Please watch the video carefully and try again!");
            }
        }

        public async Task<(ModuleItemType ItemType, LessonContentType? ContentType)?> GetItemTypeInfoAsync(Guid itemId)
        {
            var item = await _module.GetItemTypeInfoAsync(itemId);
            if (item == null) throw new BusinessRuleException("Module items not found");
            return item;
        }

        public async Task<ReadingLessonDto?> GetReadingLessonAsync(Guid itemId, Guid studentId)
        {
            var moduleItem = await _module.GetReadingLessonAsync(itemId);
            if (moduleItem == null || moduleItem.Lesson == null || moduleItem.Lesson.ContentType != LessonContentType.Reading)
                throw new BusinessRuleException("Can not find reading lesson");
            var isCompleted = await _progress.IsItemCompletedAsync(studentId, itemId);
            return new ReadingLessonDto(moduleItem.Id, moduleItem.Lesson.Title, moduleItem.Lesson.TextContent, isCompleted);
        }

        public async Task MarkReadingCompletedAsync(Guid studentId, Guid moduleItemId)
        {
            var moduleItem = await _module.GetReadingLessonAsync(moduleItemId);
            if (moduleItem == null || moduleItem.Lesson == null || moduleItem.Lesson.ContentType != LessonContentType.Reading)
                throw new BusinessRuleException("Can not find reading lesson");
            var isCompleted = await _progress.IsItemCompletedAsync(studentId, moduleItemId);
            if (isCompleted) throw new BusinessRuleException("This reading have been completed already");

            await _progress.UpdateProgressToCompletedAsync(studentId, moduleItemId);

            await _uow.SaveChangeAsync();
        }

        public async Task<QuizIntroDto?> GetQuizIntroAsync(Guid itemId, Guid studentId)
        {
            var moduleItem = await _module.GetQuizAsync(itemId);
            if (moduleItem == null || moduleItem.Quiz == null) throw new BusinessRuleException("Can not find quiz");

            var quiz = moduleItem.Quiz;

            var isCompleted = await _progress.IsItemCompletedAsync(studentId, itemId);
            var bestScore = await _attempt.GetBestScoreAsync(studentId, quiz.Id);
            var lastAttempt = await _attempt.GetLastAttemptAsync(studentId, quiz.Id);

            bool isCooldownActive = false;
            int? remainingCooldownMin = null;

            if (lastAttempt != null)
            {
                var timeSinceLastAttempt = DateTime.UtcNow - lastAttempt.StartedAt;

                if (timeSinceLastAttempt.TotalMinutes < quiz.AttemptCooldownMin)
                {
                    isCooldownActive = true;
                    remainingCooldownMin = quiz.AttemptCooldownMin - (int)timeSinceLastAttempt.TotalMinutes;
                }
            }

            return new QuizIntroDto(
                moduleItem.Id,
                quiz.Title,
                quiz.TimeLimitMin,
                quiz.PassingScorePct,
                quiz.AttemptCooldownMin,
                isCompleted,
                bestScore,
                isCooldownActive,
                remainingCooldownMin
            );
        }

        public async Task<Guid> StartQuizAttemptAsync(Guid itemId, Guid studentId)
        {
            var moduleItem = await _module.GetQuizAsync(itemId);
            if (moduleItem == null || moduleItem.Quiz == null) throw new BusinessRuleException("Can not find quiz");

            var quiz = moduleItem.Quiz;
            var lastAttempt = await _attempt.GetLastAttemptAsync(studentId, quiz.Id);

            if (lastAttempt != null)
            {
                var timeSinceLastAttempt = DateTime.UtcNow - lastAttempt.StartedAt;
                if (timeSinceLastAttempt.TotalMinutes < quiz.AttemptCooldownMin)
                    throw new BusinessRuleException($"Pleast wait in: {quiz.AttemptCooldownMin - (int)timeSinceLastAttempt.TotalMinutes} phút trước khi thi lại.");
            }

            var attemptCount = await _attempt.CountAttemptsAsync(studentId, quiz.Id);

            var newAttempt = new QuizAttempt
            {
                Id = Guid.NewGuid(),
                QuizId = quiz.Id,
                StudentId = studentId,
                AttemptNo = attemptCount + 1,
                Status = QuizAttemptStatus.InProgress,
                StartedAt = DateTime.UtcNow
            };
            //AsEnumerable tip để dùng linq tạo random
            var questionsToPick = quiz.QuizQuestions.AsEnumerable();

            if (quiz.PickCount.HasValue && quiz.PickCount.Value > 0)
            {
                questionsToPick = questionsToPick.OrderBy(x => Guid.NewGuid()).Take(quiz.PickCount.Value);
            }

            //index chạy từ -
            var attemptQuestions = questionsToPick.Select((q, index) => new QuizAttemptQuestion
            {
                AttemptId = newAttempt.Id,
                QuestionId = q.Id,
                DisplayOrder = (byte)(index + 1)
            }).ToList();

            await _attempt.AddAttempt(newAttempt);
            await _attempt.AddAttemptQuestions(attemptQuestions);
            await _uow.SaveChangeAsync();
            return newAttempt.Id;
        }

        public async Task<QuizAttemptDto?> GetQuizAttemptAsync(Guid attemptId, Guid studentId)
        {
            var attempt = await _attempt.GetAttemptWithQuestionsAsync(attemptId, studentId);
            if (attempt == null) throw new BusinessRuleException("Quiz attempt not found.");

            if (attempt.Status != QuizAttemptStatus.InProgress) throw new BusinessRuleException("This quiz attempt is no longer in progress.");

            var moduleItem = await _module.GetQuizAsync(attempt.QuizId);
            var quiz = moduleItem?.Quiz;

            var questionDtos = attempt.QuizAttemptQuestions
                .OrderBy(q => q.DisplayOrder)
                .Select(qaq => new QuizAttemptQuestionDto(
                    qaq.QuestionId,
                    qaq.Question.Content,
                    qaq.Question.MediaUrl,
                    qaq.DisplayOrder,
                    qaq.Question.QuizOptions.Select(opt => new QuizOptionDto(opt.Id, opt.Content)).ToList()
            )).ToList();

            return new QuizAttemptDto(
                attempt.Id,
                quiz?.Title ?? "Quiz",
                quiz?.TimeLimitMin,
                attempt.StartedAt,
                questionDtos
            );
        }

        public async Task<decimal> SubmitQuizAttemptAsync(Guid studentId, SubmitQuizAttemptRequest request)
        {
            var attempt = await _attempt.GetAttemptWithQuestionsAsync(request.AttemptId, studentId);
            if (attempt == null || attempt.Status != QuizAttemptStatus.InProgress)
                throw new BusinessRuleException("Quiz attempt is invalid or has already been submitted.");

            var moduleItem = await _module.GetQuizAsync(attempt.QuizId);
            var quiz = moduleItem?.Quiz;
            if (quiz == null) throw new BusinessRuleException("Quiz not found.");

            var answersToSave = new List<AttemptAnswer>();
            int correctCount = 0;
            int totalQuestions = attempt.QuizAttemptQuestions.Count;

            if (totalQuestions == 0) throw new BusinessRuleException("Invalid quiz attempt: No questions found.");

            foreach (var qaq in attempt.QuizAttemptQuestions)
            {
                var question = qaq.Question;
                if (request.Answers.TryGetValue(question.Id, out var chosenOptionId))
                {
                    var chosenOption = question.QuizOptions.FirstOrDefault(o => o.Id == chosenOptionId);
                    bool isCorrect = chosenOption != null && chosenOption.IsCorrect;

                    if (isCorrect) correctCount++;

                    answersToSave.Add(new AttemptAnswer
                    {
                        AttemptId = attempt.Id,
                        ChosenOptionId = chosenOptionId,
                        IsCorrect = isCorrect
                    });
                }
            }

            decimal scorePct = (decimal)correctCount / totalQuestions * 100;
            bool isPassed = scorePct >= quiz.PassingScorePct;

            attempt.ScorePct = scorePct;
            attempt.IsPassed = isPassed;
            attempt.Status = QuizAttemptStatus.Submitted;

            await _attempt.AddAttemptAnswers(answersToSave);

            if (isPassed)
            {
                await _progress.UpdateProgressToCompletedAsync(studentId, quiz.Id);
            }

            await _uow.SaveChangeAsync();

            return scorePct;
        }
    }
}