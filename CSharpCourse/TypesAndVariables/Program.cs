using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            //Console.WriteLine("Hello World");
            
            decimal number6 = 10.4m;
            double number5 = 13.3;
            string city = "Ankara";
            char character = 'A';//ASCII leri tutar
            bool condition = false;//şart
            byte number4 = 255;//- tarafı yoktur 0 ile 255 arasında veri tutar
            short number3 = -32768;//+karşılığıda var
            int number1 = 2147483647;//int sınırları - karşılığı var
            long number2 = -9223372036854775808;// long sınırları + karşılığı var 
            var number7 = 10;
            //number7 = 'A';
            
            Console.WriteLine("Number1 is {0} ",number1);
            Console.WriteLine("Number2 is {0}",number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Character is {0}", (int)character);//Karakterin ASCII karşılığını verir
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine((int)Days.Friday);//enum sabitleri 0 dan başlatıcak şekilde alır istersek değiştirebiliriz
            Console.WriteLine("Number7 is {0}", number7);
            Console.ReadLine();
        }
    }
    enum Days 
    {
        Monday=1,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
    }
}
