using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //DONE- Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.

            var lot = new CarLot();

            //TODO

            //DONE- Create a seperate class file called Car
            //DONE - Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //DONE- Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //DONE- The methods should take one string parameter: the respective noise property


            //DONE- Now that the Car class is created we can instanciate 3 new cars
            //DONE- Set the properties for each of the cars
            //DONE- Call each of the methods for each car

            //Method 1- Using Dot Notation
            var michaelsCar = new Car();
            michaelsCar.Make = "Ford";
            michaelsCar.Model = "Focus";
            michaelsCar.Year = 2013;
            michaelsCar.EngineNoise = "vroom";
            michaelsCar.HonkNoise = "beep";
            michaelsCar.IsDriveable = true;

            lot.Cars.Add(michaelsCar);

            //Method 2- Object Initializer Syntax
            var stevesCar = new Car()
            {
                Year = 2019,
                Make = "Tesla",
                Model = "Cyber Truck",
                EngineNoise = "...",
                HonkNoise = "brmmp",
                IsDriveable = false
            };

            lot.Cars.Add(stevesCar);

            //Method 3- Using the Constructor to allow parameter values to be placed inside properties
            var brettsCar = new Car(2013, "Honda", "Civic", "vrrrooooom", "vruuuuga", true);

            lot.Cars.Add(brettsCar);

            //Call Methods
            michaelsCar.MakeEngineNoise(michaelsCar.EngineNoise);
            stevesCar.MakeEngineNoise(stevesCar.EngineNoise);
            brettsCar.MakeEngineNoise(brettsCar.EngineNoise);


            //*************BONUS*************//

            // DONE- Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //DONE- Create a CarLot class
            //DONE- It should have at least one property: a List of cars

            //DONE- At the end iterate through the list printing each of car's Year, Make, and Model to the console

            foreach (var car in lot.Cars)
            {
                Console.WriteLine($" Year {car.Year}, Make {car.Make}, Model {car.Model}");
            }
        }
    }
}
