using OPA.RuleEngine.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OPA.RuleEngine.Business.Interface
{
    public interface IOrder
    {
        /// <summary>
        /// Process Order
        /// </summary>
        /// <returns></returns>
        Task<Response> ProcessOrder();
    }
}
