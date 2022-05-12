using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//


            var carLot = new CarLot();

            var toyota = new Car();
            toyota.Make = "Toyota";
            toyota.Model = "Corolla";
            toyota.Year = 2016;
            toyota.EngineNoise = "vroom";
            toyota.HonkNoise = "beep";
            toyota.IsDrivable = true;

            var audi = new Car()
            {
                Make = "Audi",
                Model = "A6",
                Year = 2017,
                EngineNoise = "vroom vroom turbo",
                HonkNoise = "beep beep",
                IsDrivable = true
            };

            Car chevy = new Car(2021, "Corvette", "Vroooom", "Beep beep beep", true, "Chevy");


            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console



            carLot.ParkingLot = new List<Car>() { toyota, audi, chevy };

            foreach (var car in carLot.ParkingLot)
            {
                Console.WriteLine($"{car.Year} {car.Make} {car.Model}");
                car.MakeEngineNoise();
                car.MakeHonkNoise();
                Console.WriteLine("---------------------------");
            }

        }
    }
}
