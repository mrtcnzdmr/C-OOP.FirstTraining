﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] students = new string[3];
            //students[0] = "Mert";
            //students[1] = "Çağla";
            //students[2] = "Ayca";

            //string[] students2 = new[] { "Mert", "Çağla", "Ayça" };

            //string[] students3 = { "Mert", "Çağla", "Ayça" };



            //foreach (string student in students3)
            //{
            //    Console.WriteLine(student);
            //}



            string[,] regions = new string[5, 3]
            {
                {"İstanbul","İzmit","Balıkesir"},
                {"Ankara","Konya","Kırıkkale"},
                {"Antalya","Adana","Mersin"},
                {"Rize","Trabzon","Samsun"},
                {"İzmir","Muğla","Manisa"}
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("************");
            }



            Console.ReadLine();


        }
    }
}
