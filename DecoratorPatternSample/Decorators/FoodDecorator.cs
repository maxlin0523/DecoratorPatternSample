using DecoratorPatternSample.Foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatternSample.Decorators
{
    public abstract class FoodDecorator : BaseFood
    {
        private BaseFood _basefood;

        /// <summary>
        /// 配菜名稱
        /// </summary>
        protected abstract string DecoratorName();

        /// <summary>
        /// 配菜價位
        /// </summary>
        protected abstract int DecoratorPrice();

        public FoodDecorator(BaseFood basefood)
        {
            _basefood = basefood;
        }

        /// <summary>
        /// 食品名稱：食品名 加 配菜名
        /// Ex: 漢堡 加 蛋
        /// </summary>
        public override string GetDescription() 
            => _basefood.GetDescription() + "加" +  DecoratorName();

        /// <summary>
        /// 食品價格：食品價位 加 配菜價位
        /// </summary>
        public override int GerPrice()
            => _basefood.GerPrice() + DecoratorPrice();
    }
}