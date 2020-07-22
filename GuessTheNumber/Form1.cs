using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheNumber
{
    public partial class Form1 : Form
    {
        public static Random rnd = new Random();
        public int CurrentValue;
        public int CurrentAttemp = 0;
        public Form1()
        {
            InitializeComponent();

            Debug.WriteLine(CurrentValue);  //TODO НЕ ЗАБЫТЬ УБРАТЬ!

            lblAttempt.Text += ++CurrentAttemp;
        }

        private void btnMenuItem1Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMenuItem1NewGame_Click(object sender, EventArgs e)
        {
            CurrentValue = rnd.Next(1, 2);
            MessageBox.Show("Добро пожаловать в игру!\n\nПравила простые: УГАДАЙ ЧИСЛО, которое загадал компьютер.");
        }
    }
}
