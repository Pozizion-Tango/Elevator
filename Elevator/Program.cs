using System;
using System.Threading;

namespace Elevator
{

    internal class Program
    {
        
        static void Main(string[] args)
        {
            for (; ; )
            {
                int max_floors = 0;
                Console.WriteLine("How many floors do you want as maximum?");
                bool pass_check = int.TryParse((Console.ReadLine()), out max_floors);
                int floor = 0;
                if (max_floors > 0)
                {
                    for (; ; )
                    {
                        Console.WriteLine("Choose a floor");
                        int choosen_floor = (Convert.ToInt32(Console.ReadLine()));
                        if (choosen_floor > floor && choosen_floor <= max_floors)
                        {
                            choosen_floor = (choosen_floor - floor);
                            for (int i = 0; i < choosen_floor; i++)
                            {
                                Thread.Sleep(200);
                                floor++;
                                if (floor == 1)
                                    Console.WriteLine(("You are now on ") + (Convert.ToString(floor)) + ("'st Floor."));
                                else if (floor == 0)
                                    Console.WriteLine("You are now on Ground Floor.");
                                else
                                    Console.WriteLine(("You are now on ") + (Convert.ToString(floor)) + ("'th Floor."));
                            }
                        }
                        else if (choosen_floor < floor && choosen_floor > -1)
                        {
                            choosen_floor = (floor - choosen_floor);
                            for (int i = 0; i < choosen_floor; i++)
                            {
                                Thread.Sleep(200);
                                floor--;
                                if (floor == 1)
                                    Console.WriteLine(("You are now on ") + (Convert.ToString(floor)) + ("'st Floor."));
                                else if (floor == 0)
                                    Console.WriteLine("You are now on Ground Floor.");
                                else
                                    Console.WriteLine(("You are now on the") + (Convert.ToString(floor)) + ("'th Floor."));
                            }

                        }
                        else
                            Console.WriteLine("Please choose a different floor");
                        Console.WriteLine(("You are on floor ") + (Convert.ToString(floor)) + (" out of ") + (Convert.ToString(max_floors)) + (" floors"));
                        if (choosen_floor == 69)
                            Console.WriteLine("Nice");
                        if (floor == max_floors)
                            Console.WriteLine("You are now on the Roof");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Choose a number above 0");
                }
            }
        }
    }
}