using OPA.RuleEngine.Model;
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
