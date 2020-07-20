using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace les05
{
    class Program
    {
        static void Main(string[] args)
        {
            Form form = new Form();
            form.Text = "Событие Click";
            // У формы есть событие Click
            // в System.Windows.Form описан делегат EventHandler(Обработчик события),
            // который описывает сигнатуру методов, которые можно подключать на событие
            // Можно записать просто Form_Click
            form.Click += new EventHandler(Form_Click);
            Application.Run(form);

        }

        private static void Form_Click(object sender, EventArgs e)
        {
            //  Посмотрим что же вызвало событие
            Console.WriteLine(sender.ToString());
            MessageBox.Show("Щелкнули по форме!", "Щелк!");
        }
    }
}
