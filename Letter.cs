
namespace OwlDelivery
{
    public class Letter : DeliveryItem
    {
        public DeliveryPriority Priority { get; }

        public Letter(string sender, string receiver, DeliveryPriority priority)
            : base(sender, receiver)
        {
            Priority = priority;
        }

        public override string DescribeDelivery()
        {
            return $"Письмо {Sender} -> {Receiver}, приоритет: {Priority}";
        }
    }
}
