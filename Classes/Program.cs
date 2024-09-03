using System.Security.Cryptography.X509Certificates;

namespace Classes
{
    public class Program
    {
        public class Car
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public string Color { get; set; }
        }
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
