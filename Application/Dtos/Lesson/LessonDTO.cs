using Microsoft.AspNetCore.Http;
using System;
using FluentValidation;

namespace Application.Dtos.Lesson
{
    public class VideoLessonCreateRequest
    {
        public Guid ModuleId { get; set; }
        public Guid CourseId { get; set; }
        public string Title { get; set; } = null!;
        public IFormFile VideoFile { get; set; } = null!;
    }

    public class ReadingLessonCreateRequest
    {
        public Guid ModuleId { get; set; }
        public Guid CourseId { get; set; }
        public string Title { get; set; } = null!;
        public string TextContent { get; set; } = null!;
    }

    public class VideoLessonUpdateRequest
    {
        public Guid ModuleItemId { get; set; }
        public Guid CourseId { get; set; }
        public Guid ModuleId { get; set; }
        public Guid ActualLessonId { get; set; }
        public string Title { get; set; } = null!;
        public IFormFile? VideoFile { get; set; } // Optional
        public string? CurrentVideoUrl { get; set; }
    }

    public class ReadingLessonUpdateRequest
    {
        public Guid ModuleItemId { get; set; }
        public Guid CourseId { get; set; }
        public Guid ModuleId { get; set; }
        public Guid ActualLessonId { get; set; }
        public string Title { get; set; } = null!;
        public string TextContent { get; set; } = null!;
    }

    public class VideoLessonCreateRequestValidator : AbstractValidator<VideoLessonCreateRequest>
    {
        public VideoLessonCreateRequestValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Vui lòng nhập tiêu đề bài học");
        }
    }

    public class ReadingLessonCreateRequestValidator : AbstractValidator<ReadingLessonCreateRequest>
    {
        public ReadingLessonCreateRequestValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Vui lòng nhập tiêu đề bài học");

            RuleFor(x => x.TextContent)
                .NotEmpty().WithMessage("Vui lòng nhập nội dung bài học");
        }
    }

    public class VideoLessonUpdateRequestValidator : AbstractValidator<VideoLessonUpdateRequest>
    {
        public VideoLessonUpdateRequestValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Vui lòng nhập tiêu đề bài học");
        }
    }

    public class ReadingLessonUpdateRequestValidator : AbstractValidator<ReadingLessonUpdateRequest>
    {
        public ReadingLessonUpdateRequestValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Vui lòng nhập tiêu đề bài học");

            RuleFor(x => x.TextContent)
                .NotEmpty().WithMessage("Vui lòng nhập nội dung bài học");
        }
    }
}
