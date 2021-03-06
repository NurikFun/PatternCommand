using RemoteControlWithUndo.Commands.Abstraction;
using RemoteControlWithUndo.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlWithUndo.Commands
{
    public class LightOffCommand : ICommand
    {
        private readonly Light _light;
        private int _level;

        public LightOffCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _level = _light.GetLevel();
            _light.Off();
        }

        public void Undo() => _light.Dim(_level);
    }
}
