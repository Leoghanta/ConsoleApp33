using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
	internal class racecar : car
	{
		double topspeed;

		public racecar(string name, double topspeed) : base(name)
		{
			this.topspeed = topspeed;
		}


	}
}
