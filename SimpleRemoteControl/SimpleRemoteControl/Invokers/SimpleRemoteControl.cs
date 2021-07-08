using SimpleRemoteControl.Commands.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRemoteControl.Invokers
{
    public class SimpleRemoteControl
    {
        ICommand _slot;
        public void SetCommand(ICommand command) => _slot = command;
        public void ButtonWasPressed() => _slot.Execute();
    }
}
