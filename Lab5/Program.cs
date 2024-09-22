namespace Lab5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter number of shabes : ");
			int size = int.Parse(Console.ReadLine());
			GeoShabe[] Shabes = new GeoShabe[size];
			for(int i = 0; i < size; i++)
			{
				Console.WriteLine("Choose one shape to enter dimension and calculate area : \n 1.Circle \n 2.Rectangle \n 3.Triangle");
				int choice = int.Parse(Console.ReadLine());
				switch(choice)
				{
					case 1:
						Console.Write("Enter Diameter : ");
						int diameter = int.Parse(Console.ReadLine());
						Shabes[i] = new Circle(diameter);
						Console.WriteLine(Shabes[i].CalcArea());
						break;
					case 2:
						Console.Write("Enter Length : ");
						int length = int.Parse(Console.ReadLine());
						Console.Write("Enter Width : ");
						int width = int.Parse(Console.ReadLine());
						Shabes[i] = new Rectangle(length, width);
						Console.WriteLine(Shabes[i].CalcArea());
						break;
					case 3:
						Console.Write("Enter Height : ");
						int height = int.Parse(Console.ReadLine());
						Console.Write("Enter Base : ");
						int _base = int.Parse(Console.ReadLine());
						Shabes[i] = new Triangle(height, _base);
						Console.WriteLine(Shabes[i].CalcArea());
						break;
				}
			}

			
		}
	}
}
