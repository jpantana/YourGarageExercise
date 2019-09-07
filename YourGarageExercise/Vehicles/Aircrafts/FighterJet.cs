using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarageExercise.Vehicles.Aircrafts
{
    class FighterJet : Vehicle 
    {
        public FighterJet(FuelStatus fuelStatus, string color, int passengerCap)
        {
            FuelAtPresent = fuelStatus;
            Color = color;
            PassengerCapacity = passengerCap;
        }
        public override void Drive()
        {
            Console.WriteLine("flying my fighter jet");
        }

        public override void Brake()
        {
            Console.WriteLine("reducing speed in my jet");
        }

        public override void Refuel()
        {
            Console.WriteLine("refueling my jet");
        }
    }
}
