using DecoratorPatternSample.Foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatternSample.Decorators
{
    public class Egg : FoodDecorator
    {
        public Egg(BaseFood basefood) : base(basefood)
        {
        }

        protected override int DecoratorPrice() => 10;

        protected override string DecoratorName() => "蛋";
    }

    public class Cheese : FoodDecorator
    {
        public Cheese(BaseFood basefood) : base(basefood)
        {
        }

        protected override int DecoratorPrice() => 5;

        protected override string DecoratorName() => "起士";
    }
}
