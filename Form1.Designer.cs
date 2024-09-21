using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DrawingApp
{
        partial class Form1
        {
            /// <summary>
            ///  Required designer variable.
            /// </summary>
            private System.ComponentModel.IContainer components = null;

            /// <summary>
            ///  Clean up any resources being used.
            /// </summary>
            /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            infoModeButton = new Button();
            listBox1 = new ListBox();
            DrawingPanel = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            LineButton = new Button();
            SqaureButton = new Button();
            RectangleButton = new Button();
            CircleButton = new Button();
            TriangleButton = new Button();
            tabControl1 = new TabControl();
            DrawingMode = new TabPage();
            panel1 = new Panel();
            label2 = new Label();
            InfoMode = new TabPage();
            label1 = new Label();
            InfoListBox = new ListBox();
            flowLayoutPanel1.SuspendLayout();
            tabControl1.SuspendLayout();
            DrawingMode.SuspendLayout();
            panel1.SuspendLayout();
            InfoMode.SuspendLayout();
            SuspendLayout();
            // 
            // infoModeButton
            // 
            infoModeButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            infoModeButton.Location = new Point(96, 45);
            infoModeButton.Name = "infoModeButton";
            infoModeButton.Size = new Size(208, 55);
            infoModeButton.TabIndex = 1;
            infoModeButton.Text = "Info mode";
            infoModeButton.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            listBox1.BackColor = Color.FromArgb(245, 235, 224);
            listBox1.Cursor = Cursors.Hand;
            listBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 32;
            listBox1.Location = new Point(1559, 159);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(240, 772);
            listBox1.TabIndex = 4;
            listBox1.Click += listBox1_Click;
            // 
            // DrawingPanel
            // 
            DrawingPanel.AutoScroll = true;
            DrawingPanel.AutoScrollMinSize = new Size(500, 500);
            DrawingPanel.AutoSize = true;
            DrawingPanel.BackColor = Color.FromArgb(237, 237, 233);
            DrawingPanel.BorderStyle = BorderStyle.FixedSingle;
            DrawingPanel.Location = new Point(0, -35);
            DrawingPanel.Margin = new Padding(6);
            DrawingPanel.Name = "DrawingPanel";
            DrawingPanel.Size = new Size(10, 10);
            DrawingPanel.TabIndex = 0;
            DrawingPanel.Paint += DrawingPanel_Paint;
            DrawingPanel.MouseDown += DrawingPanel_MouseDown_1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.BackColor = Color.FromArgb(245, 235, 224);
            flowLayoutPanel1.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel1.Controls.Add(LineButton);
            flowLayoutPanel1.Controls.Add(SqaureButton);
            flowLayoutPanel1.Controls.Add(RectangleButton);
            flowLayoutPanel1.Controls.Add(CircleButton);
            flowLayoutPanel1.Controls.Add(TriangleButton);
            flowLayoutPanel1.Cursor = Cursors.Hand;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(98, 132);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(174, 876);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.WrapContents = false;
            // 
            // LineButton
            // 
            LineButton.BackColor = Color.FromArgb(227, 213, 202);
            LineButton.BackgroundImage = Properties.Resources.Line;
            LineButton.BackgroundImageLayout = ImageLayout.Stretch;
            LineButton.FlatAppearance.BorderColor = Color.FromArgb(214, 204, 194);
            LineButton.FlatAppearance.BorderSize = 5;
            LineButton.FlatStyle = FlatStyle.Flat;
            LineButton.ForeColor = SystemColors.ControlText;
            LineButton.Location = new Point(25, 25);
            LineButton.Margin = new Padding(25);
            LineButton.Name = "LineButton";
            LineButton.Size = new Size(120, 120);
            LineButton.TabIndex = 0;
            LineButton.UseVisualStyleBackColor = false;
            LineButton.Click += LineButton_Click;
            // 
            // SqaureButton
            // 
            SqaureButton.BackColor = Color.FromArgb(227, 213, 202);
            SqaureButton.BackgroundImage = Properties.Resources.square;
            SqaureButton.BackgroundImageLayout = ImageLayout.Stretch;
            SqaureButton.FlatAppearance.BorderColor = Color.FromArgb(214, 204, 194);
            SqaureButton.FlatAppearance.BorderSize = 5;
            SqaureButton.FlatStyle = FlatStyle.Flat;
            SqaureButton.Location = new Point(25, 195);
            SqaureButton.Margin = new Padding(25);
            SqaureButton.Name = "SqaureButton";
            SqaureButton.Size = new Size(120, 120);
            SqaureButton.TabIndex = 1;
            SqaureButton.UseVisualStyleBackColor = false;
            SqaureButton.Click += SquareButton_Click;
            // 
            // RectangleButton
            // 
            RectangleButton.BackColor = Color.FromArgb(227, 213, 202);
            RectangleButton.BackgroundImage = Properties.Resources.Rectangle;
            RectangleButton.BackgroundImageLayout = ImageLayout.Stretch;
            RectangleButton.FlatAppearance.BorderColor = Color.FromArgb(214, 204, 194);
            RectangleButton.FlatAppearance.BorderSize = 5;
            RectangleButton.FlatStyle = FlatStyle.Flat;
            RectangleButton.Location = new Point(25, 365);
            RectangleButton.Margin = new Padding(25);
            RectangleButton.Name = "RectangleButton";
            RectangleButton.Size = new Size(120, 120);
            RectangleButton.TabIndex = 2;
            RectangleButton.UseVisualStyleBackColor = false;
            RectangleButton.Click += RectangleButton_Click;
            // 
            // CircleButton
            // 
            CircleButton.BackColor = Color.FromArgb(227, 213, 202);
            CircleButton.BackgroundImage = Properties.Resources.circle;
            CircleButton.BackgroundImageLayout = ImageLayout.Stretch;
            CircleButton.FlatAppearance.BorderColor = Color.FromArgb(214, 204, 194);
            CircleButton.FlatAppearance.BorderSize = 5;
            CircleButton.FlatStyle = FlatStyle.Flat;
            CircleButton.Location = new Point(25, 535);
            CircleButton.Margin = new Padding(25);
            CircleButton.Name = "CircleButton";
            CircleButton.Padding = new Padding(15);
            CircleButton.Size = new Size(120, 120);
            CircleButton.TabIndex = 3;
            CircleButton.UseVisualStyleBackColor = false;
            CircleButton.Click += CircleButton_Click;
            // 
            // TriangleButton
            // 
            TriangleButton.BackColor = Color.FromArgb(227, 213, 202);
            TriangleButton.BackgroundImage = Properties.Resources.triangle;
            TriangleButton.BackgroundImageLayout = ImageLayout.Stretch;
            TriangleButton.FlatAppearance.BorderColor = Color.FromArgb(214, 204, 194);
            TriangleButton.FlatAppearance.BorderSize = 5;
            TriangleButton.FlatStyle = FlatStyle.Flat;
            TriangleButton.Location = new Point(25, 705);
            TriangleButton.Margin = new Padding(25);
            TriangleButton.Name = "TriangleButton";
            TriangleButton.Size = new Size(120, 120);
            TriangleButton.TabIndex = 4;
            TriangleButton.UseVisualStyleBackColor = false;
            TriangleButton.Click += TriangleButton_Click;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(DrawingMode);
            tabControl1.Controls.Add(InfoMode);
            tabControl1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(2132, 1217);
            tabControl1.TabIndex = 5;
            // 
            // DrawingMode
            // 
            DrawingMode.AutoScroll = true;
            DrawingMode.AutoScrollMargin = new Size(500, 500);
            DrawingMode.AutoScrollMinSize = new Size(500, 500);
            DrawingMode.BackColor = Color.FromArgb(214, 204, 194);
            DrawingMode.Controls.Add(panel1);
            DrawingMode.Controls.Add(label2);
            DrawingMode.Controls.Add(listBox1);
            DrawingMode.Controls.Add(flowLayoutPanel1);
            DrawingMode.Location = new Point(8, 64);
            DrawingMode.Name = "DrawingMode";
            DrawingMode.Padding = new Padding(3);
            DrawingMode.Size = new Size(2116, 1145);
            DrawingMode.TabIndex = 0;
            DrawingMode.Text = "Drawing Mode";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.AutoScrollMargin = new Size(500, 500);
            panel1.AutoScrollMinSize = new Size(500, 500);
            panel1.AutoSize = true;
            panel1.Controls.Add(DrawingPanel);
            panel1.Location = new Point(455, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 1000);
            panel1.TabIndex = 6;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(1604, 109);
            label2.Name = "label2";
            label2.Size = new Size(136, 47);
            label2.TabIndex = 5;
            label2.Text = "Shapes";
            // 
            // InfoMode
            // 
            InfoMode.BackColor = Color.FromArgb(214, 204, 194);
            InfoMode.Controls.Add(label1);
            InfoMode.Controls.Add(InfoListBox);
            InfoMode.Location = new Point(8, 64);
            InfoMode.Name = "InfoMode";
            InfoMode.Padding = new Padding(3);
            InfoMode.Size = new Size(2116, 1145);
            InfoMode.TabIndex = 1;
            InfoMode.Text = "Info Mode";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(40, 58);
            label1.Name = "label1";
            label1.Size = new Size(231, 51);
            label1.TabIndex = 1;
            label1.Text = "Shapes Info";
            // 
            // InfoListBox
            // 
            InfoListBox.BackColor = Color.FromArgb(245, 235, 224);
            InfoListBox.FormattingEnabled = true;
            InfoListBox.ItemHeight = 50;
            InfoListBox.Location = new Point(40, 112);
            InfoListBox.Name = "InfoListBox";
            InfoListBox.Size = new Size(916, 704);
            InfoListBox.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(229, 229, 229);
            ClientSize = new Size(2132, 1217);
            Controls.Add(tabControl1);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Drawing App";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            flowLayoutPanel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            DrawingMode.ResumeLayout(false);
            DrawingMode.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            InfoMode.ResumeLayout(false);
            InfoMode.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button infoModeButton;
        private ListBox listBox1;
        private Panel DrawingPanel;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button LineButton;
        private Button SqaureButton;
        private Button RectangleButton;
        private Button CircleButton;
        private Button TriangleButton;
        private TabControl tabControl1;
        private TabPage DrawingMode;
        private TabPage InfoMode;
        private Label label1;
        private ListBox InfoListBox;
        private Label label2;
        private Panel panel1;
    }
    }
