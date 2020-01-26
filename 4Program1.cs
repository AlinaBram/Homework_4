using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1. Дан  целочисленный  массив  из 20 элементов.  Элементы  массива  могут принимать  целые  значения  от –10 000 до 10 000 включительно.
//Заполнить случайными числами. Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3.
//В данной задаче под парой подразумевается два подряд идущих элемента массива. Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 4. 
//2.Реализуйте задачу 1 в виде статического класса StaticClass;
namespace _4_Homework
{
    public static class Array
    {
        static Array()
        {
            int count = 0;
            int min = -10;
            int max = 10;
            int n = 20;
            int[] arr;
            arr = new int[n];
            string row = "";
            Random rnd = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(min, max);
                row = row + string.Format("{0,8}", arr[i].ToString());
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] % 3 == 0 || arr[i + 1] % 3 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine("Массив с числами:\n{0}", row);
            Console.WriteLine("\nКоличество пар, делящихся на 3: {0}", count);
        }
        public static string Conclusion { get; }
    }

    class MyArray
    {
        static void Main()
        {
            Console.WriteLine(Array.Conclusion);
            Console.ReadKey();
        }
    }
}
