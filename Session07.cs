using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace LeVuNgocGiang_Exercise
{
    internal class Session07
    {
        static void Main1(string[] args)
        {
            Question01();
        }
        
        static void Question01()
        {
            Console.WriteLine("How many rows and columns?");
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int[,] a = new int[rows, cols];
            EnterandPrintMatrix(a);

            Console.WriteLine("Enter the index of row u wanna print:");
            int indexrow = int.Parse(Console.ReadLine());
            Irows(a, indexrow);

            MaxValue(a);
        }

        /// <summary>
        /// to create and print matrix
        /// </summary>
        /// <param name="a"></param>
        static void EnterandPrintMatrix(int[,] a)
        {
            Random random = new Random();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = random.Next(100);
                    Console.Write(a[i,j] + " ");
                }
                Console.WriteLine();
            }
            
        }


        /// <summary>
        /// Print the i row
        /// </summary>
        /// <param name="a"></param>
        /// <param name="indexrow"></param>
        static void Irows(int[,] a, int indexrow)
        {
            if (indexrow < 0 || indexrow >= a.GetLength(0)-1)
            {
                Console.WriteLine($"Please re-enter the index from 0 to {a.GetLength(0) - 1}");
                return;
            }
            
            for (int j=0; j < a.GetLength(1); j++)
            {
                Console.WriteLine(a[indexrow,j] + " ");

            }

           
        }


        /// <summary>
        /// Find the max value
        /// </summary>
        /// <param name="a"></param>
        static void MaxValue(int[,] a)
        {
            int max = 0;
            foreach (int num in a)
            {
                if (num > max)
                {
                    max = num;
                }
                Console.WriteLine($"Maximum value of the matrix is {max}");
            }
        }

        static void MinValueInRow( int[,] a)
        {
            int min = 0;
            
        }



        static void Question02()
        {

        }
    }
}
