namespace AbstractFactory.Abstract
{
    public abstract class BaseUIFactory
    {
        public abstract Button CreateButton();
        public abstract Select CreateSelect();
    }
}
