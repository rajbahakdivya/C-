//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DecoratorPattern
//{
//     class OnionDecorator : PizzaDecorator
//    {
//        public OnionDecorator(IPizza pizza) : base(pizza) { }

//        public override string GetPizzaType()
//        {
//            string type = base.GetPizzaType();
//            type += "\r\n with extra cheese";
//            return type;
//        }
//    }
//}
