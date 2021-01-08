using ChainOfResponsibility.Handlers;
using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var paypal = new PayPalPayment();
            var qiwi = new QiwiPayment();
            var yandex = new YandexPayment();

            paypal.Next = qiwi;
            qiwi.Next = yandex;

            var receiver1 = new Receiver("Rec1", false, false, true);
            paypal.Handle(receiver1);

            var receiver2 = new Receiver("Rec2", false, true, true);
            paypal.Handle(receiver2);

            Console.ReadKey();
        }
    }
}
