using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace les06
{
    class MyForm : Form
    {
        public MyForm()
        {
            Text = "My Inherited Form";
            Width *= 2;
            Click += MyClicker;
            Paint += MyPainter;
        }

        private void MyPainter(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.DrawString("Hello, Windows Forms", Font, SystemBrushes.ControlText, 0, 0);
        }

        private void MyClicker(object sender, EventArgs e)
        {
            MessageBox.Show("The button has been clicked!", "Click");
        }
    }
}
