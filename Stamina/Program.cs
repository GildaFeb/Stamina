using System;

namespace Stamina
{
    class Program
    {
        static void Begin()
        {
            Console.WriteLine("============================================");
            Console.WriteLine("1 = run -5 stamina per second");
            Console.WriteLine("2 = walk -3 stamina per second");
            Console.WriteLine("3 = rest +5 stamina per second");
            Console.WriteLine("4. Exit");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("============================================");
            Console.WriteLine("             STAMINA MINA E E                 ");
            while (true)
            {
                try
                {

                    Begin();
                    String choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            Console.WriteLine("YOU HAVE " + "50" + " / 50 STAMINA");
                            Run();
                            break;
                        case "2":
                            Console.WriteLine("YOU HAVE " + "50" + " / 50 STAMINA");
                            Walk();
                            break;
                        case "3":
                            Rest();
                            break;
                        case "4":
                            Console.WriteLine("\nExitting...");
                            System.Environment.Exit(1);
                            break;
                        default:
                            Console.WriteLine("============================================");
                            Console.Error.WriteLine("OUT OF THE CHOICE. TRY AGAIN");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("============================================");
                    Console.Error.WriteLine("  Out of the choice. Try again");
                }
            }
        }
        static void Run()
        {
            Console.WriteLine("============================================");
            Console.WriteLine("\nRunning..");
            for (int i = 0; i < 5; i++)
            {
                int[] arr = new int[] { 45, 40, 35, 30, 25 };
                Console.WriteLine("\t -5 You have " + arr[i] + "/50..");
            }
            for (; ; )
            {
                try
                {
                    Console.WriteLine("============================================");
                    Console.WriteLine("=========YOUR STAMINA IS AT HALF============");
                    Begin();
                    Console.WriteLine("\nEnter next move:");

                    int choice2 = int.Parse(Console.ReadLine());
                    if (choice2 == 1)
                    {
                        Run2();
                    }
                    else if (choice2 == 2)
                    {
                        Walk2();
                    }
                    else if (choice2 == 3)
                    {
                        Rest();
                    }
                    else if (choice2 == 4)
                    {
                        Console.WriteLine("\nExitting...");
                        System.Environment.Exit(1);
                    }
                }
                catch
                {
                    Console.WriteLine("\nOUT OF THE CHOICES. TRY AGAIN.");
                }
            }
        }
        static void Walk()
        {

            Console.WriteLine("============================================");
            Console.WriteLine("\nWalking..");
            for (int i = 0; i < 8; i++)
            {
                int[] arr = new int[] { 47, 44, 41, 38, 35, 32, 29, 26 };
                Console.WriteLine("\t -3 You have " + arr[i] + "/50..");
            }
            for (; ; )
            {
                try
                {
                    Console.WriteLine("============================================");
                    Console.WriteLine("=========YOUR STAMINA IS AT HALF============");
                    Begin();
                    Console.WriteLine("\nEnter next move:");
                    int choice2 = int.Parse(Console.ReadLine());

                    if (choice2 == 1)
                    {
                        Run3();

                    }
                    else if (choice2 == 2)
                    {
                        Walk3();
                    }
                    else if (choice2 == 3)
                    {
                        Rest();
                    }
                    else if (choice2 == 4)
                    {
                        Console.WriteLine("\nExitting...");
                        System.Environment.Exit(1);
                    }
                }
                catch
                {
                    Console.WriteLine("\nOUT OF THE CHOICES. TRY AGAIN.");
                }
            }

        }

