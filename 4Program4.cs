using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//4.Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив. 
namespace _4_Homework4
{
    class Program
    {
        class LP
        {
            string[] ss;

            public LP(string filename)
            {
                if (File.Exists(filename))
                {
                    ss = File.ReadAllLines(filename);//cчитываем все строки из файла
                }
                else Console.WriteLine("Error load file");

                foreach (string s in ss)
                {
                    Console.WriteLine(s);
                }
            }

            bool LP_authorization(string s1, string s2)
            {
                return (s1 == ss[0] && s2 == ss[1]) ? true : false;
            }

            public void LP_check()
            {
                int i = 0;
                string s1, s2;

                do
                {
                    Console.Clear();

                    Console.Write("Введите логин:");
                    s1 = Console.ReadLine();

                    Console.Write("Введите пароль:");
                    s2 = Console.ReadLine();

                    if (LP_authorization(s1, s2))
                    {
                        Console.WriteLine("\nПравильно.");
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        switch (i)
                        {
                            case 0:
                                Console.WriteLine("\nЛогин или пароль неверен. Введите логин и пароль еще раз. Осталось 2 попытки");
                                Console.ReadKey();
                                break;

                            case 1:
                                Console.WriteLine("\nЛогин или пароль неверен. Введите логин и пароль еще раз. Осталось 1 попытка");
                                Console.ReadKey();
                                break;

                            default:
                                Console.WriteLine("\nПревышен лимит попыток!");
                                Console.ReadKey();
                                break;
                        }
                    }

                    i++;

                } while (i <= 2);
            }
        }
        static void Main(string[] args)
        {
            LP lp = new LP("C:\\Users\\Alik\\source\\repos\\4_Homework\\4_Homework4\\pass.txt");
            lp.LP_check();
        }
    }
}
