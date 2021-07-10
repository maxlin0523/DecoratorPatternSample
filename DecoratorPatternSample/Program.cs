using DecoratorPatternSample.Decorators;
using DecoratorPatternSample.Foods;
using System;

namespace DecoratorPatternSample
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseFood hamburger = new Hamburger();
            hamburger = new Egg(hamburger);
            hamburger = new Cheese(hamburger);

            Console.WriteLine($"食品名稱： {hamburger.GetDescription()}");
            Console.WriteLine($"價格： {hamburger.GerPrice()}");
            Console.ReadKey();
        }
    }
}
