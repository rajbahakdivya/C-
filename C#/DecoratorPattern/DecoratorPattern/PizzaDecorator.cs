﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
         class PizzaDecorator: IPizza    
    {
        protected IPizza pizza;

        public PizzaDecorator(IPizza pizza)
        {
            this.pizza = pizza; 
        }
        public virtual  void GetPizzaType()
        {
             pizza.GetPizzaType();
        }
    }
}
