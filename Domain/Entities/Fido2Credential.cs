using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class Fido2Credential : AuditableEntity<Guid>
{
    public Fido2Credential() { Id = Guid.NewGuid(); }

    public Guid UserId { get; set; }
    public byte[] DescriptorId { get; set; } = null!; // ID của Passkey (CredentialId)
    public byte[] PublicKey { get; set; } = null!;    // Khóa công khai
    public byte[] UserHandle { get; set; } = null!;   // Mã định danh User dưới máy Client
    public uint SignatureCounter { get; set; }        // Đếm số lần dùng để chống Replay Attack
    public string? CredType { get; set; }             // Thường là "public-key"
    public DateTime RegDate { get; set; }
    public Guid AaGuid { get; set; }                  // Mã định danh loại thiết bị (Yubikey, Apple, Windows...)

    public virtual User User { get; set; } = null!;
}
