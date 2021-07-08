using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRemoteControl.Recievers
{
    public class GarageDoor
    {
        public void Up() => Console.WriteLine("Garage door is opened");
        public void Down() => Console.WriteLine("Garage door is closed");
        public void Stop() => Console.WriteLine("Garage Door is Stopped");
        public void LightOn() => Console.WriteLine("Garage light is on");
        public void LightOff() => Console.WriteLine("Garage light is off");
    }
}
