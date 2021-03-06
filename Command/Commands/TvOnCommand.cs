﻿using Command.Receivers;

namespace Command.Commands
{
    public class TvOnCommand : ICommand
    {
        private TV _tv;

        public TvOnCommand(TV tv)
        {
            _tv = tv;
        }

        public void Execute()
        {
            _tv.On();
        }
    }
}
