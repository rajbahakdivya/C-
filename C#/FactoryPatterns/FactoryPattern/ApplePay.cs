using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class ApplePay: IPayment
    {
        public void Pay(Double amount)
        {
            Console.WriteLine($"Successfully paid ${amount} to merchant using a ApplelPay");
        }
    }
}
