using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces;

public interface IStudentProfileRepository
{
    Task<StudentProfile?> GetByIdAsync(Guid studentId);
    void Update(StudentProfile student);
    Task<List<StudentProfile>> GetByParentIdAsync(Guid parentId);
}
