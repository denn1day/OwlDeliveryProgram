
using System;

namespace OwlDelivery
{
    public class SnowyOwl : Owl
    {
        public SnowyOwl(string name, int maxDistance) : base(name, maxDistance) {}

        public override void Fly(RouteInfo route)
        {
            Console.WriteLine($"{Name} (полярная сова) выполняет доставку: {route}");
        }
    }
}
