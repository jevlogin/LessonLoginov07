using System;
using System.Windows.Forms;

namespace LessonLoginov07
{
    class Program
    {
        static void Main(string[] args)
        {
            // MessageBox простейший способ вывода информации на экран
            // У метода Show большое количество перезагрузок, с помощью
            // которых можно управлять видом окна сообщения
            MessageBox.Show("Сообщение из Windows Forms!");
            MessageBox.Show("Сообщение из Windows Forms с заголовком", "Заголовок");
            if (MessageBox.Show("Вы уверены, что хотите продолжить обучение?", "Заголовок 2", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Console.WriteLine("Вы нажали 'Да!'");
            }
            else
            {
                Console.WriteLine($"Вы нажали 'Нет'");
            }
            Console.WriteLine("Можно выводить сообщения в консоль");
            Console.WriteLine("Не стоит сейчас слишком задерживаться на изучение MessageBox.Show. У вас еще будет такая возможность");
            
            Console.ReadKey();
        }
    }
}
