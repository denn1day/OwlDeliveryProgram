using System;

namespace OwlDelivery
{
    public class NoAvailableOwlException : Exception
    {
        public NoAvailableOwlException() { }

        public NoAvailableOwlException(string message) : base(message) { }

        public override string Message => base.Message ?? "Сейчас нет свободных курьеров для доставки.";
    }
}