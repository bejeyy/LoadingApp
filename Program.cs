﻿namespace ConsoleApp1

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pin = 1111;
            int userData = 0;
            double balance = 0.0;

            Console.Write("Enter PIN: ");
            int userPin = Convert.ToInt16(Console.ReadLine());

            if (userPin == pin)
            {
                while (true)
                {
                    Console.WriteLine("\nWelcome");
                    Console.WriteLine($"BAL: {balance}");
                    Console.WriteLine("\n1) Add Currency \n2) CASHOUT \n3) Buy DATA \n4) Balance \n0) EXIT");

                    Console.Write("\nEnter Action: ");
                    int userAction = Convert.ToInt16(Console.ReadLine());

                    if (userAction == 1)
                    {
                        Console.WriteLine("\nADD CURRENCY");
                        Console.Write("\nAdd Amount: ");
                        double addAmount = Convert.ToDouble(Console.ReadLine());

                        balance += addAmount;
                        Console.WriteLine($"Your new Balance is: {balance} \n-------------------------------------------");

                    }
                    else if (userAction == 2)
                    {
                        Console.WriteLine("\nCASH OUT");
                        Console.Write("\nRemove Amount: ");
                        double removeAmount = Convert.ToDouble(Console.ReadLine());

                        if (balance >= removeAmount)
                        {
                            balance -= removeAmount;
                            Console.WriteLine($"Your new Balance is: {balance} \n-------------------------------------------");
                        }
                        else
                        {
                            Console.WriteLine("ERROR, Insufficient Balance \n-------------------------------------------");
                        }

                    }
                    else if (userAction == 3)
                    {
                        Console.WriteLine("\nBUY DATA\n");

                        string[] loads = new string[] { "1) GigaChad30 (500mb)", "2) GigaChad49 (1000mb)", "3) GigaChad99 (3000mb)", "4) GigaChad149 (6000mb)", "5) GigaChad199 (12000mb)", "0) Return" };

                        foreach (var load in loads)
                        {
                            Console.WriteLine(load);
                        }
                        Console.Write("\nEnter Number: ");
                        int userNumber = Convert.ToInt16(Console.ReadLine());

                        switch (userNumber)
                        {
                            case 1:
                                if (balance >= 30)
                                {
                                    Console.WriteLine("\n500mb Data");
                                    Console.WriteLine("Purchase Complete. \n-------------------------------------------");
                                    balance -= 30;
                                    userData += 500;

                                }
                                else
                                {
                                    Console.WriteLine("Insufficient Balance. \n-------------------------------------------");
                                }
                                break;
                            case 2:
                                if (balance >= 49)
                                {
                                    Console.WriteLine("\n1000mb Data");
                                    Console.WriteLine("Purchase Complete. \n-------------------------------------------");
                                    balance -= 50;
                                    userData += 1000;

                                }
                                else
                                {
                                    Console.WriteLine("Insufficient Balance. \n-------------------------------------------");
                                }
                                break;
                            case 3:
                                if (balance >= 99)
                                {
                                    Console.WriteLine("\n3000mb Data");
                                    Console.WriteLine("Purchase Complete. \n-------------------------------------------");
                                    balance -= 100;
                                    userData += 3000;

                                }
                                else
                                {
                                    Console.WriteLine("Insufficient Balance. \n-------------------------------------------");
                                }
                                break;
                            case 4:
                                if (balance >= 149)
                                {
                                    Console.WriteLine("\n6000mb Data");
                                    Console.WriteLine("Purchase Complete. \n-------------------------------------------");
                                    balance -= 149;
                                    userData += 6000;
                                }
                                else
                                {
                                    Console.WriteLine("Insufficient Balance. \n-------------------------------------------");
                                }
                                break;
                            case 5:
                                if (balance >= 199)
                                {
                                    Console.WriteLine("\n12000mb Data");
                                    Console.WriteLine("Purchase Complete. \n-------------------------------------------");
                                    balance -= 199;
                                    userData += 12000;
                                }
                                else
                                {
                                    Console.WriteLine("Insufficient Balance. \n-------------------------------------------");
                                }
                                break;
                            case 0:
                                break;
                            default:
                                Console.WriteLine("Invalid Action. \n-------------------------------------------");

                                break;
                        }

                    }
                    else if (userAction == 4)
                    {
                        Console.WriteLine("-------------------------------------------");
                        Console.WriteLine("\nYour Balance:");
                        Console.WriteLine($"\nBalance: P{balance}");
                        Console.WriteLine($"Data: {userData}mb \n-------------------------------------------");

                    }
                    else if (userAction == 0)
                    {
                        break;

                    }
                    else
                    {
                        Console.WriteLine("Invalid Action");

                    }
                }

            }
            else
            {
                Console.WriteLine("INCORRECT PIN.");

            }
        }
    }
}
