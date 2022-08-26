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
            Exmpl03();
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
    }
}
