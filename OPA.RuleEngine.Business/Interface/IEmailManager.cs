using OPA.RuleEngine.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OPA.RuleEngine.Business.Interface
{
   public interface IEmailManager
    {
        /// <summary>
        /// Send Mail Notification
        /// </summary>
        /// <param name="emailDto"></param>
        /// <returns></returns>
        Task<bool> SendMail(EmailDto emailDto);
    }
}
