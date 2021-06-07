using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
	internal class Shape : IDrawable
	{
		public List<Point> dotes = new List<Point>();

		

		string name;
		string color;
		int amountOfDotes;
		double widthOfLine;
		string colorOfLine;

		public int getAmountOfDotes()
		{
			return amountOfDotes;
		}

		public void setAmountOfDotes(int amountOfDotes)
		{
			this.amountOfDotes = amountOfDotes;
		}


		public Shape(string name, string color, double widthOfLine, string colorOfLine)
		{
			this.name = name;
			this.color = color;
			this.widthOfLine = widthOfLine;
			this.colorOfLine = colorOfLine;

		}

		public Shape()
		{

		}

		public virtual Point[] GetPoints(List<Point> dotes)
		{
			return dotes.ToArray();
		}

		public virtual void addDote(int x, int y, int amountOfDotes)
		{
			if (dotes.Count <= amountOfDotes)
			{
				dotes.Add(new Point(x, y));
			}

		}

		public virtual void Draw(List<Point> dotes, double widthOfLine, string colorOfLine)
		{

		}
		


		public virtual double FindDistanceBetweenTwoPoints(Point point1, Point point2)
		{

			double distance = Math.Sqrt(Math.Pow((point2.X - point1.X), 2) + Math.Pow((point2.Y - point1.Y), 2));


			return distance;
		}


		public virtual double FindAreaOFAShape(Shape shape)
		{
			
			return 0;
		}

		public virtual double FindAreaOFAShape(Circle circle)
		{

			return 0;
		}

		public virtual double FindAreaOFAShape(Rectangle rectangle)
		{

			return 0;
		}


		public virtual double FindAreaOFAShape(Trinagle trinagle)
		{

			return 0;
		}



		public virtual double FindPerimeterOfShape(Shape shape)
		{

			return 0;
		}

		public virtual double FindPerimeterOfShape(Rectangle rectangle)
		{

			return 0;
		}



		public virtual double FindPerimeterOfShape(Circle circle)
		{

			return 0;
		}


		public virtual double FindPerimeterOfShape(Trinagle trinagle)
		{

			return 0;
		}

	

	}
}
