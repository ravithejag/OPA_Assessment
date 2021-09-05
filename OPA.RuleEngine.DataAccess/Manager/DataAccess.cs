using OPA.RuleEngine.DataAccess.Interface;
using OPA.RuleEngine.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OPA.RuleEngine.DataAccess.Manager
{
    public class DataAccess : IDataAccess
    {
        public List<MembershipDto> GetMembershipDetails()
        {
            return new List<MembershipDto>
            {
                new MembershipDto { Id=1, Type="New MemberShip Activation" },
                new MembershipDto { Id=2, Type="MemberShip Upgrade" }
            };
        }

        public List<PaymentDto> GetPaymentTypes()
        {
            return new List<PaymentDto>
            {
                new PaymentDto{Id=1, Type="Debit Card"},
                new PaymentDto{Id=2, Type="Credit Card"},
                new PaymentDto{Id=3, Type="UPI Payment"}
            };
        }

        public List<ProductDto> GetProductDetails()
        {
            return new List<ProductDto>
            {
                new ProductDto{Id =1,Type="Physical product",Description="Payment for physical product",IsPaymentRequired=true},
                new ProductDto{Id =2,Type="Book",Description="Payment for a book",IsPaymentRequired=true},
                new ProductDto{Id =3,Type="Membership",Description="Membership - Activation/Upgrade",IsMembershipType=true},
                new ProductDto{Id =4,Type="Video",Description="Payment for a Video"}
            };
        }
    }
}
