using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please type a number: ");
            var s = Console.ReadLine();
            
            for (int i = 0; i > 5; i++)
            {
                Console.WriteLine(s);
            }
               

            Console.ReadLine();


        }
    }
}
