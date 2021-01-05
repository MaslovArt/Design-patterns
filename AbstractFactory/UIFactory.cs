using AbstractFactory.Abstract;
using AbstractFactory.Concrete.Android;
using AbstractFactory.Concrete.IOS;

namespace AbstractFactory
{
    public static class UIFactory
    {
        public static BaseUIFactory Get(Systems system)
        {
            switch (system)
            {
                case Systems.Android: return new AndroidUIFactory();
                case Systems.IOS: return new IOSUIFactory();
                default: return null;
            }
        }
    }
}
