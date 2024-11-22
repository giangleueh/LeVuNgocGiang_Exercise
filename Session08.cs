using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeVuNgocGiang_Exercise
{
    internal class Session08
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string s = Console.ReadLine();
            Console.WriteLine("You entered: " + s);
            Console.Write("The length of this string:");
            Console.WriteLine(Length(s));
            IndividualChar(s);
            Console.WriteLine("The string in reverse order: ");
            ReverseOrder(s);
            Console.Write("Number of words: ");
            Console.WriteLine(NumberOfWords(s));
        }
            


            //to find the length of a string without using a library function
            static int Length(string s)
            {
                int count = 0;
                foreach (char c in s)
                {
                    count++;
                }
                return count;
            }


            // to separate individual characters from a string
            static void IndividualChar(string s)
            {
                foreach (char c in s)
                {
                    Console.WriteLine(c + " ");
                }
            }

            //to print individual characters of the string in reverse order.
            static void ReverseOrder(string s)
            {
          
                for (int i = s.Length-1; i >=0; i--)
                {
                   
                    Console.WriteLine(s[i] + " ");

                }
            }

        //to count the total number of words in a string
        static int NumberOfWords(string s)
        {
            int count = 0;
            int c = ' ';

            for (int i = 0; i < s.Length; i++)
            {
                if ((s[i] == c) && (s[i + 1] != c))
                {
                    count++;
                }
            }
            return count+1;
        }


        //to compare two strings without using a string library functions
        static void CompareTwoStrings(string s1, string s2)
        {
            int l1= s1.Length, l2= s2.Length;

        }



        //to count the number of alphabets, digits and special characters in a string
        static void NumberOfAlphabet(string s)
        {
            int alpha = 0;
            int digit = 0;
            foreach (char c in s)
            {
                if (((c > 'a') && (c < 'z')) || ((c > 'A') && (c < 'Z')))
                {
                    alpha++;
                }
                else if ((c >= '0') && (c<= '9'))
                {
                    digit ++;
                }
                else
                {

                }
            }
            
        }
    }
}
