using SimpleRemoteControl.Commands.Abstraction;
using SimpleRemoteControl.Recievers;

namespace SimpleRemoteControl.Commands
{
    public class LightOffCommand : ICommand
    {
        Light Light;
        public LightOffCommand(Light Light)
        {
            this.Light = Light;
        }
        public void Execute() => Light.TurnOff();
    }
}
