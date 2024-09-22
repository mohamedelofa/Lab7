using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
	internal class Rectangle : GeoShabe
	{
		public Rectangle(int dim1 , int dim2) : base(dim1, dim2) { }
		public override double CalcArea()
		{
			Console.Write($"Rectangle Area = ");
			return Dim1 * Dim2;
		}
	}
}
