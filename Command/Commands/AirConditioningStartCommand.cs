using Command.Receivers;

namespace Command.Commands
{
    public class AirConditioningStartCommand : ICommand
    {
        private AirConditioning _airConditioning;
        private double _temperature;

        public AirConditioningStartCommand(AirConditioning airConditioning, double temperature)
        {
            _airConditioning = airConditioning;
            _temperature = temperature;
        }

        public void Execute()
        {
            _airConditioning.Start(_temperature);
        }
    }
}
