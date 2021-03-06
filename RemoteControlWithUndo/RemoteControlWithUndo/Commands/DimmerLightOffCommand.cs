using RemoteControlWithUndo.Commands.Abstraction;
using RemoteControlWithUndo.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlWithUndo.Commands
{
    public class DimmerLightOffCommand : ICommand
    {
        private readonly Light _light;
        private int _prevLevel;

        public DimmerLightOffCommand(Light light)
        {
            _light = light;
            _prevLevel = 100;
        }

        public void Execute()
        {
            _prevLevel = _light.GetLevel();
            _light.Off();
        }

        public void Undo() => _light.Dim(_prevLevel);
    }
}
