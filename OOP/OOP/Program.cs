using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        public static List<Vehicle> vehicles = new List<Vehicle> { new Car(2009, 4, "Toyota Corolla", 132, "Red"), new Truck(2019, 4, "Volkswagen Tiguan", 184, "Green", 65700), new Motorcycle(2019, 2, "Honda CB300R", 31, "Red"),
                                                                    new Car(2013,4, "Volvo C70", 227,"White"), new Motorcycle(2015,3, "Harley-Davidson Freewheeler", 85,"Black")};

        static void Main(string[] args)
        {
           foreach(Vehicle item in vehicles)
            {
                Console.WriteLine("Type of vehicle: " + item.GetType() + " Brand and model: " + item.Model + " Year: " + item.Year + " Horsepower: " + item.Horsepower + " Color: " + item.Color);
               
            }
        }
    }
}

