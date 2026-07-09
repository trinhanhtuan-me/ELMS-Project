using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Application.Dtos.Manager
{
    public class CategorySaveRequest
    {
        public int? Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public IFormFile? PictureFile { get; set; }
        public string? PictureOld { get; set; }
    }
    public class CategorySaveRequestValidator : AbstractValidator<CategorySaveRequest>
    {
        public CategorySaveRequestValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Empty Category Name.")
                .MaximumLength(100).WithMessage("Category name length < 100 char");

            RuleFor(x => x.Description)
                .MaximumLength(500).WithMessage("Desciption length < 500 char.");

           
        }
    }
}
