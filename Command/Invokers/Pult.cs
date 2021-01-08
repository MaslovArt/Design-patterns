using Command.Commands;

namespace Command.Invokers
{
    public class Pult
    {
        public ICommand RedBtnCommand { get; set; }
        public ICommand BlueBtnCommand { get; set; }

        public void RedButtonPress()
        {
            RedBtnCommand.Execute();
        }

        public void BlueBtnPress()
        {
            BlueBtnCommand.Execute();
        }
    }
}
