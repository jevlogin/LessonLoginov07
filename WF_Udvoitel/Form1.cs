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

namespace WF_Udvoitel
{
    public partial class Form1 : Form
    {
        public static Random rnd = new Random();
        public int NumberRandom = rnd.Next(20, 100);

        public int CountCommand = 0;
        public int TempNumber = 0;
        const string lblCountCommandDefault = "Количество отданных команд: ";


        public Form1()
        {
            Form form = new Form();
            form.Text = "Игра Удвоитель";
            
            MessageBox.Show($"Вы должны набрать число {NumberRandom} за минимальное кол-во ходов.");

            InitializeComponent();

            lblCountCommand.Text = lblCountCommandDefault + CountCommand;
        }

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            TempNumber = (int.Parse(lblNumber.Text) - 1);
            Debug.WriteLine(TempNumber);
            CountCoomandMethod();
        }

        private void CountCoomandMethod()
        {
            lblCountCommand.Text = lblCountCommandDefault + (++CountCommand);
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            TempNumber = (int.Parse(lblNumber.Text) / 2);
            Debug.WriteLine(TempNumber);
            CountCoomandMethod();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "1";
            CountCoomandMethod();
        }

        private void MenuFileNewGame_Click(object sender, EventArgs e)
        {
            CountCommand = 0;
            lblCountCommand.Text = lblCountCommandDefault + CountCommand;
            lblNumber.Text = "0";
            NumberRandom = rnd.Next(20, 100);
            MessageBox.Show($"Вы должны набрать число {NumberRandom} за минимальное кол-во ходов.");

        }

        private void MenuFileClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelLastCommand_Click(object sender, EventArgs e)
        {
            lblNumber.Text = TempNumber.ToString();
        }
    }
}
