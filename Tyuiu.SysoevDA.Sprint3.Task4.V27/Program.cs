using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.SysoevDA.Sprint3.Task4.V27.Lib;

namespace Tyuiu.SysoevDA.Sprint3.Task4.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Сысоев Д.А | ПКТБ-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Сысоев Данил Алексеевич | ПКТБ-23-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение     *");
            Console.WriteLine("* функции y=x/(cos(x)+sin(x)). При х = 0 пропустить значение. Полученные  *");
            Console.WriteLine("* значения суммировать.                                                   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = -5;
            int y = 5;
            Console.WriteLine("Старт шага = " + x);
            Console.WriteLine("Конец шага = " + y);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Результат = {ds.Calculate(x, y)}");
            Console.ReadKey();
        }
    }
}
