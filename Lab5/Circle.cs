using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
	internal class Circle:GeoShabe
	{
		public Circle(int dim):base(dim , dim) { }
		public override double CalcArea()
		{
			Console.Write($"Circle Area = ");
			return 3.14 * Dim1 * Dim1;
		}
	}
}
