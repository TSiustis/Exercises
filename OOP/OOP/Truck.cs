using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Truck : Vehicle
    {

		public int maxCargo { get; set; }


		public Truck(int year, int wheels, String model, int horsepower,String Color,int maxCargo) : base(year, wheels, model, horsepower, Color)
		{

			this.maxCargo = maxCargo;
		}


		

	}
}
