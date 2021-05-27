using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
	class Circle : Shape
	{
		int radius;
		double radiusD;

		public Circle
			(
			string name,
			string color,
			double widthOfLine,
			string colorOfLine

			) : base(name, color, widthOfLine, colorOfLine)
		{

		}

		public Circle(Point Dote1, Point Dote2)
		{
			dotes.Add(new Point(Dote1.X, Dote1.Y));
			dotes.Add(new Point(Dote2.X, Dote2.Y));
		}

		public Circle(Point Dote1, int radius)
		{
			dotes.Add(new Point(Dote1.X, Dote1.Y));
			this.radius = radius;
		}

		public int getRadius()
		{
			return radius;
		}

		public double getRadius(Point dote1, Point dote2)
		{
			radiusD = Math.Sqrt(Math.Pow((dote2.X - dote1.X), 2) + Math.Pow((dote2.Y - dote1.Y), 2));

			return radius;
		}


		public override void addDote(int x, int y, int amountOfDotes)
		{
			if (dotes.Count < amountOfDotes)
			{
				dotes.Add(new Point(x, y));
			}

		}

		public override Point[] GetPoints(List<Point> dotes)
		{
			return dotes.ToArray();
		}

		public override void Draw(List<Point> dotes, double widthOfLine, string colorOfLine)
		{


		}


		public  override double FindAreaOFAShape(Circle circle)
		{
			double p = 3.14;
			radius = circle.getRadius();
			double area = (p * (radius * radius));
			return area;
		}

		public override double FindPerimeterOfShape(Circle circle)
		{
			radius = circle.getRadius();
			return 2*3.14 * radius;
		}


	}
}
