using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1. Дан  целочисленный  массив  из 20 элементов.  Элементы  массива  могут принимать  целые  значения  от –10 000 до 10 000 включительно.
//Заполнить случайными числами. Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3.
//В данной задаче под парой подразумевается два подряд идущих элемента массива. Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 4. 
namespace HW
{
    class Array  //конструктор получает min, max, n - количество значений в массиве
    {
        int min, max;
        int[] arr;
        string row = "";
        int count;
        Random rnd = new Random();

        public Array(int min, int max, int n)
        {
            this.min = min;
            this.max = max;
            arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(this.min, this.max);
                row = row + string.Format("{0,8}", arr[i].ToString());
            }

            Counting();
        }

        void Counting() // метод подсчета пар
        {
            count = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] % 3 == 0 || arr[i + 1] % 3 == 0)
                {
                    count++;
                }
            }
        }

        public string Row  // cвойство для вывода массива чисел
        {
            get { return row; }
        }
        public int Count // cвойство для вывода количества пар
        {
            get { return count; }
        }
    }
    class Program
    {
        static void Main()
        {
            Array array = new Array(-10, 10, 20);
            Console.WriteLine("Массив с числами:\n{0}", array.Row);
            Console.WriteLine("\nКоличество пар, делящихся на 3: {0}", array.Count);

            Console.ReadKey();
        }
    }   
}
