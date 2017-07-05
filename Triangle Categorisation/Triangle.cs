using System;

namespace Triangle_Categorisation
{

	public class Triangle
	{
		public double sideA;
		public double sideB;
		public double sideC;
		
		public Triangle(double a, double b, double c)
		{		
			this.sideA = a;
			this.sideB = b;
			this.sideC = c;
		}
		
		public string TriangleType(){
			
			double answer1, answer2, longSide, side1, side2;
			side1 = side2 = longSide = 0;
			//If sideA is the largest side
			if (this.sideA > this.sideB && this.sideA > this.sideC){
				 longSide = this.sideA;
				 side1 = this.sideB;
				 side2 = this.sideC;
			}
			//If sideB is the largest side
			else if (this.sideB > this.sideA && this.sideB > this.sideC ){
				side1 = this.sideA;
				longSide = this.sideB;
				side2 = this.sideC;
			}
			//If sideC is the largest side
			else if (this.sideC > this.sideA && this.sideB < this.sideC ){
				side1 = this.sideA;
				side2 = this.sideB;
				longSide = this.sideC;
			}
			else {
				longSide = this.sideA;
				side1 = this.sideB;
				side2 = this.sideC;
			}
			
			//Determine the type of triangle
            answer1 = Math.Pow(side1, 2) + Math.Pow(side2, 2);
            answer2 = Math.Pow(longSide, 2);
            if (answer1 > answer2)
            {
                const string output = "The triangle is an acute angle triangle\n";
                return output;
            }
            else if (answer1 < answer2)
            {
                const string output = "The triangle is an obtuse angle triangle\n";
				return output;
            }
            else if (answer1.Equals(answer2))
            {
                const string output = "The triangle is an right angle triangle\n";
                return output;
            }
            
			return "";
		
		}
		
	}
}
