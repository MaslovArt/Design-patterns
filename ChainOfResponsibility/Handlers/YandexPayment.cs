using System;

namespace ChainOfResponsibility.Handlers
{
    public class YandexPayment : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.YandexMoney)
            {
                Console.WriteLine($"Process {receiver.UserName} payment with 'yandex money'.");
            }
            else if (Next != null)
            {
                Next.Handle(receiver);
            }
        }
    }
}
