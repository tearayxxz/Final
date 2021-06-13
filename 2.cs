using System;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, temp;
            int n = int.Parse(Console.ReadLine());
            int[] num= new int[n];
            for (i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                num[i] = a;
            }
            Array.Sort(num);
            Console.Write("Banking’s Sort ");
            foreach (int ivalue in num)
            {
                Console.Write("{0} ",ivalue);
            }
            //-----------------------------------------
            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (num[i] > num[j])
                    {
                        temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;
                    }
                }
            }
            Console.WriteLine("");
            Console.Write("Phun’s Sort ");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0} ", num[i]);
            }
            //-----------------------------------------
            for (i = 0; i < num.Length; i++)
            {
                for (j = i + 1; j < num.Length; j++)
                {
                    if (num[i] > num[j])
                    {
                        temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;
                    }
                }
            }
            Console.WriteLine("");
            Console.Write("Nhong’s Sort ");
            for (i = 0; i < num.Length; i++)
            {
                Console.Write("{0} ", num[i]);
            }
            //--------------------------------------
             Array.Reverse(num);
             Array.Reverse(num);
            Console.WriteLine("");
            Console.Write("Toddy’s Sort ");
            foreach (int ivalue in num)
            {
                Console.Write("{0} ", ivalue);
            }
        }
    }
}
