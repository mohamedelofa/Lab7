using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
	internal class Triangle :GeoShabe
	{
		public Triangle(int dim1, int dim2) : base(dim1, dim2) { }
		public override double CalcArea()
		{
			Console.Write($"Triangle Area = ");
			return .5 * Dim1 * Dim2;
		}
	}
}
