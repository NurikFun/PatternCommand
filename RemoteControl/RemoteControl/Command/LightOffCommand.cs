﻿using RemoteControl.Command.Abstraction;
using RemoteControl.Recievers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControl.Command
{
    public class LightOffCommand : ICommand
    {
        private readonly Light _light;
        public LightOffCommand(Light light)
        {
            _light = light;
        }
        public void Execute() => _light.Off();
    }
}
