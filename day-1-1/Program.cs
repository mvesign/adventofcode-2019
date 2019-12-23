using System;
using System.IO;
using System.Linq;

namespace project
{
    class Program
    {
        static void Main(string[] args)
        {
            var fuel = File.ReadAllLines(@"input.txt")
                .Sum(line => Math.Floor(decimal.Parse(line) / 3) - 2);

            Console.WriteLine($"Fuel: {fuel}");
        }
    }
}