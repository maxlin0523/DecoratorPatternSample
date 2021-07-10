using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatternSample.Foods
{
    /// <summary>
    /// 漢堡 30元
    /// </summary>
    public class Hamburger : BaseFood
    {
        public Hamburger()
        {
            this.Name = "漢堡";
            this.Price = 30;
        }
    }

    /// <summary>
    /// 三明治 25元
    /// </summary>
    public class Sandwich : BaseFood
    {
        public Sandwich()
        {
            this.Name = "三明治";
            this.Price = 25;
        }
    }
    /// <summary>
    /// 吐司 20元
    /// </summary>
    public class Toast : BaseFood
    {
        public Toast()
        {
            this.Name = "吐司";
            this.Price = 20;
        }
    }
}
