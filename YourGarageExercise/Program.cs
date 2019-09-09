using System;
using YourGarageExercise.Vehicles;
using YourGarageExercise.Vehicles.Cars;
using YourGarageExercise.Vehicles.Watercrafts;

namespace YourGarageExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var newSportsCar = new SportsCar(FuelStatus.Empty, "Blue", 4);
            newSportsCar.Drive();
            newSportsCar.Refuel();
            newSportsCar.Brake();

            var newMotorBoat = new MotorBoat(FuelStatus.Full, "Gray", 15);
            newMotorBoat.Drive();
            newMotorBoat.Refuel();
        }
    }
}
