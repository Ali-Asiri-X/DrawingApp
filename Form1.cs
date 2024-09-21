using DrawingApp.classes;
using System.Collections;
using System.Reflection.Metadata;

namespace DrawingApp
{
    public partial class Form1 : Form
    {
        private Shape currentSelectedShape;
        public Form1()
        {
            InitializeComponent();
        }

        //create a list of shapes to be drawn
        List<Shape> shapes = new List<Shape>();
        private void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {
            Pen GreenPen = new Pen(Color.Green, 10);
            //draw all the shapes in the list using the draw method of each shape
            foreach (Shape s in shapes)
            {
                s.Draw(e.Graphics, GreenPen);
            }
        }


        private void LineButton_Click(object sender, EventArgs e)
        {
            Line line = new Line(DrawingPanel.Width, DrawingPanel.Height);
            shapes.Add(line);
            DrawingPanel.Invalidate();

            listBox1.Items.Add(line.getName());
            InfoListBox.Items.Add(line.getInformation());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RectangleButton_Click(object sender, EventArgs e)
        {
            classes.Rectangle rect = new classes.Rectangle(DrawingPanel.Width, DrawingPanel.Height);
            shapes.Add(rect);
            DrawingPanel.Invalidate();

            listBox1.Items.Add(rect.getName());
            InfoListBox.Items.Add(rect.getInformation());
        }

        private void TriangleButton_Click(object sender, EventArgs e)
        {
            Triangle triangle = new Triangle(DrawingPanel.Width, DrawingPanel.Height);
            shapes.Add(triangle);
            DrawingPanel.Invalidate();

            listBox1.Items.Add(triangle.getName());
            InfoListBox.Items.Add(triangle.getInformation());
        }

        private void SquareButton_Click(object sender, EventArgs e)
        {
            Square square = new Square(DrawingPanel.Width, DrawingPanel.Height);
            shapes.Add(square);
            DrawingPanel.Invalidate();

            listBox1.Items.Add(square.getName());
            InfoListBox.Items.Add(square.getInformation());
        }

        private void CircleButton_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle(DrawingPanel.Width, DrawingPanel.Height);
            shapes.Add(circle);
            DrawingPanel.Invalidate();

            listBox1.Items.Add(circle.getName());
            InfoListBox.Items.Add(circle.getInformation());
        }





        private void DrawingPanel_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (currentSelectedShape != null)
            {
                currentSelectedShape.setSelected(false);
                currentSelectedShape = null;
            }
            foreach (Shape s in shapes)
            {
                if (s.ContainsPoint(e.Location))
                {
                    // Deselect the current selected shape
                    currentSelectedShape = s; // Update the selected shape
                    currentSelectedShape.setSelected(true); // Select the new shape

                    break;
                }
            }
            DrawingPanel.Invalidate(); // Trigger repaint
            listBox1.SelectedIndex = shapes.IndexOf(currentSelectedShape);
        }



        private void listBox1_Click(object sender, EventArgs e)
        {
            if (currentSelectedShape != null)
            {
                currentSelectedShape.setSelected(false);
                DrawingPanel.Invalidate();
            }
            int selectedIndex = listBox1.SelectedIndex;
            currentSelectedShape = shapes[selectedIndex];
            currentSelectedShape.setSelected(true);
            DrawingPanel.Invalidate();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int newPosition = e.NewValue;
        }
    }

}
