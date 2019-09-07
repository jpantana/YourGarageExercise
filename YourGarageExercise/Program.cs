using System;
using YourGarageExercise.Vehicles;
using YourGarageExercise.Vehicles.Cars;

namespace YourGarageExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var newSportsCar = new SportsCar(FuelStatus.Empty, "Blue", 4);

            newSportsCar.Drive();
        }
    }
}
