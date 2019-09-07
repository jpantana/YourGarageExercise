using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarageExercise.Cars
{
    // Include properties for fuel/battery capacity, color, and passenger occupancy
    class Car
    {
        public FuelStatus FuelAtPresent { get; set; }
        public string Color { get; set; }
        public int PassengerCapacity { get; set; }
    }
    enum FuelStatus
    {
        Full,
        Half_A_Tank,
        Getting_Low,
        Empty,
    }
}
