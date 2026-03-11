
using System;

namespace OwlDelivery
{
    public sealed class RouteInfo
    {
        public string From { get; }
        public string To { get; }
        public int Distance { get; }

        public RouteInfo(string from, string to, int distance)
        {
            if (distance < 0)
                throw new ArgumentException("Distance cannot be negative");

            From = from;
            To = to;
            Distance = distance;
        }

        public override string ToString()
        {
            return $"{From} -> {To} ({Distance} м)";
        }

        public override bool Equals(object obj)
        {
            RouteInfo other = obj as RouteInfo;
            if (other == null) return false;

            return From == other.From && To == other.To && Distance == other.Distance;
        }

        public override int GetHashCode()
        {
            return (From + To + Distance).GetHashCode();
        }
    }
}
