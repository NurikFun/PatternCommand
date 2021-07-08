using SimpleRemoteControl.Commands.Abstraction;
using SimpleRemoteControl.Recievers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRemoteControl.Commands
{
    public class GarageDoorOpenCommand : ICommand
    {
        GarageDoor Garage; 
        public GarageDoorOpenCommand(GarageDoor Garage)
        {
            this.Garage = Garage;
        }
        public void Execute() => Garage.Up();

    }
}
