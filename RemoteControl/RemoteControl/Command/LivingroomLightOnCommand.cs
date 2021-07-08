using RemoteControl.Command.Abstraction;
using RemoteControl.Recievers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControl.Command
{
    public class LivingroomLightOnCommand : ICommand
    {
        private readonly Light _light;
        public LivingroomLightOnCommand(Light light)
        {
            _light = light;
        }
        public void Execute() => _light.On();
    }
}
