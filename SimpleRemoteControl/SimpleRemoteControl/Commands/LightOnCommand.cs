using SimpleRemoteControl.Commands.Abstraction;
using SimpleRemoteControl.Recievers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRemoteControl.Commands
{
    public class LightOnCommand : ICommand
    {
        Light Light;
        public LightOnCommand(Light Light)
        {
            this.Light = Light;
        }

        public void Execute() => Light.TurnOn();
    }
}
