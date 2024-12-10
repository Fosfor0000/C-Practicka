using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practika_1
{
    public class Task1:Task
    {
        public override void Execute()
        {

            
            int[] numbers = {30,-100, 15 };
            


            foreach (int i in numbers)
            {
                if (i >= 1 && i <= 13)
                    Console.WriteLine(i);

            }
        }
    }
}
