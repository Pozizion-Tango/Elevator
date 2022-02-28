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
                int antaletater = 0;
                Console.WriteLine("Hvor mange etater er der i bygningen?");
                bool pass_check = int.TryParse((Console.ReadLine()), out antaletater);
                int trin = 0;
                if (antaletater > 0)
                {
                    for (; ; )
                    {
                        Console.WriteLine("Hvilken etate vil du til?");
                        int etate = (Convert.ToInt32(Console.ReadLine()));
                        if (etate > trin && etate <= antaletater)
                        {
                            etate = (etate - trin);
                            for (int i = 0; i < etate; i++)
                            {
                                Thread.Sleep(0);
                                trin++;
                                Console.WriteLine(("Du er nu på etate ") + (Convert.ToString(trin)));
                            }
                        }
                        else if (etate < trin && etate > -1)
                        {
                            etate = (trin - etate);
                            for (int i = 0; i < etate; i++)
                            {
                                Thread.Sleep(0);
                                trin--;
                                Console.WriteLine(("Du er nu på etate ") + (Convert.ToString(trin)));
                            }

                        }
                        else
                            Console.WriteLine("Indtast en anden etate");
                        Console.WriteLine(("Du er på etate ") + (Convert.ToString(trin)) + (" ud af ") + (Convert.ToString(antaletater)));
                        if (etate == 69)
                            Console.WriteLine("Nice");
                        if (etate == 420)
                            Console.WriteLine("Smoke it");
                        if (etate == 666)
                            Console.WriteLine("Hail satan");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Indtast et nummer over 0");
                }
            }
        }
    }
}