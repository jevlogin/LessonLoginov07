using System;
using System.Drawing;
using System.Windows.Forms;

namespace les06
{
    class Program
    {
        static void Main(string[] args)
        {
            Form form = new Form();
            form.Text = "Событие Paint";

            // У формы есть событие Paint,
            // в System.Windows.Form описан делегат PaintEventHandler,
            // который описывает сигнатуру методов, которые можно подключать на событие
            //Создаем делегат и указываем, что он указывает на метод MyPaintHandler

            form.Paint += new PaintEventHandler(MyPaintHandler);
            Application.Run(form);
        }

        private static void MyPaintHandler(object sender, PaintEventArgs e)
        {
            // Получаем ссылку на класс Graphics, в котором содержатся поля и методы для рисования на форме
            Graphics graphics = e.Graphics;
            // Очищаем форму, закрашивая ее цветом
            graphics.Clear(Color.Chocolate);
            // Будем в заголовке окна менять время, чтобы лучше понять, когда же срабатывает это событие
            (sender as Form).Text = DateTime.Now.ToLongDateString();
            // А также посмотрим, что же вызывает это событие
            Console.WriteLine(sender.ToString());
        }
    }
}
