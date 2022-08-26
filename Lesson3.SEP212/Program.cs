using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.SEP212
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exmpl03();
            //Exmpl04();
            Exmpl06();
        }

        static void Lesson3()
        {
            Console.WriteLine("Change first number: ");
            string first = Console.ReadLine();

            Console.WriteLine("Change second number: ");
            string second = Console.ReadLine();

            int first_number = 0;
            int second_number = 0;

            foreach (char item in first)
            {
                string num_1 = Convert.ToString(item);
                first_number = Convert.ToInt32(num_1) + first_number;
            };


            Console.WriteLine("----------------------------------");


            foreach (var item in second)
            {
                string num_2 = Convert.ToString(item);
                second_number = Convert.ToInt32(num_2) + second_number;
            };

            int sum = Convert.ToInt32(first_number) + Convert.ToInt32(second_number);


            Console.WriteLine("You are SUM numbers: ");
            Console.WriteLine(sum);
        }

        static void Exmpl02()
        {
            string text = Console.ReadLine();

            string[] textArr = text.Split(' ');

            foreach (var item in textArr)
            {
                int num = 0;

                if (Int32.TryParse(item, out num))
                {
                    Console.WriteLine("This is a number!");
                    Console.WriteLine(num);
                }
                else
                {
                    Console.WriteLine("This is a words!");
                    Console.WriteLine(num);
                }
            }
        }
        static void Exmpl03()
        {
            Console.WriteLine("You are enter a text: ");
            string text = Console.ReadLine();

            string[] textArr = text.Split(' ');

            foreach (var item in textArr)
            {
                bool example = item.Contains("one") || item.Contains("ONE") || item.Contains("One") || item.Contains("oNE") || item.Contains("oNe") || item.Contains("ONe") || item.Contains("OnE");
                if (example)
                {
                    Console.WriteLine("This is a text: one");
                    Console.WriteLine(example);
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
        }
        static void Exmpl04()
        {
            string words = "класс";
            for (int i = 0; i < words.Length - 1; i++)
            {
                if (words[i] == words[i + 1])
                {
                    string letter = words[i].ToString();
                    words = words.Replace(letter, "1");
                }
            }
            Console.WriteLine(words);
        }
        static void Exmpl05()
        {
            int[,] arr = new int[5, 5];
            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr[i, j] = rnd.Next(-100, 100);
                }
            }

            int min = 0;
            int min_i = 0;
            int min_j = 0;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    min = arr[i, j];
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                        min_i = i;
                        min_j = j;
                    }
                }
            }

            int max = 0;
            int max_i = 0;
            int max_j = 0;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    max = arr[i, j];
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                        max_i = i;
                        max_j = j;
                    }
                }
            }

            //if (min_i < max_i && min_j < max_j)
            //{
            //    for (int i = min_i; i < max_i; i++)
            //    {
            //        for (int j = min_j; j < max_j; j++)
            //        {

            //        }
            //    }
            //}
        }

        static void Exmpl06()
        {
            string s = Console.ReadLine();
            string[] textArr = s.Split(' ');
            Console.WriteLine(textArr.Length);
            foreach (var item in textArr)
            {
                Console.WriteLine(item);
            }

        }
    }
}
