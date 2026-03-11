using System;

namespace OwlDelivery
{
    public class NoAvailableOwlException : Exception
    {
        public NoAvailableOwlException() { }

        public NoAvailableOwlException(string message) : base(message) { }

        public override string Message => base.Message ?? "Нет доступной совы для доставки.";
    }
}