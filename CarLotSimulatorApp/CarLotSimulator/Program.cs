using System;
using System.Xml.Schema;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            //Create a seperate class file called Car X
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable X
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise() X
            //The methods should take one string parameter: the respective noise property X

            var carLot = new CarLot();
     
            Car car1 = new Car();
            car1.Year = "1999";
            car1.Make = "Chevrolet";
            car1.Model = "Malibu";
            car1.EngineNoise = "Vrrr bumbumbumbum rrrrrrrr...";
            car1.HonkNoise = "Meep meeee";
            car1.IsDriveable = "This car is uncomfortably road-safe.";
            Car.MakeEngineNoise(car1.EngineNoise);
            Car.MakeHonkNoise(car1.HonkNoise);
            carLot.ParkingLot.Add(car1);
            Console.WriteLine($"We have {CarLot.NumberOfCars} car in our lot");


            Car car2 = new Car();
            car2.Year = "2004";
            car2.Make = "Toyota";
            car2.Model = "4Runner";
            car2.EngineNoise = "rrRRRRRrrrrrr";
            car2.HonkNoise = "BRRRRRP";
            car2.IsDriveable = "This car is totalled.";
            Car.MakeEngineNoise(car2.EngineNoise);
            Car.MakeHonkNoise(car2.HonkNoise);
            carLot.ParkingLot.Add(car2);
            Console.WriteLine($"We have {CarLot.NumberOfCars} cars in our lot");

            Car car3 = new Car();
            car3.Year = "2018";
            car3.Make = "Kia";
            car3.Model = "Optima";
            car3.EngineNoise = "RRRvvvvv...";
            car3.HonkNoise = "meeep";
            car3.IsDriveable = "This car is in pristeen condition.";
            Car.MakeEngineNoise(car3.EngineNoise);
            Car.MakeHonkNoise(car2.HonkNoise);
            carLot.ParkingLot.Add(car3);
            Console.WriteLine($"We have {CarLot.NumberOfCars} cars in our lot");

            // CarPractice car4 = new CarPractice();
            // car4.year = "2022";
            // car4.make = "Tesla";
            // car4.model = "Model X";
            // car4.engineNoise = "varoooommm";
            // car4.honkNoise = "*The National Anthem*";
            // car4.isDriveable = "This car is in perfect condition.";


            foreach (var car in carLot.ParkingLot)
            {
                Console.WriteLine(car.Year);
                Console.WriteLine(car.Make);
                Console.WriteLine(car.Model);

            }

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
