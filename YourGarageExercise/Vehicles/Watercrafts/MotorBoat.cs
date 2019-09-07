using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarageExercise.Vehicles.Watercrafts
{
    class MotorBoat : Watercraft
    {
        public MotorBoat(FuelStatus fuelStatus, string color, int passengerCap)
        {
            FuelAtPresent = fuelStatus;
            Color = color;
            PassengerCapacity = passengerCap;
        }
        public override void Drive()
        {
            Console.WriteLine("driving my motorboat");
        }

        public override void Brake()
        {
            Console.WriteLine("slowing down my motorboat");
        }

        public override void Refuel()
        {
            Console.WriteLine("I need to refuel my motorboat");
        }
    }
}
