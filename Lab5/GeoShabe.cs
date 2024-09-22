using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
	internal abstract class GeoShabe
	{
		public int Dim1 { get; set; }
		public int Dim2 { get; set; }
		public GeoShabe(int dim1 , int dim2)
		{
			Dim1 = dim1;
			Dim2 = dim2;
		}
		public abstract double CalcArea();
	}
}
