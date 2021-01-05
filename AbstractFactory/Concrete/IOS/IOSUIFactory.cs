using AbstractFactory.Abstract;

namespace AbstractFactory.Concrete.IOS
{
    public class IOSUIFactory : BaseUIFactory
    {
        public override Button CreateButton()
        {
            return new IOSButton();
        }

        public override Select CreateSelect()
        {
            return new IOSSelect();
        }
    }
}
