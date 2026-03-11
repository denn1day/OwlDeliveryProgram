
namespace OwlDelivery
{
    public class Parcel : DeliveryItem
    {
        public double Weight { get; }

        public Parcel(string sender, string receiver, double weight)
            : base(sender, receiver)
        {
            if (weight > 5)
                throw new OverweightDeliveryException();

            Weight = weight;
        }

        public override string DescribeDelivery()
        {
            return $"Посылка {Sender} -> {Receiver}, вес: {Weight} кг";
        }
    }
}
