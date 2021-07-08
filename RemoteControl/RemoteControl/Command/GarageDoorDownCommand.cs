using RemoteControl.Command.Abstraction;
using RemoteControl.Recievers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControl.Command
{
    public class GarageDoorDownCommand : ICommand
    {
        private readonly GarageDoor _garageDoor;
        public GarageDoorDownCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }
        public void Execute() => _garageDoor.Down();
    }
}
