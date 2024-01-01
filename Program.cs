using System;
namespace OOPSample
{
    class Car
    {

        public string model;
        public string color;
        public int year;

        public Car(string carModel, string carColor, int makeYear)
        {
            model = carModel;
            color = carColor;
            year = makeYear;
        }
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter your car model");
            string model = Console.ReadLine();

            Console.WriteLine("Enter you car color");
            string color = Console.ReadLine();

            Console.WriteLine("Enter the make year");
            int year = Convert.ToInt32(Console.ReadLine());

            Car car1 = new Car(model, color, year);
            Console.WriteLine("Your car is: " + car1.model + "\t" + car1.color + "\t" + car1.year);

        }
    }
}