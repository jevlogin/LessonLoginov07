using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Udvoitel
{
    public partial class Form1 : Form
    {
        public int CountCommand = 0;
        const string lblCountCommandDefault = "Количество отданных команд: ";
        public Form1()
        {
            InitializeComponent();
            lblCountCommand.Text = lblCountCommandDefault + (CountCommand);
        }

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            CountCoomandMethod();
        }

        private void CountCoomandMethod()
        {
            lblCountCommand.Text = lblCountCommandDefault + (++CountCommand);
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            CountCoomandMethod();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "1";
            CountCoomandMethod();
        }

        private void игратьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вам необходимо получить число 69 за минимальное кол-во ходов.");
        }
    }
}
