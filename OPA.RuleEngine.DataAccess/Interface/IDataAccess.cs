using OPA.RuleEngine.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OPA.RuleEngine.DataAccess.Interface
{
    public interface IDataAccess
    {
        List<ProductDto> GetProductDetails();

        List<MembershipDto> GetMAmberShipDetails();

        List<PaymentDto> GetPaymentTypes();
    }
}
