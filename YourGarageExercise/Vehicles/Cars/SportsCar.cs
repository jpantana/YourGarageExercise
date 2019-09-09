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
            if (FuelAtPresent == FuelStatus.Empty)
            {
                Console.WriteLine($"Your running on {FuelAtPresent}, and need to refuel before you drive.");
                return;
            }
            Console.WriteLine("Driving my Sportscar");
        }

        public override void Brake()
        {

            Console.WriteLine($"Your car can hold {PassengerCapacity}. How many people (including yourself) are in the vehicle?");
            var howManyRiding = int.Parse(Console.ReadLine());
            Console.WriteLine($"There are {howManyRiding} people in my Sportscar");
            if (PassengerCapacity == howManyRiding)
            {
                Console.WriteLine("You need to slow down, bc you've got a full vehicle.");
            }

        }

        public override void Refuel()
        {
            Console.WriteLine(FuelAtPresent);
        }
    }
}
