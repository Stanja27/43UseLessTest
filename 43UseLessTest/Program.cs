using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43UseLessTest
{
    class Program
    {
        static void Main(string[] args)
        {
            UseLessClass useLess = new UseLessClass();
            Random rng = new Random();

            for (int i = 0; i < 30; i++)
            {
               Console.WriteLine(useLess.GetOutput(rng.Next(100)));
            }
            Console.ReadKey();
        }
    }
}
