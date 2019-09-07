using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarageExercise.Vehicles.Watercrafts
{
    class CruiseLiner : Watercraft
    {
        public CruiseLiner(FuelStatus fuelStatus, string color, int passengerCap)
        {
            FuelAtPresent = fuelStatus;
            Color = color;
            PassengerCapacity = passengerCap;
        }
        public override void Drive()
        {
            Console.WriteLine("I'm driving a cruisliner");
        }

        public override void Brake()
        {
            Console.WriteLine("Braking in a crusiliner");
        }

        public override void Refuel()
        {
            Console.WriteLine("I need to refuel my cruiseliner");
        }
    }
}
