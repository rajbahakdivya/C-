using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class PaymentFactory
    { 
        public static IPayment create(PaymentMethod paymentMethod)
        {
            switch(paymentMethod)
            {
                case PaymentMethod.CreditCard:
                    return new CreditCardPayment();

                case PaymentMethod.Paypal:
                    return new PaypalPayment();

                case PaymentMethod.GooglePay:
                    return new GooglePayPayment();

                case PaymentMethod.ApplePay:
                    return new ApplePay();

                default:
                    throw new NotImplementedException(
                       $"{paymentMethod}is not currrently supported as a payment method."
                        );
            }
        }
    }
}
