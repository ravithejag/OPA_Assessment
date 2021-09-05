using OPA.RuleEngine.Model;
using System.Collections.Generic;

namespace OPA.RuleEngine.DataAccess.Interface
{
    public interface IDataAccess
    {
        /// <summary>
        /// To retrieve Product Details
        /// </summary>
        /// <returns></returns>
        List<ProductDto> GetProductDetails();

        /// <summary>
        /// To retrieve MemberShip Details
        /// </summary>
        /// <returns></returns>
        List<MembershipDto> GetMembershipDetails();

        /// <summary>
        /// To retrieve Payment Details
        /// </summary>
        /// <returns></returns>
        List<PaymentDto> GetPaymentTypes();
    }
}
