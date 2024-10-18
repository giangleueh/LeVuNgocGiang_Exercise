using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeVuNgocGiang_Exercise1
{
    internal class Session03
    {
        public static void Main(string[] args)
        {
            Question_01();
            //Question_02();


            Console.WriteLine("Press any key to stop");
            Console.ReadKey();
        }

        /// <summary>
        /// to Add/Sum two numbers
        /// </summary>
        public static void Question_01()

        {
            Console.WriteLine("Enter celsius degree: ");
            int c = int.Parse(Console.ReadLine());

            int k = c + 273;
            int f = c * (18 / 10) + 32;

            Console.WriteLine($"Kelvin = {k} Fahrenheit = {f}");


        }


    }
}
