using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_modul_03_Bukov
{

    internal class Program
    {
        /*Задание 1
         * Напишите метод, который отображает квадрат из
        некоторого символа. Метод принимает в качестве параметра:
        длину стороны квадрата, символ.*/
        static void Square(char sym, int length)
        {
            // Вывод верхней стороны квадрата
            for (int i = 0; i < length; i++)
            {
                Console.Write(sym);
            }
            Console.WriteLine();

            // Вывод боковых сторон и пустоты внутри квадрата
            for (int i = 0; i < length - 2; i++)
            {
                Console.Write(sym); // Левая сторона
                for (int j = 0; j < length - 2; j++)
                {
                    Console.Write(" "); // Пустота внутри квадрата
                }
                Console.WriteLine(sym); // Правая сторона и переход на новую строку
            }

            // Вывод нижней стороны квадрата
            for (int i = 0; i < length; i++)
            {
                Console.Write(sym);
            }
        }

        /* Задание 2
        Напишите метод, который проверяет является ли
        переданное число «палиндромом». Число передаётся в
        качестве параметра. Если число палиндром нужно вернуть из метода true, иначе false.*/
        static bool IsPalindrome(int num)
        {
            string [] arrNumStr = new string[4];
            for (int i = 0; i < arrNumStr.Length; i++)
            {
                arrNumStr[i] = num.ToString()[i].ToString(); // преобразование числа в строку и разбитие на элементы массива
            }
                if (arrNumStr[0] == arrNumStr[3] && arrNumStr[1] == arrNumStr[2])
                {
                    return true;
                }
                else
                {
                    return false;
                }
        }


        /* Задание 3
         * Напишите метод, фильтрующий массив на основании
        переданных параметров. Метод принимает параметры:
        оригинальный_массив, массив_с_данными_для_фильтрации.
        
        Метод возвращает оригинальный массив без элементов, которые есть в массиве для фильтрации.
        Например:
        1 2 6 -1 88 7 6 — оригинальный массив;
        6 88 7 — массив для фильтрации;
        1 2 -1 — результат работы метода.*/

        static void Main(string[] args)
        {
            //Задание 1
            char symbol = '#';
            int length = 10;

            //Square(symbol, length);

            // задание 2
            int num = 1221;
            Console.WriteLine(IsPalindrome(num));
            int num1 = 1512;
            Console.WriteLine(IsPalindrome(num1));
        }
        


    }

}
