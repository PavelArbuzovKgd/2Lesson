using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Lesson
{
    class MainClass
    {
        static void Main()
        {

            Task1 task1 = new Task1();//перевод в двоичную систему
            Task2 task2 = new Task2();
            Task3 task3 = new Task3();

            #region Задание 1

            /*
          1. Реализовать функцию перевода из десятичной системы в двоичную, используя рекурсию.
          */
            //Console.WriteLine("Введите число для перевода в двоичную систему:");
            //Console.WriteLine(task1.Convert10to2(int.Parse(Console.ReadLine()), ""));

            #endregion

            #region Задание 2

            /*
            2.Реализовать функцию возведения числа a в степень b:
            a.без рекурсии;
            b.рекурсивно;
            c. * рекурсивно, используя свойство четности степени.
            */
            //Console.WriteLine("Введите число :");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите степень :");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine(task2.PowIter(a,b));
            //Console.WriteLine(task2.PowRec(a,b));
            //Console.WriteLine(Math.Pow(a, b));

            #endregion

            #region Задание 3
            /*
         3. Исполнитель Калькулятор преобразует целое число, записанное на экране. У исполнителя две команды, каждой команде присвоен номер:
              Прибавь 1
              Умножь на 2
            Первая команда увеличивает число на экране на 1, вторая увеличивает это число в 2 раза. Сколько существует программ, которые число 3 преобразуют в число 20?
               а) с использованием массива;
               б) с использованием рекурсии.
          */

            Console.WriteLine(task3.CalcRec(3, 20));//рекурсивный

            #endregion
            Console.ReadKey();
        }
    }
}
