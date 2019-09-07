using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarageExercise.Vehicles.Cars
{
    class SUV : Vehicle
    {
        public SUV(FuelStatus fuelStatus, string color, int passengerCap)
        {
            FuelAtPresent = fuelStatus;
            Color = color;
            PassengerCapacity = passengerCap;
        }
        public override void Drive()
        {
            Console.WriteLine("driving my SUV");
        }

        public override void Brake()
        {
            Console.WriteLine("Slowing down in my SUV");
        }

        public override void Refuel()
        {
            Console.WriteLine("I need to refuel my SUV");
        }
    }
}
