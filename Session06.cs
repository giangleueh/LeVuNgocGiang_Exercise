
namespace LeVuNgocGiang_Exercise
{
    internal class Session06
    {
        public static void Main(string[] args)
        {
            //Ex01();
            Question00();

            //int[] abc;
            // abc = new int[10];

            //int[] abc = new int[10];
        }

        private static void Ex01()
        {
            Console.Write("Enter the quantity of item:");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            EnterArray(a);
            PrintArray(a);
            Add(a, 2);
            PrintArray(a);
            Sum(a);
        }

        static void EnterArray(int[] a)
        {

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"Enter the #{i} item: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        static void PrintArray(int[] a)
        {
            foreach (int item in a)
            {
                Console.Write(item + " ");

            }
            Console.WriteLine();
        }

        static void Add(int[] a, int value)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] += value;
            }
            Console.WriteLine();
        }

        static void Sum(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            Console.WriteLine($"Sum of all items: {sum}");
        }

        static void Average(int[] a)
        {

        }



        /// <summary>
        /// Create a random integer values array, then create functions that:
        /// </summary>
        private static void Question00()
        {
            Console.Write("Enter the quantity of item:");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            EnterRandomItem(a);
            //Average1(a);
            //CheckedSpecificValue(a);

            //FindIndex(a);
            //MaxandMin(a);
            ReverseArray(a);
        }

            static void EnterRandomItem(int[] a)
            {
                Random randomitem = new Random();
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = randomitem.Next(100);
                }

                foreach (int rditem in a)
                {
                    Console.Write(rditem + " ");
                }
                Console.WriteLine();
            }

            /// <summary>
            /// to calculate the average value of array elements
            /// </summary>
            /// <param name="a"></param>
            static void Average1(int[] a)
            {
                int sum = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    sum += a[i];
                }
                int average = sum / a.Length;
                Console.WriteLine($"Average of the array is {average}");
            }


        /// <summary>
        /// to test if an array contains a specific value
        /// </summary>
        /// <param name="a"></param>
        /// <param name="val"></param>
        /// <returns></returns>

        static bool IsSpecificValue(int[] a, int val)
            {
                foreach (int rditem in a)
                {
                    if (rditem != val) return false;

                }
                return true;

            }

            static void CheckedSpecificValue (int[] a)
            {
                Console.WriteLine("Enter the value u wanna check:");
                int val = int.Parse(Console.ReadLine());
            if (IsSpecificValue(a, val))
            {
                Console.WriteLine($"This array contains {val}");

            }
            else
            {
                Console.WriteLine($"This array doesn't contain {val}");
            }
            }


        ///<summary>
        /// to find the index of an array element.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        static int BinarySearch (int [] a, int key)
        {
            int min = 0;
            int max = a.Length - 1;
            while (min <= max)
            {
                int mid=(min+max)/2;
                if (key == a[mid])
                {
                    return mid;
                }
                else if (key < a[mid])
                {
                    max = mid - 1;

                }
                else 
                {
                    min = mid + 1;

                }
            }
            return -1;

        }

        static void BubbleSort(int [] a)
        {
            int n = a.Length -1;
            for (int i = 0; i < n -1; i++)
            {
                for (int j = 0; j < n - i -1; j++)
                {
                    if (a[j] > a[j+1])
                    {
                        int temp = a[j];
                        a[j] = a[j+1];
                        a[j+1] = temp;
                    }
                }
            }

            Console.WriteLine($"The sorted array is");
            foreach (int newrditem in a)
            {
                Console.Write(newrditem + " ");
            }
            Console.WriteLine();
        }

        static void FindIndex(int[]a)
        {
            BubbleSort(a);
            Console.WriteLine("Enter the search key:");
            int key = int.Parse(Console.ReadLine());
            Console.WriteLine($"Index need to find is {BinarySearch(a, key)}");
        }


        /// <summary>
        /// to remove a specific element from an array
        /// </summary>
        /// <param name="a"></param>
        static void RemoveSpecificElement(int[]a)
        {
            Console.WriteLine("Enter the value u wanna remove:");
            int value = int.Parse(Console.ReadLine());

        }

        static void FindValueToRemove(int[] a, int value)
        {
            for (int i = 0;i < a.Length;i++)
            {
                if (a[i] == value)
                {
                    
                }
            }
        }

        /// <summary>
        ///  to find the maximum and minimum value of an array
        /// </summary>
        /// <param name="a"></param>
        static void MaxandMin(int[] a)
        {
            int max = a[0];
            int min = a[0];
            foreach (int num in a)
            {
                if (num > max)
                {
                   max = num;
                }
                if (num< min)
                {
                    min = num;
                }
            }
            Console.WriteLine($"Maximum number of the array is {max}");
            Console.WriteLine($"Minimum number of the array is {min}");
        }

        /// <summary>
        /// to reverse an array of integer values
        /// </summary>
        /// <param name="a"></param>
        static void ReverseArray(int[] a)
        {
           Array.Reverse(a);
            foreach (int num in a)
            {
                Console.Write(num + " ");
            }
        }
    }
}
