using DecoratorPatternSample.Decorators;
using DecoratorPatternSample.Foods;
using System;
using System.Collections.Generic;

namespace DecoratorPatternSample
{
    class Program
    {
        static void Main(string[] args)
        {
            // 訂單需求：漢堡兩個都加、三明治加蛋， 吐司加起士

            // 製作
            // 漢堡兩者都加
            BaseFood hamburger = new Hamburger(); // 漢堡
            hamburger = new Egg(hamburger); // 加蛋
            hamburger = new Cheese(hamburger); // 加起士

            // 三明治加蛋
            BaseFood sandwich = new Sandwich(); // 三明治
            sandwich = new Egg(sandwich); // 加蛋

            // 吐司加起士
            BaseFood toast = new Toast(); // 吐司
            toast = new Cheese(toast); // 加起士


            // 驗證
            // 建立清單
            var orders = new List<BaseFood>() { hamburger, sandwich, toast };

            foreach (var order in orders)
            {
                // 印出每筆訂單資料
                Console.WriteLine($"食品名稱： {order.GetDescription()}");
                Console.WriteLine($"價格： {order.GerPrice()}");
            }

            Console.ReadKey();
        }
    }
}
