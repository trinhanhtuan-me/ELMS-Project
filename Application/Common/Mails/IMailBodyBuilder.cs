using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Mails
{
    public interface IMailBodyBuilder
    {
        Task<string> BuildOtpRegistrationEmail(string userName, string otpCode);
        Task<string> BuildOtpForgotPassword(string userName, string otpCode);
        Task<string> BuildParentLink(string parentName, string studentName);
    }
}
