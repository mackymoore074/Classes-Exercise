using System.Security.Cryptography.X509Certificates;
using System;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Chevrolet";
            myCar.Model = "Camaro";
            myCar.Year = 2021;
            myCar.Color = "Red";

            Console.WriteLine($"My car is a {myCar.Year} {myCar.Make} {myCar.Model} and it is {myCar.Color}.");
           
        }
    }
}
