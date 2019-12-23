using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<decimal> CalculateFuel(decimal mass)
            {
                while (mass > 0)
                {
                    mass = Math.Floor(mass / 3) - 2;
                    yield return mass > 0 ? mass : 0;
                }
            }

            var totalFuel = File.ReadAllLines(@"input.txt")
                .Sum(line => CalculateFuel(decimal.Parse(line)).Sum());

            Console.WriteLine($"Fuel: {totalFuel}");
        }
    }
}