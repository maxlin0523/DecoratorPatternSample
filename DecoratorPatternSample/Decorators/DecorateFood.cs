using DecoratorPatternSample.Foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatternSample.Decorators
{
    public abstract class DecorateFood : BaseFood
    {
        /// <summary>
        /// 要被裝飾的食品，由外部經建構式傳入
        /// </summary>
        private BaseFood _basefood;

        /// <summary>
        /// 配菜名稱
        /// </summary>
        public abstract string DecorateFoodName();

        /// <summary>
        /// 配菜價位
        /// </summary>
        public abstract int DecorateFoodPrice();

        public DecorateFood(BaseFood basefood)
        {
            _basefood = basefood;
        }

        /// <summary>
        /// 裝飾後食品名稱：目前食品名 加 配菜名
        /// </summary>
        public override string GetDescription() 
            => _basefood.GetDescription() + "加" +  DecorateFoodName();

        /// <summary>
        /// 裝飾後食品價格：目前食品價位 加 配菜價位
        /// </summary>
        public override int GerPrice()
            => _basefood.GerPrice() + DecorateFoodPrice();
    }
}