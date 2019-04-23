using System;
using System.Drawing;
using System.Windows.Forms;

namespace ISDWeek3
{
    public partial class Paint : Form
    {
        Color CurrentColor = Color.Black; //Default color
        Point CurrentPoint; //Current Position
        Point PrevPoint; //Previous Position
        bool isPressed;
        Graphics brush;

        private void paintSimple()
        {
            Pen pens = new Pen(CurrentColor);//taking current color for brush
            brush.DrawLine(pens, PrevPoint, CurrentPoint);
        }

        public Paint()
        {
            InitializeComponent();
            brush = CanvasPanel.CreateGraphics();//allow program for painting
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            CanvasPanel.Refresh();//clear panel 
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            DialogResult SelectedColor = ColorDialog.ShowDialog();//show users panel of colors
            if (SelectedColor == DialogResult.OK)
                CurrentColor = ColorDialog.Color;//setting color
        }

        private void CanvasPanel_MouseDown(object sender, MouseEventArgs e)
        {
            isPressed = true;
            CurrentPoint = e.Location;// setting current location of brush
        }

        private void CanvasPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isPressed)
            {
                PrevPoint = CurrentPoint;//swap location
                CurrentPoint = e.Location;//read new location
                paintSimple();//call function
            }
        }

        private void CanvasPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isPressed = false;//check if mouse is pressed
        }

       
    }
}
