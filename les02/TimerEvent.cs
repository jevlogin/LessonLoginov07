﻿using System;
using System.Timers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace les02
{
    class TimerEvent
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer();
            // Здесь мы используем готовый делегат из пространства имен System.Timers
            // Можно оставить просто название метода. Здесь представлен такой сложный механизм,
            // чтобы дать понять, что для назначения события используется делегат, который,
            // в свою очередь, предназначен, чтобы содержать в себе ссылку на метод
            timer.Elapsed += new ElapsedEventHandler(TimerEventHandler);
            timer.Interval = 1000;
            timer.Enabled = true;
            Console.ReadKey();

        }

        // Все события в Windows Forms строятся по этому шаблону
        // Сначала идет информация о том, кто создал событие, а потом передается информация о событии
        // С помощью объекта sender мы можем узнать, кто сгенерировал событие
        // А с помощью объекта e - информацию о событии

        private static void TimerEventHandler(object sender, ElapsedEventArgs e)
        {
            // Выведем информацию о том, что сгенерировало событие
            Console.WriteLine($"{sender.ToString()}");  //  можно упростить интерполяцию

            //  и информацию, переданную событию
            //Console.WriteLine($"{e.SignalTime.ToString()}");
            Console.WriteLine($"{e.SignalTime}");   //  можно упростить интерполяцию


        }
    }
}
