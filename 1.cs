using System;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int[,] num = new int[3,3];
            Console.WriteLine("Input 0-9");
            num [0,0] = int.Parse(Console.ReadLine());
            num [0,1] = int.Parse(Console.ReadLine());
            num [0,2] = int.Parse(Console.ReadLine());
            num [1,0] = int.Parse(Console.ReadLine());
            num [1,1] = int.Parse(Console.ReadLine());
            num [1,2] = int.Parse(Console.ReadLine());
            num[2, 0] = int.Parse(Console.ReadLine());
            num[2, 1] = int.Parse(Console.ReadLine());
            num[2, 2] = int.Parse(Console.ReadLine());
            if (
                num[0, 0] >= 0 && num[0, 0] < 10 &&
                num[0, 1] >= 0 && num[0, 1] < 10 &&
                num[0, 2] >= 0 && num[0, 2] < 10 &&
                num[1, 0] >= 0 && num[1, 0] < 10 &&
                num[1, 1] >= 0 && num[1, 1] < 10 &&
                num[1, 2] >= 0 && num[1, 2] < 10 &&
                num[2, 0] >= 0 && num[2, 0] < 10 &&
                num[2, 1] >= 0 && num[2, 1] < 10 &&
                num[2, 2] >= 0 && num[2, 2] < 10
                )
            {
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                for (i = 0; i < 3; i++)
                {
                    for (j = 0; j < 3; j++)
                    {
                        Console.Write(num[i, j]);
                        Console.Write(" ");
                    }
                    Console.WriteLine("");
                }
                Console.WriteLine("");
                if (0 == num[0, 0] || 0 == num[0, 1] || 0 == num[0, 2]
                    || 0 == num[1, 0] || 0 == num[1, 1] || 0 == num[1, 2] ||
                    0 == num[2, 0] || 0 == num[2, 1] || 0 == num[2, 2])
                {
                    if (num[0, 0] != 0)
                    {
                        Console.Write(num[0, 0]);
                        Console.Write(" ");
                    }
                    else if (num[0, 0] == 0)
                    {
                        Console.Write(num[0, 0] + a);
                        Console.Write(" ");
                    }
                    //-------------------
                    if (num[0, 1] != 0)
                    {
                        Console.Write(num[0, 1]);
                        Console.Write(" ");
                    }
                    else if (num[0, 1] == 0)
                    {
                        Console.Write(num[0, 1] + a);
                        Console.Write(" ");
                    }
                    //-------------------
                    if (num[0, 2] != 0)
                    {
                        Console.Write(num[0, 2]);
                        Console.Write(" ");
                        Console.WriteLine("");
                    }
                    else if (num[0, 2] == 0)
                    {
                        Console.Write(num[0, 2] + a);
                        Console.Write(" ");
                        Console.WriteLine("");
                    }
                    //-------------------
                    if (num[1, 0] != 0)
                    {
                        Console.Write(num[1, 0]);
                        Console.Write(" ");
                    }
                    else if (num[1, 0] == 0)
                    {
                        Console.Write(num[1, 0] + a);
                        Console.Write(" ");
                    }
                    //-------------------
                    if (num[1, 1] != 0)
                    {
                        Console.Write(num[1, 1]);
                        Console.Write(" ");
                    }
                    else if (num[1, 1] == 0)
                    {
                        Console.Write(num[1, 1] + a);
                        Console.Write(" ");
                    }
                    //-------------------
                    if (num[1, 2] != 0)
                    {
                        Console.Write(num[1, 2]);
                        Console.Write(" ");
                        Console.WriteLine("");
                    }
                    else if (num[1, 2] == 0)
                    {
                        Console.Write(num[1, 2] + a);
                        Console.Write(" ");
                        Console.WriteLine("");
                    }
                    //-------------------
                    if (num[2, 0] != 0)
                    {
                        Console.Write(num[2, 0]);
                        Console.Write(" ");
                    }
                    else if (num[2, 0] == 0)
                    {
                        Console.Write(num[2, 0] + a);
                        Console.Write(" ");
                    }
                    //-------------------
                    if (num[2, 1] != 0)
                    {
                        Console.Write(num[2, 1]);
                        Console.Write(" ");
                    }
                    else if (num[2, 1] == 0)
                    {
                        Console.Write(num[2, 1] + a);
                        Console.Write(" ");
                    }
                    //-------------------
                    if (num[2, 2] != 0)
                    {
                        Console.Write(num[2, 2]);
                        Console.Write(" ");
                        Console.WriteLine("");
                    }
                    else if (num[2, 2] == 0)
                    {
                        Console.Write(num[2, 2] + a);
                        Console.Write(" ");
                        Console.WriteLine("");
                    }
                }
                Console.WriteLine("");
                if (a == num[0, 0] || a == num[0, 1] || a == num[0, 2]
                    || a == num[1, 0] || a == num[1, 1] || a == num[1, 2] ||
                    a == num[2, 0] || a == num[2, 1] || a == num[2, 2])
                {
                    Console.WriteLine("The number is available");
                }
            }
            else
            {
                Console.WriteLine("Invild");
            }
        }
    }
}
