using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMenuItem1Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMenuItem1NewGame_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Добро пожаловать в игру!\n\nПравила простые: УГАДАЙ ЧИСЛО, которое загадал компьютер.");
        }
    }
}
