using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace les04
{
    class Program
    {
        static void Main(string[] args)
        {
            Form form1 = new Form();
            Form form2 = new Form();
            form1.Text = "Эта форма запущена с использованием метода Run класса Application";
            form2.Text = "Это форма для демонстрации возможности создавать несколько форм";
            form2.Show();
            Application.Run(form1);
            MessageBox.Show("Application.Run() вернул " + "управление в метод Main(). До Свидания", "Приложение \"Двеформы\"");
        }
    }
}
