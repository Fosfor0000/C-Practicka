using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practika_1
{
    internal class Task4:Task
    {
        public override void Execute()
        {
            int size = 13;
            int[] arrA = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Введіть значення для елементу {i + 1}: ");
                while (true)
                {
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out arrA[i]))
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("Некоректне значення. Спробуйте ще раз: ");
                    }
                }
            }
            List<int> arrB = new List<int>();
            Console.WriteLine("Введіть M:");
            int M = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < size; ++i)
            {
                if (Math.Abs(arrA[i]) > M)
                {
                    arrB.Add(arrA[i]);
                }
            }
            Console.WriteLine("Масив А: ");
            for (int i = 0; i < size; ++i)
            {
                Console.Write(arrA[i] + "  ");
            }
            Console.WriteLine("\n" + "Масив B: ");
            for (int i = 0; i < arrB.Count; ++i)
            {
                Console.Write(arrB[i] + "  ");
            }
            Console.WriteLine("\n" + "Число М: " + M);
        }
    }
}
