using System;

namespace Övningsuppgifter2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool fortsatt = true;
            while (fortsatt)
            {
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("~~        Välj en övning att köra:        ~~");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("");
                Console.WriteLine(" 1: Är talet är negativt eller positivt: ");
                Console.WriteLine(" 2: Vilket av talen är störst: ");
                Console.WriteLine(" 3: Addera eller subtrahera: ");
                Console.WriteLine(" 4: Dividera om inte noll: ");
                Console.WriteLine(" 5: Max av tre tal: ");
                Console.WriteLine(" 6: Lika med 10: ");
                Console.WriteLine(" 7: Temperatur: ");
                Console.WriteLine(" 8: While 0-30: ");
                Console.WriteLine(" 9: While 15 to -5: ");
                Console.WriteLine("10: While Delbart med tre: ");
                Console.WriteLine("11: Do While 0-100: ");
                Console.WriteLine("12: For -5 till 23: ");
                Console.WriteLine("13: For -10 till -40:");
                Console.WriteLine("14: For -30 till -10:");
                Console.WriteLine("15: While Delbart med fem:");
                Console.WriteLine("16: Skriver ut siffran:");
                Console.WriteLine("17: Nästan FizzBuzz:");
                Console.WriteLine("18: Allt utom ett tal:");
                Console.WriteLine("19: Udda tal ner till 7:");
                Console.WriteLine("20: Skriv Sluta:");
                Console.WriteLine("21a1: Rita triangel A1:");
                Console.WriteLine("21a2: Rita triangel A2:");
                Console.WriteLine("21b: Rita triangel B:");
                Console.WriteLine("21c: Rita triangel C:");
                Console.WriteLine("21d1: Rita triangel D1:");
                Console.WriteLine("21d2: Rita triangel D2:");
                Console.WriteLine("21d3: Rita triangel D3:");
                Console.WriteLine("22: Gissa talet:\n");

                Console.Write("Mitt val (Skriv 1-22): ");

                string choice = (Console.ReadLine());
                Console.WriteLine("");

                if (choice == "1")
                    Övningar2.PosNeg();
                else if (choice == "2")
                    Övningar2.BiggestTal();
                else if (choice == "3")
                    Övningar2.AddSub();
                else if (choice == "4")
                    Övningar2.DivOmInteNoll();
                else if (choice == "5")
                    Övningar2.MaxTreTal();
                else if (choice == "6")
                    Övningar2.LikaMedTio();
                else if (choice == "7")
                    Övningar2.Temperatur();
                else if (choice == "8")
                    Övningar2.WhileNollTillTrettio();
                else if (choice == "9")
                    Övningar2.WhileTillMinusFem();
                else if (choice == "10")
                    Övningar2.DelbartMedTre();
                else if (choice == "11")
                    Övningar2.DoWhileNollTillHundra();
                else if (choice == "12")
                    Övningar2.ForMinusFemTillTjugotre();
                else if (choice == "13")
                    Övningar2.ForMinusTioTillMinusFyrtio();
                else if (choice == "14")
                    Övningar2.ForMinusTrettioTillMinusTio();
                else if (choice == "15")
                    Övningar2.WhileDelbartMedTre();
                else if (choice == "16")
                    Övningar2.SkrivSiffran();
                else if (choice == "17")
                    Övningar2.AlmostFizzBuzz();
                else if (choice == "18")
                    Övningar2.AlltUtomEttTal();
                else if (choice == "19")
                    Övningar2.UddaTalTillSju();
                else if (choice == "20")
                    Övningar2.Sluta();
                else if (choice == "21a1")
                    Övningar2.DrawTriA1();
                else if (choice == "21a2")
                    Övningar2.DrawTriA2();
                else if (choice == "21b")
                    Övningar2.DrawTriB();
                else if (choice == "21c")
                    Övningar2.DrawTriC();
                else if (choice == "21d1")
                    Övningar2.DrawTriD1();
                else if (choice == "21d2")
                    Övningar2.DrawTriD2();
                else if (choice == "21d3")
                    Övningar2.DrawTriD3();
                else if (choice == "22")
                    Övningar2.gissaTalet();


                Console.WriteLine("\nVill du köra en till? (j/n)");
                string svar = Console.ReadLine();
                if (svar != "j" && svar != "J")
                    fortsatt = false;
                Console.Clear();
            }
        }
    }
}