        static void Rest()
        {
            Console.WriteLine("============================================");
            Console.WriteLine("     YOUR STAMINA IS NOW FULL: 50/50");
            Main(null);
        }
        static void Run2()
        {

            Console.WriteLine("============================================");
            Console.WriteLine("\nRunning..");
            for (int i = 0; i < 5; i++)
            {
                int[] arr = new int[] { 20, 15, 10, 5, 0 };
                Console.WriteLine("\t -5 You have " + arr[i] + "/50");
            }
            Console.WriteLine("============================================");
            Console.WriteLine("     YOU CAN NO LONGER PERFORM ACTIVITY");
            Console.WriteLine("============================================");

            for (; ; )
            {
                try
                {
                    Console.WriteLine("\nPRESS 1 TO REST");
                    int press = int.Parse(Console.ReadLine());
                    if (press == 1)
                    {
                        for (int i = 0; i < 11; i++)
                        {
                            int[] arr = new int[] { 0, 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
                            Console.WriteLine("\t +5 You have " + arr[i] + "/50..");

                        }
                        Main(null);
                    }
                }
                catch
                {
                    Console.WriteLine("============================================");
                    Console.WriteLine("\nPress 1 only. Try again.");
                }
            }
        }
        static void Walk2()
        {

            Console.WriteLine("============================================");
            Console.WriteLine("\nWalking..");
            for (int i = 0; i < 8; i++)
            {
                int[] arr = new int[] { 22, 19, 16, 13, 10, 7, 4, 1 };
                Console.WriteLine("\t-2 You have " + arr[i] + "/50..");
            }
            Console.WriteLine("============================================");
            Console.WriteLine("     YOU CAN NO LONGER PERFORM ACTIVITY");
            Console.WriteLine("============================================");

            for (; ; )
            {
                try
                {
                    Console.WriteLine("\nPRESS 1 TO REST");
                    int press = int.Parse(Console.ReadLine());
                    if (press == 1)
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            int[] arr = new int[] { 6, 11, 16, 21, 26, 31, 36, 41, 46, 50 };
                            Console.WriteLine("\t +5 You have " + arr[i] + "/50..");

                        }
                        Main(null);
                    }
                }
                catch
                {
                    Console.WriteLine("============================================");
                    Console.WriteLine("\nPress 1 only. Try again.");
                }
            }
        }
        static void Run3()
        {

            Console.WriteLine("============================================");
            Console.WriteLine("\nRunning..");
            for (int i = 0; i < 5; i++)
            {
                int[] arr = new int[] { 21, 16, 11, 6, 1 };
                Console.WriteLine("\t -5 You have " + arr[i] + "/50");
            }
            Console.WriteLine("============================================");
            Console.WriteLine("    YOU CAN NO LONGER PERFORM ACTIVITY");
            Console.WriteLine("============================================");

            for (; ; )
            {
                try
                {
                    Console.WriteLine("\nPRESS 1 TO REST");
                    int press = int.Parse(Console.ReadLine());
                    if (press == 1)
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            int[] arr = new int[] { 6, 11, 16, 21, 26, 31, 36, 41, 46, 50 };
                            Console.WriteLine("\t +5 You have " + arr[i] + "/50..");

                        }
                        Main(null);
                    }
                }
                catch
                {
                    Console.WriteLine("============================================");
                    Console.WriteLine("\nPress 1 only. Try again.");
                }
            }
        }
        static void Walk3()
        {

            Console.WriteLine("============================================");
            Console.WriteLine("\nWalking..");
            for (int i = 0; i < 8; i++)
            {
                int[] arr = new int[] { 23, 20, 17, 14, 11, 8, 5, 2 };
                Console.WriteLine("\t-2 You have " + arr[i] + "/50..");
            }
            Console.WriteLine("============================================");
            Console.WriteLine("    YOU CAN NO LONGER PERFORM ACTIVITY");
            Console.WriteLine("============================================");
            for (; ; )
            {
                try
                {
                    Console.WriteLine("\nPRESS 1 TO REST");
                    int press = int.Parse(Console.ReadLine());
                    if (press == 1)
                    {
                        for (int i = 0; i < 11; i++)
                        {
                            int[] arr = new int[] { 2, 7, 12, 17, 22, 27, 32, 37, 42, 47, 50 };
                            Console.WriteLine("\t +5 You have " + arr[i] + "/50..");

                        }
                        Main(null);
                    }
                }
                catch
                {
                    Console.WriteLine("============================================");
                    Console.WriteLine("\nPress 1 only. Try again.");
                }
            }
        }
    }
}
