using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingApp.classes
{
    public class Circle : Shape
    {
        private static int counter = 0;
        private System.Drawing.Rectangle boundingRectangle;
        private string name;
        private bool selected = false;
        int radius;
        Point center;
        public Circle(int panelWidth, int panelHeight)
        {
            Random rand = new Random();

            // Generate a random position for the circle
            center.X = rand.Next(110,panelWidth - 110);
            center.Y = rand.Next(110,panelHeight - 110);

            // Generate a random radius for the circle
            radius = rand.Next(50, 110); 

            // Calculate the bounding rectangle
            boundingRectangle = new System.Drawing.Rectangle(center.X - radius, center.Y - radius, 2 * radius, 2 * radius);
            name = "Circle " + counter;
            counter++;
        }

        public override bool ContainsPoint(Point point)
        {
            double distance = Math.Sqrt(Math.Pow(point.X - center.X, 2) + Math.Pow(point.Y - center.Y, 2));
            return distance <= radius;
        }

        public override void Draw(Graphics graphics, Pen pen)
        {
            if (selected)
            {
                graphics.DrawEllipse(new Pen(System.Drawing.Color.Red, 10), boundingRectangle);
            }
            else
            {
                graphics.DrawEllipse(pen, boundingRectangle);
            }
        }

        public override string getInformation()
        {
            return $"{name}  ( X: {boundingRectangle.X} Y: {boundingRectangle.Y} )       Radius: {radius}";
        }

        public override string getName()
        {
            return name;
        }

        public override bool isSelected()
        {
            return selected;
        }

        public override void setSelected(bool state)
        {
            selected = state;
        }
    }
}