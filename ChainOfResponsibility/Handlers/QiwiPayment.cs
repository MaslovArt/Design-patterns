using System;

namespace ChainOfResponsibility.Handlers
{
    public class QiwiPayment : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.Qiwi)
            {
                Console.WriteLine($"Process {receiver.UserName} payment with 'qiwi'.");
            }
            else if (Next != null)
            {
                Next.Handle(receiver);
            }
        }
    }
}
