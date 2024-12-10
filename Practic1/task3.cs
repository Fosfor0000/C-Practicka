using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practika_1
{
    internal class Task3:Task
    {
        public override void Execute()
        {
            int size = 13;
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Введіть значення для елементу {i + 1}: ");
                while (true)
                {
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out arr[i]))
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("Некоректне значення. Спробуйте ще раз: ");
                    }
                }
            }

            int max = arr[0];
            int min = arr[0];

            foreach (int value in arr)
            {
                if (max < value)
                {
                    max = value;
                }
                if (min > value)
                {
                    min = value;
                }
            }

            Console.WriteLine("\nНайбільше значення: " + max);
            Console.WriteLine("Найменше значення: " + min);
        }
    }
}
