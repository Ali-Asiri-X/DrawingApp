using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingApp.classes

    {
        public class Square : Shape
        {
            private static int counter = 0;
            private System.Drawing.Rectangle boundingRectangle;
            private string name;
            private bool selected = false;

            public Square(int panelWidth, int panelHeight)
            {
                Random rand = new Random();

                // Generate a random position for the square
                int x = rand.Next(panelWidth - 220);
                int y = rand.Next(panelHeight - 220);

                // Generate a random side length for the square
                int sideLength = rand.Next(100, 220);

                boundingRectangle = new System.Drawing.Rectangle(x, y, sideLength, sideLength);
                name = "Square " + counter;
                counter++;
            }

        public override bool ContainsPoint(Point point)
        {
            return boundingRectangle.Contains(point);
        }

        public override void Draw(Graphics graphics, Pen pen)
            {
                if(selected)
            {
                    graphics.DrawRectangle(new Pen(Color.Red, 10), boundingRectangle);
                }
                else
            {
                    graphics.DrawRectangle(pen, boundingRectangle);
                }
            }

            public override string getInformation()
            {
                return $"{name}  ( X: {boundingRectangle.X} Y: {boundingRectangle.Y} )     Side Length: {boundingRectangle.Width}";
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


