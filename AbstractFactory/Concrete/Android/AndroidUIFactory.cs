using AbstractFactory.Abstract;

namespace AbstractFactory.Concrete.Android
{
    public class AndroidUIFactory : BaseUIFactory
    {
        public override Button CreateButton()
        {
            return new AndroidButton();
        }

        public override Select CreateSelect()
        {
            return new AndroidSelect();
        }
    }
}
