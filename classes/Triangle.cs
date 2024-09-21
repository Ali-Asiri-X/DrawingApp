using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace DrawingApp.classes
{
    public class Triangle : Shape { 
        Point p1;
        Point p2;
        Point p3;
        double height;
        int width;
        static int counter = 0;
        string name;
        bool selected = false;
        public Triangle(int panelWidth, int panelHeight)
        {
            Random rand = new Random();
            width = rand.Next(50,200);
            name = "Triangle " + counter;
            counter++;
            height = width * Math.Sqrt(3) / 2;
            p1 = new Point(rand.Next(panelWidth - 200), rand.Next(200,panelHeight - 200));
            p2 = new Point(p1.X + width, p1.Y);
            p3 = new Point(p1.X + width / 2, p1.Y - (int) height);
        }

        public override void Draw(Graphics graphics, Pen pen)
        {
            //use the points to draw the triangle         
            if(selected)
            {
                graphics.DrawPolygon(new Pen(Color.Red, 10), new Point[] { p1, p2, p3 });
            }
            else
            {
                graphics.DrawPolygon(pen, new Point[] { p1, p2, p3 });
            }
            
        }

        public override string getInformation()
        {
          return name + "  ( X: " + p1.X + " Y: " + p1.Y + " )    Width: " + width + "    Height: " + height;
        }

        public override string getName()
        {
            return name;
        }

        public override bool isSelected()
        {
           return selected;
        }

        public override bool ContainsPoint(Point point)
        {
            double area = Area(p1, p2, p3);
            double area1 = Area(point, p2, p3);
            double area2 = Area(p1, point, p3);
            double area3 = Area(p1, p2, point);

            return area == area1 + area2 + area3;
        }
        private double Area(Point p1, Point p2, Point p3)
        {
            return Math.Abs((p1.X * (p2.Y - p3.Y) + p2.X * (p3.Y - p1.Y) + p3.X * (p1.Y - p2.Y)) / 2.0);
        }
        public override void setSelected(bool state)
        {
            selected = state;
        }
    }
}
