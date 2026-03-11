using System;

namespace OwlDelivery
{
    public class OverweightDeliveryException : Exception
    {
        public OverweightDeliveryException() { }

        public OverweightDeliveryException(string message) : base(message) { }

        public override string Message => base.Message ?? "Посылка слишком тяжелая для доставки совой.";
    }
}