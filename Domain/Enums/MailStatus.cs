using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enums
{
    public enum MailStatus : byte{
        Pending = 0,
        Sent = 1,
        Failed = 2,
    }
}
