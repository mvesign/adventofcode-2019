using System;
using System.IO;
using System.Linq;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            void ProcessIntcode(int[] intcode)
            {
                for(var position = 0; position + 4 < intcode.Length; position += 4)
                {
                    var noun = intcode[position + 1];
                    var verb = intcode[position + 2];
                    var result = intcode[position + 3];

                    switch (intcode[position])
                    {
                        case 1:
                            intcode[result] = intcode[noun] + intcode[verb];
                            break;
                        case 2:
                            intcode[result] = intcode[noun] * intcode[verb];
                            break;
                        case 99:
                            return;
                    }
                }
            }

            var intcode = File.ReadAllText("input.txt")
                .Split(',')
                .Select(value => int.Parse(value))
                .ToArray();
            
            intcode[1] = 12;
            intcode[2] = 2;

            ProcessIntcode(intcode);
            
            Console.WriteLine($"Value: {intcode[0]}");
        }
    }
}