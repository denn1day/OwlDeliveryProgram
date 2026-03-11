
namespace OwlDelivery
{
    public abstract class DeliveryItem
    {
        public string Sender { get; }
        public string Receiver { get; }

        protected DeliveryItem(string sender, string receiver)
        {
            Sender = sender;
            Receiver = receiver;
        }

        public abstract string DescribeDelivery();
    }
}
