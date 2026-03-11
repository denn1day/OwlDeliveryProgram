
using System;

namespace OwlDelivery
{
    public class BarnOwl : Owl
    {
        public BarnOwl(string name, int maxDistance) : base(name, maxDistance) {}

        public override void Fly(RouteInfo route)
        {
            if (route.Distance > MaxDistance)
                throw new NoAvailableOwlException("Сова не сможет пролететь такое большое расстояние.");

            Console.WriteLine($"{Name} летит по маршруту {route}");
        }
    }
}
