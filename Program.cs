
using System;
using System.Collections.Generic;

namespace OwlDelivery
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Система совиной доставки ===");

            Owl[] owls =
            {
                new BarnOwl("Букля", 100),
                new SnowyOwl("Север", 120)
            };

            DeliveryItem letter = new Letter("Гарри", "Рон", DeliveryPriority.Normal);
            DeliveryItem parcel = new Parcel("Гермиона", "Гарри", 2.5);

            RouteInfo route = new RouteInfo("Хогвартс", "Хогсмид", 500);

            foreach (var owl in owls)
            {
                try
                {
                    owl.Fly(route);
                    Console.WriteLine(letter.DescribeDelivery());
                    Console.WriteLine(parcel.DescribeDelivery());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка: " + ex.Message);
                }
            }

            Console.WriteLine("=== Конец симуляции ===");
            Console.ReadKey();
        }
    }
}
