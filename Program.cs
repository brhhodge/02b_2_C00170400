//Brian Hodge
//C00170400
//CMPS 358
//assignment #02b_2

using System;

namespace _02b_2_C00170400
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter measurement (in feet) to convert into meters: ");
            double lengthFt = Double.Parse(Console.ReadLine());

            Console.WriteLine($"{lengthFt} feet = {convert(lengthFt)} meters.");

        }

        static double convert(double feet) 
        {
            double meters;
            double factor = 0.3048;
            double newMeasurement = feet * factor;
            meters = newMeasurement;

            return meters;
        }
    }
}
