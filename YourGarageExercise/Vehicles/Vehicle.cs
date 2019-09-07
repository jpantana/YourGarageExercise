using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarageExercise.Vehicles
{
    abstract class Vehicle
    {
        public FuelStatus FuelAtPresent { get; set; }
        public int PassengerCap { get; }
        public string Color { get; set; }
        public int PassengerCapacity { get; set; }

        // Methods section
        public abstract void Refuel();

        public abstract void Drive();

        public abstract void Brake();
    }
    public enum FuelStatus
    {
        Full,
        Half_A_Tank,
        Getting_Low,
        Empty,
    }
}
