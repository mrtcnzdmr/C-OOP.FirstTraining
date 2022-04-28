using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.FirstName = "Mert";
            customer.LastName = "Özdemir";
            customer.Id = 1;
            customer.City = "Ankara";

            Customer customer1 = new Customer
            {
                Id = 2,City = "iSTANBUL",FirstName = "Mert", LastName = "Özdemir"
            };

            Console.WriteLine(customer1.FirstName);
            



            Console.ReadLine();
        }
    }
   
    
}