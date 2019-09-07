using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarageExercise.Vehicles.Cars
{
    class SportsCar : Vehicle
    {
        public SportsCar(FuelStatus fuelStatus, string color, int passengerCap)
        {
            FuelAtPresent = fuelStatus;
            Color = color;
            PassengerCapacity = passengerCap;
        }
        public override void Drive()
        {
            Console.WriteLine("Driving my Sportscar");
        }

        public override void Brake()
        {
            Console.WriteLine("Slowing down in my sportscar");
        }

        public override void Refuel()
        {
            Console.WriteLine("Need to refuel my sportscar");
        }
    }
}
