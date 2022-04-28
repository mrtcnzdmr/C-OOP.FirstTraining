using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sonuc = Add2();
            //Console.WriteLine(sonuc);
            //int number1 = 20;
            //int number2 = 100;
            //int sonuc1 = Add3(out number1,number2);
            //Console.WriteLine(sonuc1);
            //Console.WriteLine(number1);

            //Console.WriteLine(Multiply(2, 4));
            //Console.WriteLine(Multiply(2, 4, 5));
            int result = Add4(1,2,3,4,5,6,7);
            Console.WriteLine(result);
            
            Console.ReadLine();

        }

        //static int Add2(int number1 = 4,int number2=5)
        //{
        //    int sonuc = number1 + number2;
        //    return sonuc;
        //}
        static int Add3(out int number1, int number2)
        {
            number1 = 30;
            int sonuc1 = number1 + number2;
            return sonuc1;

        }
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }
        static int Add4(int number, params int[] numbers)
        {
            int result = number + numbers.Sum();

            return result;
        }
        

    }
}
