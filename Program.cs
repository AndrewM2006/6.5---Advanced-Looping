using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._5___Advanced_Looping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string menuOption;
                Console.WriteLine("Enter a Number to View the Corresponding Answer");
                Console.WriteLine("Press Q for Quit");
                menuOption = Console.ReadLine();
                if (menuOption == "1")
                {
                    Question1();
                }
                else if (menuOption == "2")
                {
                    Question2();
                }
                else if (menuOption == "3")
                {
                    Question3();
                }
                else if (menuOption == "4")
                {
                    Question4();
                }
                else if (menuOption == "5")
                {
                    Question5();
                }
                else if (menuOption == "6")
                {
                    Question6();
                }
                else if (menuOption == "7")
                {
                    Question7();
                }
                else if (menuOption == "8")
                {
                    Question8();
                }
                else if (menuOption == "9")
                {
                    Question9();
                }
                else if (menuOption == "10")
                {
                    Question10();
                }
                else if (menuOption == "Q" || menuOption == "q")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        }
        public static void Question1()
        {
            for (int i = 0;  i < 10; i++)
            {
                if (i < 9)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.WriteLine("*");
                }
            }
        }
        public static void Question2()
        {
            for (int i = 0; i < 35; i++)
            {
                if (i == 9||i==14||i==34)
                {
                    Console.WriteLine("*");
                }
                else
                {
                    Console.Write("*");
                }
            }
        }
        public static void Question3()
        {
            for (int j=0; j < 10; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (i < 9)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.WriteLine("*");
                    }
                }
            }
        }
        public static void Question4()
        {
            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (i < 4)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.WriteLine("*");
                    }
                }
            }
        }
        public static void Question5()
        {
            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < 20; i++)
                {
                    if (i < 19)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.WriteLine("*");
                    }
                }
            }
        }
        public static void Question6()
        {
            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (i < 9)
                    {
                        Console.Write(i + " ");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
        public static void Question7()
        {
            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (i < 9)
                    {
                        Console.Write(j + " ");
                    }
                    else
                    {
                        Console.WriteLine(j);
                    }
                }
            }
        }
        public static void Question8()
        {
            for (int j = 0; j < 11; j++)
            {
                for (int i = 0; i < j; i++)
                {
                    if (i < j-1)
                    {
                        Console.Write(i + " ");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
        public static void Question9()
        {
            for (int j = 0; j < 11; j++)
            {
                for (int i = 0; i < 10-j; i++)
                {
                    if (i < 9-j)
                    {
                        Console.Write(i + " ");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
        public static void Question10()
        {
            for (int j = 1;j < 10; j++)
            {
                for (int i = 1; i < 10; i++)
                {
                    if (i < 9)
                    {
                        if (i * j < 10)
                        {
                            Console.Write(i * j + "  ");
                        }
                        else
                        {
                            Console.Write(i * j + " ");
                        }
                    }
                    else
                    {
                        Console.WriteLine(i*j);
                    }
                }
            }
        }
    }
}
