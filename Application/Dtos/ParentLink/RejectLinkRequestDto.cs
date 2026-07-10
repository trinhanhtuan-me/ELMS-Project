using System;
using System.ComponentModel.DataAnnotations;

namespace Application.Dtos.ParentLink;

public class RejectLinkRequestDto
{
    public Guid RequestId { get; set; }
    
    [Required(ErrorMessage = "Lý do từ chối không được để trống.")]
    public string Note { get; set; } = null!;
}
