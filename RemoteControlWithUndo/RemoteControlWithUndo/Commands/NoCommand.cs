using RemoteControlWithUndo.Commands.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlWithUndo.Commands
{
    public class NoCommand : ICommand
    {
        public void Execute() { }
        public void Undo() { }
    }
}
