using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
      class TomatoDecorator : PizzaDecorator
    {
        public TomatoDecorator(IPizza pizza) : base(pizza) { }

        public override void GetPizzaType()
        {
            pizza.GetPizzaType();
             setTomatoBase(pizza);

            //string type = base.GetPizzaType();
            //type += "\r\n with extra cheese";
            //return type;
        }
        private void setTomatoBase(IPizza pizza)
        {
            Console.WriteLine( "Tomato pizza is created");
        }
    }
}

