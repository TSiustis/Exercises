using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
  public  class Vehicle
    {

        public int Wheels { get; set; }
        public int Horsepower { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }
        public int _Year;
        public int Year { 
            get { return _Year; ; }
            set{
                /*Set limits for year
                 * First year of the modern card: 1886: Motorwagen developed by Karl Benz
                 */
                if (_Year < 1886 || _Year > 2020)
                {
                    throw new ArgumentOutOfRangeException("The year is out of the manufacturing range");
                }
                Year = _Year;
            }
        }
       




        public Vehicle(int year,  int wheels, String model, int horsepower, String color)  
		{
			this._Year = year;
			this.Model = model;
            this.Wheels = wheels;
			this.Horsepower = horsepower;
            this.Model = model;
            this.Color = color;


		}


}
}
