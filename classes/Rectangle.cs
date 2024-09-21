using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingApp.classes
{
    public class Rectangle : Shape
    {
        private static int counter = 0;
        private System.Drawing.Rectangle rectangle;
        private string name;
        bool selected = false;
        public Rectangle(int panelWidth, int panelHeight)
        {
            Random rand = new Random();
            int x_cord = rand.Next(panelWidth + 500);   //
            int y_cord = rand.Next(panelHeight + 500); //so it leaves space for the rectangle to be drawn and not go out of the panel

            rectangle = new System.Drawing.Rectangle(x_cord, y_cord, rand.Next(100,220), rand.Next(100, 220));
            name = "Rectangle " + counter;
            counter++;
            
        }

        public override bool ContainsPoint(Point point)
        {
            return rectangle.Contains(point);
        }

        public override void Draw(Graphics graphics, Pen pen)
        {
            if (selected)
            {
                graphics.DrawRectangle(new Pen(Color.Red,10), rectangle);
            }

            else
            {
                Random random = new Random();
                Color color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                graphics.FillRectangle(new SolidBrush(color), rectangle);
            }
        }

        public override string getInformation()
        {
            return  name + "  ( X: " + rectangle.X + " Y: " + rectangle.Y + " )    Width: " + rectangle.Width + " Height: " + rectangle.Height;
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
