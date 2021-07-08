using RemoteControl.Command;
using RemoteControl.Command.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControl.Invokers
{
    public class RemoteControl
    {
        private readonly ICommand[] _onCommands;
        private readonly ICommand[] _offCommands;

        public RemoteControl()
        {
            _onCommands = new ICommand[7];
            _offCommands = new ICommand[7];

            for (int i = 0; i < 7; i++)
            {
                _onCommands[i] = new NoCommand();
                _offCommands[i] = new NoCommand();
            }
        }
        public void SetCommand(int index, ICommand onCommand, ICommand offCommand)
        {
            _onCommands[index] = onCommand;
            _offCommands[index] = offCommand;
        }

        public void OffButtonWasPressed(int index)
        {
            _offCommands[index].Execute();
        }

        public void OnButtonWasPressed(int index)
        {
            _onCommands[index].Execute();
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append("\n------ Remote Control -------\n");

            for (int i = 0; i < _onCommands.Length; i++)
            {
                stringBuilder.Append("[slot " + i + "] " + _onCommands[i].GetType().Name + "    " + _offCommands[i].GetType().Name + "\n");
            }

            return stringBuilder.ToString();
        }
    }
}
