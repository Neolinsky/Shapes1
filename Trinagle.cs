using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
	class Trinagle : Shape
	{

		public Trinagle
			(
			string name,
			string color,
			double widthOfLine,
			string colorOfLine

			) : base(name, color, widthOfLine, colorOfLine)
		{

		}

		public Trinagle(Point Dote1, Point Dote2, Point Dote3)
		{
			dotes.Add(new Point(Dote1.X, Dote1.Y));
			dotes.Add(new Point(Dote2.X, Dote2.Y));
			dotes.Add(new Point(Dote3.X, Dote3.Y));
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



		public override double FindDistanceBetweenTwoPoints(Point point1, Point point2)
		{

			double distance = Math.Sqrt(Math.Pow((point2.X - point1.X), 2) + Math.Pow((point2.Y - point1.Y), 2));


			return distance;
		}


		public  double FindAreaOFAShape(Trinagle trinagle)
		{
			Point[] points = trinagle.GetPoints(trinagle.dotes);
			double side1 = trinagle.FindDistanceBetweenTwoPoints(points[0], points[1]);
			double side2 = trinagle.FindDistanceBetweenTwoPoints(points[1], points[2]);
			double side3 = trinagle.FindDistanceBetweenTwoPoints(points[2], points[0]);

			double halfPeritmetr = (side2 + side1 + side3) / 2;

			double area = Math.Sqrt(halfPeritmetr * (halfPeritmetr - side1) * (halfPeritmetr - side2) * (halfPeritmetr - side3));

			return area;
		}

		public virtual double FindPerimeterOfShape(Trinagle trinagle)
		{

			Point[] points = trinagle.GetPoints(trinagle.dotes);
			double side1 = trinagle.FindDistanceBetweenTwoPoints(points[0], points[1]);
			double side2 = trinagle.FindDistanceBetweenTwoPoints(points[1], points[2]);
			double side3 = trinagle.FindDistanceBetweenTwoPoints(points[2], points[0]);

			return side1 + side2 + side3;
		}

	}
}
