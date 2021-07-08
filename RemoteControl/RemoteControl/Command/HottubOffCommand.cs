﻿using RemoteControl.Command.Abstraction;
using RemoteControl.Recievers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControl.Command
{
    public class HottubOffCommand : ICommand
    {
        private readonly Hottub _hottub;
        public HottubOffCommand(Hottub hottub)
        {
            _hottub = hottub;
        }
        public void Execute() 
        {
            _hottub.Cool();
            _hottub.Off();
        } 
    }
}
