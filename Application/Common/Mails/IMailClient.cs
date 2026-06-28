using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Mails
{
    public interface IMailClient
    {
        Task SendAsync(string to, string subject, string body);
    }
}
