using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace les03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем объект класса Form
            Form form = new Form();
            // Обращаемся к некоторым свойствам графического окна
            form.Text = "Это простое графическое окно";
            form.Width = 1000;
            // Показываем этот объект
            form.Show();
            // Если не сделать паузу, то консольное окно и форма закроются

            Thread.Sleep(3000);
        }
    }
}
