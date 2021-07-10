using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatternSample.Foods
{
    public class Hamburger : BaseFood
    {
        public Hamburger()
        {
            this.Name = "漢堡";
            this.Price = 30;
        }
    }

    public class Sandwich : BaseFood
    {
        public Sandwich()
        {
            this.Name = "三明治";
            this.Price = 25;
        }
    }

    public class Toast : BaseFood
    {
        public Toast()
        {
            this.Name = "吐司";
            this.Price = 20;
        }
    }
}
