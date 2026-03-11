
using System;

namespace OwlDelivery
{
    public abstract class Owl : IFlyable
    {
        public string Name { get; }
        public int MaxDistance { get; }

        protected Owl(string name, int maxDistance)
        {
            Name = name;
            MaxDistance = maxDistance;
        }

        public abstract void Fly(RouteInfo route);

        public override string ToString()
        {
            return $"{Name} (max {MaxDistance})";
        }

        public override bool Equals(object obj)
        {
            Owl other = obj as Owl;
            if (other == null) return false;
            return Name == other.Name && MaxDistance == other.MaxDistance;
        }

        public override int GetHashCode()
        {
            return (Name + MaxDistance).GetHashCode();
        }
    }
}
