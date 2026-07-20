using Application.Dtos.MyProgress;
using Application.Interfaces;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases
{
    public interface IStudentProgressService
    {
        Task<List<MyCourseDto>> GetMyCoursesAsync(Guid studentId);
    }

    public class StudentProgressService : IStudentProgressService
    {
        private readonly IEnrollmentRepository _enrollmentRepository;
        public StudentProgressService(IEnrollmentRepository enrollmentRepository)
        {
            _enrollmentRepository = enrollmentRepository;
        }
        public async Task<List<MyCourseDto>> GetMyCoursesAsync(Guid studentId)
        {
            var enrollments = await _enrollmentRepository.GetStudentEnrollmentsWithDetailsAsync(studentId);
            var result = new List<MyCourseDto>();
            foreach (var enrollment in enrollments)
            {
                var course = enrollment.Course;
                if (course == null) continue;
                var moduleItems = course.Modules.SelectMany(m => m.ModuleItems).ToList();
                int totalItems = moduleItems.Count;

                int completedItems = moduleItems.Count(item =>
                    item.Progresses.Any(p => p.Status == ProgressStatus.Completed));
                decimal progressPercent = totalItems > 0 ? (decimal)completedItems / totalItems * 100 : 0;
                bool isCompleted = enrollment.Status == EnrollmentStatus.Completed;
                result.Add(new MyCourseDto
                {
                    CourseId = course.Id,
                    Title = course.Title,
                    Thumbnail = course.Thumbnail,
                    ProgressPercent = progressPercent,
                    IsCompleted = isCompleted
                });
            }
            return result;
        }
    }
}