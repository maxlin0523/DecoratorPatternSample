using DecoratorPatternSample.Foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatternSample.Decorators
{
    /// <summary>
    /// 加蛋 10元
    /// </summary>
    public class Egg : DecorateFood
    {
        public Egg(BaseFood basefood) : base(basefood)
        {
        }

        public override int DecorateFoodPrice() => 10;

        public override string DecorateFoodName() => "蛋";
    }

    /// <summary>
    /// 加起士 5元
    /// </summary>
    public class Cheese : DecorateFood
    {
        public Cheese(BaseFood basefood) : base(basefood)
        {
        }

        public override int DecorateFoodPrice() => 5;

        public override string DecorateFoodName() => "起士";
    }
}
