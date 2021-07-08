using RemoteControl.Command;
using RemoteControl.Recievers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControl
{
    class Program
    {
        static void Main(string[] args)
        {
            var remoteControl = new Invokers.RemoteControl();

            Light livingRoomLight = new Light("Living Room");
            Light kitchenLight = new Light("Kitchen");
            CeilingFan ceilingFan = new CeilingFan("Living Room");
            GarageDoor garageDoor = new GarageDoor("Near the garder");
            Stereo stereo = new Stereo("Living Room");

            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);
            LightOnCommand kitchenLightOn = new LightOnCommand(kitchenLight);
            LightOffCommand kitchenLightOff = new LightOffCommand(kitchenLight);

            CeilingFanOnCommand ceilingFanOn = new CeilingFanOnCommand(ceilingFan);
            CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

            GarageDoorUpCommand garageDoorUp = new GarageDoorUpCommand(garageDoor);
            GarageDoorDownCommand garageDoorDown = new GarageDoorDownCommand(garageDoor);

            StereoOnWithCDCommand stereoOnWithCD = new StereoOnWithCDCommand(stereo);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);

            remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remoteControl.SetCommand(1, kitchenLightOn, kitchenLightOff);
            remoteControl.SetCommand(2, ceilingFanOn, ceilingFanOff);
            remoteControl.SetCommand(3, stereoOnWithCD, stereoOff);
            remoteControl.SetCommand(4, garageDoorUp, garageDoorDown);


            Console.WriteLine(remoteControl);

            remoteControl.OnButtonWasPressed(0);
            remoteControl.OffButtonWasPressed(0);
            remoteControl.OnButtonWasPressed(1);
            remoteControl.OffButtonWasPressed(1);
            remoteControl.OnButtonWasPressed(2);
            remoteControl.OffButtonWasPressed(2);
            remoteControl.OnButtonWasPressed(3);
            remoteControl.OffButtonWasPressed(3);
            remoteControl.OnButtonWasPressed(4);
            remoteControl.OffButtonWasPressed(4);

            Console.ReadLine();
        }
    }
}
