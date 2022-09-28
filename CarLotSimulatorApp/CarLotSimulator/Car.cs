using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {
            CarLot.NumberOfCars++;
        }
        public string Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
            public static void MakeEngineNoise(string eNoise)
            {
            Console.WriteLine(eNoise);
            }
        public string HonkNoise { get; set; }
            public static void MakeHonkNoise(string hNoise)
            {
            Console.WriteLine(hNoise);
            }
        public string IsDriveable { get; set; }
    }
}
