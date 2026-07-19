using Domain.Enums;
namespace Web.ViewModels
{
    public class StudentFamilyViewModel
    {

        public string StudentName { get; set; } = string.Empty;
        // Trạng thái: "NotLinked", "Pending", "Linked"
        public string ParentLinkStatus { get; set; } = string.Empty;
        public string? ParentEmail { get; set; }
        public Guid? ParentLinkRequestId { get; set; }
        public Guid? ParentId { get; set; }
        public string? FilterStatus { get; set; }
        public string? SearchKeyword { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int TotalItems { get; set; }
        public List<CourseRequestItemViewModel> CourseRequests { get; set; } = new List<CourseRequestItemViewModel>();
    }
    public class CourseRequestItemViewModel
    {
        public Guid CourseRequestId { get; set; }
        public Guid CourseId { get; set; }
        public string CourseName { get; set; } = string.Empty;
        public CourseRequestStatus Status { get; set; }
        public string? Note { get; set; }
    }
}
