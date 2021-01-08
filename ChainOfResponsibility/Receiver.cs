namespace ChainOfResponsibility
{
    public class Receiver
    {
        public string UserName { get; set; }
        public bool PayPal { get; set; }
        public bool Qiwi { get; set; }
        public bool YandexMoney { get; set; }

        public Receiver(string userName, bool payPal, bool qiwi, bool yandexMoney)
        {
            UserName = userName;
            PayPal = payPal;
            Qiwi = qiwi;
            YandexMoney = yandexMoney;
        }
    }
}
