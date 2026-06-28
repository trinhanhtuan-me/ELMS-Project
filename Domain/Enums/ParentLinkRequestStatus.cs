namespace Domain.Enums;

public enum ParentLinkRequestStatus : byte{
    Pending = 1,
    Approved = 2,
    Rejected = 3,
    Canceled = 4,
    Unlink = 5
}

