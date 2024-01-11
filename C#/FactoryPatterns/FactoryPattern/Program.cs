
using FactoryPattern;


IPayment payment = PaymentFactory.create(PaymentMethod.ApplePay);
payment.Pay(10000.00);
