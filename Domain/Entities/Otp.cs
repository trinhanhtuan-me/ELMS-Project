using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Otp
{
    public string Email { get; set; } = null!;

    public string Code { get; set; } = null!;

    public DateTime ExpiryDate { get; set; }

    public bool IsDeleted { get; set; }
}


