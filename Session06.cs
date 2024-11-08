
namespace LeVuNgocGiang_Exercise
{
    internal class Session06
    {
        public static void Main(string[] args)
        {
            Ex01();

            //int[] abc;
           // abc = new int[10];

            int[] abc = new int[10];
        }

        private static void Ex01()
        {
            Console.Write("Enter the quantity of item:");
            int n = int .Parse(Console.ReadLine());
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
            for(int i = 0;i < a.Length;i++)
            {
                a[i] += value;
            }
            Console.WriteLine();
        }

        static void Sum(int[] a)
        {
            int sum = 0;
            for (int i = 0;i <a.Length;i++)
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

        }

        static void EnterRandomItem(int[] a)
        {
            Random randomitem = new Random();
            for (int i = 0; i < a.Length;i++)
            {
                a[i] = randomitem.Next(100);
            }
        }

        static void Average1(int[] a)
        {

        }
    }
}
