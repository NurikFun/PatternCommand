using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControl.Command.Abstraction
{
    public interface ICommand
    {
        void Execute();
    }
}
