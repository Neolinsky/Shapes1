using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace WindowsFormsApp1
{
	class Rectangle : Shape
	{



		public Rectangle
			(
			string name,
			string color,
			double widthOfLine,
			string colorOfLine

			) : base(name, color, widthOfLine, colorOfLine)
		{

		}

		public Rectangle(Point Dote1, Point Dote2, Point Dote3, Point Dote4)
		{
			dotes.Add(new Point(Dote1.X, Dote1.Y));
			dotes.Add(new Point(Dote2.X, Dote2.Y));
			dotes.Add(new Point(Dote3.X, Dote3.Y));
			dotes.Add(new Point(Dote4.X, Dote4.Y));

		}


		public override void addDote(int x, int y, int amountOfDotes)
		{
			if (dotes.Count < amountOfDotes)
			{
				dotes.Add(new Point(x, y));
			}

		}

		public override void Draw(List<Point> dotes, double widthOfLine, string colorOfLine)
		{


		}

		public override Point[] GetPoints (List<Point> dotes)
		{
			return dotes.ToArray();
		}


		public override double FindDistanceBetweenTwoPoints(Point point1, Point point2)
		{

			double distance = Math.Sqrt(Math.Pow((point2.X - point1.X), 2) + Math.Pow((point2.Y - point1.Y), 2));


			return distance;
		}


	

		public override double FindAreaOFAShape(Rectangle rectangle)
		{

			Point[] points = rectangle.GetPoints(rectangle.dotes);
			double side1 = rectangle.FindDistanceBetweenTwoPoints(points[0], points[1]);
			double side2 = rectangle.FindDistanceBetweenTwoPoints(points[1], points[2]);

			double area = side1 * side2;
			return area;
		}

		public override double FindPerimeterOfShape(Rectangle rectangle)
		{
			Point[] points = rectangle.GetPoints(rectangle.dotes);
			double side1 = rectangle.FindDistanceBetweenTwoPoints(points[0], points[1]);
			double side2 = rectangle.FindDistanceBetweenTwoPoints(points[1], points[2]);

			double Perimeter = (side1 + side2) * 2;
			return Perimeter;
		}

	}
}
