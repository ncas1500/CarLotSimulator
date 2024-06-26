using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {

            var lot = new CarLot();
            

            var carOne = new Car();
            carOne.Year = 2024;
            carOne.Make = "Genesis";
            carOne.Model = "G90";
            carOne.EngineNoise = "Quiet";
            carOne.HonkNoise = "Loud";
            carOne.IsDriveable = true;

            lot.Cars.Add(carOne);

            var carTwo = new Car()
            {
                Year = 2024,
                Make = "Cadillac",
                Model = "Escalade",
                EngineNoise = "Quiet",
                HonkNoise = "Loud",
                IsDriveable = true,
            };

            lot.Cars.Add(carTwo);

            var carThree = new Car(2023, "Lexus", "LS", "Quiet", "quiet", true);

            lot.Cars.Add(carThree);

            carOne.MakeEngineNoise(carOne.EngineNoise);
            carOne.MakeHonkNoise(carOne.HonkNoise);
            carTwo.MakeEngineNoise(carTwo.EngineNoise);
            carTwo.MakeHonkNoise(carThree.HonkNoise);
            carThree.MakeEngineNoise(carThree.EngineNoise);
            carThree.MakeHonkNoise(carThree.HonkNoise);


            foreach (var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model} ");
                
            }



            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
