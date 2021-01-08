namespace ChainOfResponsibility.Handlers
{
    public abstract class PaymentHandler
    {
        public PaymentHandler Next { get; set; }
        public abstract void Handle(Receiver receiver);
    }
}
