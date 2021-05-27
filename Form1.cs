using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{

		Rectangle rectangle1 = new Rectangle(new Point(0, 0), new Point(100, 0), new Point(100, 300),
				new Point(0, 300));

		Trinagle triangle = new Trinagle(new Point(200, 300), new Point(250, 0), new Point(300, 300));

		Circle circle = new Circle(new Point(0, 0), 100);



		public Form1()
		{
			InitializeComponent();


		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			

			Graphics g = pictureBox1.CreateGraphics();

			SolidBrush brushr = new SolidBrush(Color.Red);
			SolidBrush brushy = new SolidBrush(Color.Yellow);
			SolidBrush brushg = new SolidBrush(Color.Green);
			SolidBrush brushW = new SolidBrush(Color.White);


			Pen pen = new Pen(Color.Black, 2);


		
			
			Circle circle1 = new Circle(new Point(0, 100), 100);
			Circle circle2 = new Circle(new Point(0, 200), 100);


			Trinagle triangle1 = new Trinagle(new Point(235,100), new Point(255, 280), new Point(265, 100));

			Point[] curve1 = rectangle1.GetPoints(rectangle1.dotes);
			Point[] curve2 = triangle.GetPoints(triangle.dotes);
			Point[] curve3 = triangle.GetPoints(circle.dotes);
			Point[] curve4 = triangle.GetPoints(circle1.dotes);
			Point[] curve5 = triangle.GetPoints(circle2.dotes);
			Point[] curve6 = triangle.GetPoints(triangle1.dotes);




			g.FillPolygon(brushr, curve2);
			g.DrawPolygon(pen, curve6);
			g.FillPolygon(brushW, curve6);

			g.DrawPolygon(pen, curve1);

			




			g.DrawPolygon(pen, curve2);
			
			g.DrawEllipse(pen, curve3[0].X, curve3[0].Y, circle.getRadius(), circle.getRadius());
			g.DrawEllipse(pen, curve4[0].X, curve4[0].Y, circle.getRadius(), circle.getRadius());
			g.DrawEllipse(pen, curve5[0].X, curve5[0].Y, circle.getRadius(), circle.getRadius());

			g.FillEllipse(brushr, curve3[0].X, curve3[0].Y, circle.getRadius(), circle.getRadius());
			g.FillEllipse(brushy, curve4[0].X, curve4[0].Y, circle.getRadius(), circle.getRadius());
			g.FillEllipse(brushg, curve5[0].X, curve5[0].Y, circle.getRadius(), circle.getRadius());



		}

		private void button2_Click(object sender, EventArgs e)
		{		
			double area = rectangle1.FindAreaOFAShape(rectangle1);
			textBox1.Text = area.ToString();
		}

		private void button3_Click(object sender, EventArgs e)
		{			
			double area = triangle.FindAreaOFAShape(triangle);
			textBox1.Text = area.ToString();
		}

		private void button1_Click(object sender, EventArgs e)
		{	
			double area = circle.FindAreaOFAShape(circle);
			textBox1.Text = area.ToString();
		}

		private void button4_Click(object sender, EventArgs e)
		{			
			double perimeter = rectangle1.FindPerimeterOfShape(rectangle1);
			textBox1.Text = perimeter.ToString();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			double perimeter = triangle.FindPerimeterOfShape(triangle);
			textBox1.Text = perimeter.ToString();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			double perimeter = circle.FindPerimeterOfShape(circle);
			textBox1.Text = perimeter.ToString();
		}
	}
}
