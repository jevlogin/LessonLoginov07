﻿using System;
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
        public const string tempAttemp = "Попытка № ";

        public Form1()
        {
            InitializeComponent();

            CurrentValue = rnd.Next(1, 101);

            Debug.WriteLine(CurrentValue);  //TODO НЕ ЗАБЫТЬ УБРАТЬ!

            lblAttempt.Text = tempAttemp + ++CurrentAttemp;
        }

        private void btnMenuItem1Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMenuItem1NewGame_Click(object sender, EventArgs e)
        {
            CurrentValue = rnd.Next(1, 101);
            Debug.WriteLine(CurrentValue);  //TODO НЕ ЗАБЫТЬ УБРАТЬ!

            CurrentAttemp = 1;
            lblAttempt.Text = tempAttemp + CurrentAttemp;
            MessageBox.Show("Добро пожаловать в игру!\n\nПравила простые: УГАДАЙ ЧИСЛО, которое загадал компьютер.");
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            int tempUserAnswer = int.Parse(txtBoxInputUserNumber.Text);
            if (tempUserAnswer.Equals(CurrentValue))
            {
                MessageBox.Show($"Поздравляю! Вы победили! Вы сделали это всего с {CurrentAttemp} попыток.");
            }
            else
            {
                if (tempUserAnswer > CurrentValue)
                {
                    MessageBox.Show($"Ваше значение выше задуманного!");
                }
                else if (tempUserAnswer < CurrentValue)
                {
                    MessageBox.Show($"Ваше значение меньше задуманного!");
                }
                MessageBox.Show($"С каждым бывает! Попробуйте еще!");
                lblAttempt.Text = tempAttemp + ++CurrentAttemp;
            }
        }
    }
}
