using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using OPA.RuleEngine.Business.Interface;
using OPA.RuleEngine.Model;
namespace OPA.RuleEngine.Business.Manager
{
    public class EmailManager : IEmailManager
    {
        public Task<bool> SendMail(EmailDto emailDto)
        {
            throw new NotImplementedException();
        }
    }
}
