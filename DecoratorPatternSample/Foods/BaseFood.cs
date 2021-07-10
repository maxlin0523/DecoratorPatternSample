using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatternSample.Foods
{
    public abstract class BaseFood
    {
        /// <summary>
        /// 食品名稱
        /// </summary>
        public string Name = "未知";

        /// <summary>
        /// 食品價位
        /// </summary>
        public int Price = -999;

        /// <summary>
        /// 取得食品名稱
        /// </summary>
        public virtual string GetDescription() => this.Name;

        /// <summary>
        /// 取得食品價位
        /// </summary>
        public virtual int GerPrice() => this.Price;
    }
}
