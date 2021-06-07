using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
	interface IDrawable
	{
		void Draw(List<Point> dotes, double widthOfLine, string colorOfLine);
		double FindAreaOFAShape(Shape shape);
		double FindPerimeterOfShape(Shape shape);
	}
}
