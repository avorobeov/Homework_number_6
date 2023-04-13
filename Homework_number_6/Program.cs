using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_number_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int gold;
            int crystals = 0;
            int priceOneCrystal = 10;
            int numberOfCrystals = 100;
            int numberOfCrystalsBuy;

            Console.Write("Ведите количество золота: ");
            gold = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Количество золота у вас: {gold}\n" +
                              $"Количество Кристалов у вас: {crystals}\n");

            Console.WriteLine("||Магазин||\n");
            Console.WriteLine($"Добрый день мы приветствуем вас в нашей лавке у нас вы можете поменять золото на кристалы\n" +
                              $"Цена одного Кристала {priceOneCrystal} золота\n" +
                              $"Доступное количество Кристалов для покупки: {numberOfCrystals}\n");

            Console.Write("Укажите количество Кристалов для покупки: ");
            numberOfCrystalsBuy = Convert.ToInt32(Console.ReadLine());

            if (numberOfCrystalsBuy <= numberOfCrystals)
            {
                gold -= numberOfCrystalsBuy * priceOneCrystal;
                crystals = numberOfCrystalsBuy;
                numberOfCrystals -= numberOfCrystalsBuy;

                Console.WriteLine($"Вы удачно купили {numberOfCrystalsBuy} кристалов");
            }
            else
            {
                Console.WriteLine("К сожалению в магазине нет такого количества кристалов");
            }

            Console.WriteLine($"Количество золота у вас: {gold} \n" +
                             $"Количество Кристалов у вас: {crystals}\n");

            Console.WriteLine("||Магазин||\n");
            Console.WriteLine($"Цена одного Кристала: {priceOneCrystal} \n" +
                              $"Доступное количество Кристалов для покупки: {numberOfCrystals}\n");
            Console.ReadLine();
        }
    }
}
