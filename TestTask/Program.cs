using System;

namespace TestTask
{
    class Program
    {
        static void Main()
        {
            Console.Clear();
            Console.WriteLine("Hello! This is test task by Gorbunova Elena.");
            Console.WriteLine("1 - task of racer");
            Console.WriteLine("2 - task of minimal number");
            Console.WriteLine("3 - task of purchase");
            Console.WriteLine("4 - task of squares in the interval");
            Console.WriteLine("5 - task of deposit");
            Console.WriteLine("Enter a number between 1 and 5 and press enter");
            try
            {
                int number = int.Parse(Console.ReadLine());

                switch (number)
                {
                    case 1:
                        TaskOne();
                        break;
                    case 2:
                        TaskTwo();
                        break;
                    case 3:
                        TaskThree();
                        break;
                    case 4:
                        TaskFour();
                        break;
                    case 5:
                        TaskFive();
                        break;
                    default:
                        Console.WriteLine("You do not enter a number between 1 and 5");
                        CloseOrMenu();
                        break;
                }
            }
            catch
            {
                Console.WriteLine("It is not number");
                CloseOrMenu();
            }


            void TaskOne()
            {
                Console.WriteLine("=====Task № 1=====");
                Console.WriteLine("print speed");
                int speed = int.Parse(Console.ReadLine());
                Console.WriteLine("print time (in hour)");
                int time = int.Parse(Console.ReadLine());
                int distance = speed * time;
                double km = distance % 100;
                Console.Write("the car will stop at: ");
                if (km > 0)
                {
                    Console.WriteLine(km + " km");
                }
                else
                {
                    Console.WriteLine(100 - Math.Abs(km) + " km");
                }
                Console.WriteLine("Press enter");
                Console.ReadKey();
                CloseOrMenu();
            }


            void TaskTwo()
            {
                Console.WriteLine("=====Task № 2=====");
                int[] mass = new int[3];
                Console.WriteLine("enter 3 integers");
                for (int j = 0; j < mass.Length; j++)
                {
                    Console.Write("{0} number: ", j + 1);
                    mass[j] = Int32.Parse(Console.ReadLine());
                }
                Array.Sort(mass);
                Console.WriteLine($"min number is: {mass[0]}");
                Console.WriteLine("Press enter");
                Console.ReadKey();
                CloseOrMenu();
            }


            void TaskThree()
            {
                Console.WriteLine("=====Task № 3=====");
                Console.WriteLine("enter rubleCost: ");
                int rubleCost = int.Parse(Console.ReadLine());
                Console.WriteLine("enter pennyCost: ");
                int pennyCost = int.Parse(Console.ReadLine());
                Console.WriteLine("enter rublePayment: ");
                int rublePayment = int.Parse(Console.ReadLine());
                Console.WriteLine("enter pennyPayment: ");
                int pennyPayment = int.Parse(Console.ReadLine());
                double moneyRuble = (rublePayment + pennyPayment / 100.0) - (rubleCost + pennyCost / 100.0);
                if (moneyRuble > 0)
                {
                    Console.WriteLine($"your change: {Math.Truncate(moneyRuble)} ruble and {(Math.Round(moneyRuble, 2) - Math.Truncate(moneyRuble)) * 100} penny.");
                }
                else
                {
                    Console.WriteLine($"need to pay extra: {Math.Abs(Math.Truncate(moneyRuble))} ruble and {Math.Abs((Math.Round(moneyRuble, 2) - Math.Truncate(moneyRuble)) * 100)} penny.");
                }
                Console.WriteLine("Press enter");
                Console.ReadKey();
                CloseOrMenu();
            }


            void TaskFour()
            {
                Console.WriteLine("=====Task № 4=====");
                Console.WriteLine("enter number one");
                int first = int.Parse(Console.ReadLine());
                Console.WriteLine("enter number two");
                int second = int.Parse(Console.ReadLine());
                if (first > second)
                {
                    Console.WriteLine("The second number must not exceed the first!!! Press enter and try again ");
                    Console.ReadKey();

                    TaskFour();
                }
                else
                {
                    double a = Math.Round(Math.Sqrt(first));
                    double b = Math.Round(Math.Sqrt(second));
                    Console.Write("squares on the entered segment: ");
                    do
                    {
                        Console.Write($"{a * a} ");
                        a++;
                    } while (a <= b);
                    Console.WriteLine("Press enter");
                    Console.ReadKey();
                    CloseOrMenu();
                }
            }


            void TaskFive()
            {
                Console.WriteLine("=====Task № 5=====");
                Console.WriteLine("deposit");
                int d = int.Parse(Console.ReadLine());
                Console.WriteLine("percent");
                int p = int.Parse(Console.ReadLine());
                Console.WriteLine("total");
                int total = int.Parse(Console.ReadLine());
                int i = 1;
                double profit;
                do
                {
                    profit = d + (d * p * 0.01) * i;
                    i++;
                } while (profit < total);
                Console.WriteLine($"after {i - 1} years");
                Console.WriteLine("Press enter");
                Console.ReadKey();
                CloseOrMenu();
            }

            void CloseOrMenu()
            {
                Console.Clear();
                Console.WriteLine("Return to menu press 1, To close app press other key and press enter");
                try
                {
                    int press = int.Parse(Console.ReadLine());
                    if (press == 1) { Main(); }
                }
                catch
                {
                    Console.Out.Close();
                }
            }
        }
    }
}
