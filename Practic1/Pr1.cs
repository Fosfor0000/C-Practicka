using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practika_1
{
    
    public class Practic1
    {
        static void Main()
        {

            List<Task> tasks = new List<Task>
        {
            new Task1(),
            new Task2(),
            new Task3(),
            new Task4()
        };


            foreach (var task in tasks)
            {
                task.Execute();
            }
        }

    }
        
    
    
}
