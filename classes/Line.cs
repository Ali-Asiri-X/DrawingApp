using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingApp.classes
{
    public class Line : Shape
    {
        private static int counter = 0;
        private Point p1;
        private Point p2;
        private string name;
        bool selected = false;
        public Line(int panelWidth, int panelHeight)
        {
            Random rand = new Random();
            p1 = new Point(rand.Next(panelWidth),rand.Next(panelHeight));
            p2 = new Point(rand.Next(panelWidth), rand.Next(panelHeight));
            name = "Line " + counter;
            counter++;
        }

        public override void Draw(Graphics graphics, Pen pen)
        {
            if(selected)
            {
                graphics.DrawLine(new Pen(Color.Red, 10), p1, p2);
            }
            else
            {
                graphics.DrawLine(pen, p1, p2);
            }
        }

        public override string getInformation()
        {
            return   name + " Start Point: ( " + p1 + " ) End Point: ( " + p2 +" )";
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
            // Calculate the distances from the point to the endpoints of the line
            double d1 = Math.Sqrt(Math.Pow(point.X - p1.X, 2) + Math.Pow(point.Y - p1.Y, 2));
            double d2 = Math.Sqrt(Math.Pow(point.X - p2.X, 2) + Math.Pow(point.Y - p2.Y, 2));

            // Calculate the length of the line
            double lineLength = Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));

            // If the sum of d1 and d2 is equal to the length of the line (with a small error margin),
            // then the point is on the line
            return Math.Abs(d1 + d2 - lineLength) < 0.1; //by increasing the error margin, the selection area increases
        }
        public override void setSelected(bool state)
        {
            selected = state;
        }
    }
}
