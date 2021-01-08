using System;

namespace ChainOfResponsibility.Handlers
{
    public class PayPalPayment : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.PayPal)
            {
                Console.WriteLine($"Process {receiver.UserName} payment with 'PayPal'.");
            }
            else if (Next != null)
            {
                Next.Handle(receiver);
            }
        }
    }
}
