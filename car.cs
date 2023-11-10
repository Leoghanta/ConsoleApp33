using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
	internal class car
	{
		private string name;

		public string getName() { return name; }

		public void setName(string name) { this.name = name;}

		public car(string name)
		{
			this.name = name;
		}

	}
}
