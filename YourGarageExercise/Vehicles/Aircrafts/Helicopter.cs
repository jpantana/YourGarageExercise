using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarageExercise.Vehicles.Aircrafts
{
    class Helicopter : Vehicle
    {
        public Helicopter(FuelStatus fuelStatus, string color, int passengerCap)
        {
            FuelAtPresent = fuelStatus;
            Color = color;
            PassengerCapacity = passengerCap;
        }
        public override void Drive()
        {
            Console.WriteLine("flying my helicopter");
        }

        public override void Brake()
        {
            Console.WriteLine("reducing speed in my helicopter");
        }

        public override void Refuel()
        {
            Console.WriteLine("In-air refuel my helicopter");
        }
    }
}
