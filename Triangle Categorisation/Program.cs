using System;

namespace Triangle_Categorisation
{
	class Program
	{
		Triangle triangle;
		
		public static void Main(string[] args)
		{
			Program program = new Program();
			program.Sides();
			
		}
		
		private void Sides()
		{
			
			double sideA = 0;
			double sideB = 0;
			double sideC = 0;
			string input;
			
			while(true){
			Console.Write("Enter three sides of a triangle. (eg. 3 4 5)\n");
			input = Console.ReadLine();
			string[] values = input.Split(' ');

            //Test for integers entered
			try{
				Double.TryParse(values[0], out sideA);
				Double.TryParse(values[1], out sideB);
				Double.TryParse(values[2], out sideC);	
			}
			catch {
				Console.WriteLine("Please enter three numbers only!\n");
				continue;
			}

			triangle = new Triangle(sideA, sideB, sideC);
			string output = triangle.TriangleType();
			Console.WriteLine(output);
			}
		}
		
	}
}