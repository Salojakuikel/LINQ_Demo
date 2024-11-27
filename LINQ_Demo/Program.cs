using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Demo
{
    class program
    {
        static void Main(string[] args)
        {
            int[] age = { 10, 12, 15, 4,10,12,18,20,22};
            var a = from i in age where i >15 select i;

            foreach(int item in a)
            {
              Console.WriteLine(item);  
            }

            Console.ReadLine();
        }
    }
}

