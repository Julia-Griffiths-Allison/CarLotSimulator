using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    internal class CarLot
    {
        public static int NumberOfCars;

            public List<Car> ParkingLot {get; set;} = new List<Car>();
    }
}