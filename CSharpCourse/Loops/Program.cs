using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();
            //WhileLoop();
            //DoWhileLoop();
            //ForeachLoop();

            Console.ReadLine();
        }

        private static void ForeachLoop()
        {
            string[] students = { "Mert", "Çağla", "Ayça" };
            foreach (string student in students)
            {
                Console.WriteLine(student);
            }
        }

        private static void DoWhileLoop()
        {
            int number = 6;
            do
            {
                Console.WriteLine(number);
                number++;
            } while (number <= 5);
        }

        private static void WhileLoop()
        {
            int number = 0;
            while (number <= 100)
            {

                Console.WriteLine(number);
                number++;
            }
            Console.WriteLine("Now number is{0}", number);
        }

        private static void ForLoop()
        {
            for (int i = 100; i >= 0; i -= 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished");
        }
    }
}
