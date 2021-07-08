﻿using RemoteControl.Command.Abstraction;
using RemoteControl.Recievers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControl.Command
{
    public class LivingroomLightOffCommand : ICommand
    {
        private readonly Light _light;
        public LivingroomLightOffCommand(Light light)
        {
            _light = light;
        }
        public void Execute() => _light.Off();
    }
}
