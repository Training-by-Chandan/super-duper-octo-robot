using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octo.ECom.Services
{
    public interface IEmailService
    {
        void SendEmail(string subject, string body, string receipent);
    }

    public class EmailService : IEmailService
    {
        public void SendEmail(string subject, string body, string receipent)
        {
        }
    }
}