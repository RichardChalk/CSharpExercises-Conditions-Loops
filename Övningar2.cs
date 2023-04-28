using System;
using System.Collections.Generic;
using System.Text;

namespace Övningsuppgifter2
{
    class Övningar2
    {
        // CONDITIONS CONDITIONS CONDITIONS CONDITIONS CONDITIONS CONDITIONS
        // CONDITIONS CONDITIONS CONDITIONS CONDITIONS CONDITIONS CONDITIONS
        // CONDITIONS CONDITIONS CONDITIONS CONDITIONS CONDITIONS CONDITIONS
        // CONDITIONS CONDITIONS CONDITIONS CONDITIONS CONDITIONS CONDITIONS
        public static void PosNeg()
        {
            // 1. Skriv ett program som ber användaren om ett tal och sedan kontrollerar 
            // om talet är negativt eller positivt.

            Console.Write("Ge mig ett tal, positivt eller negativt? ");
            float num1 = Convert.ToSingle(Console.ReadLine());

            if (num1 < 0)
                Console.WriteLine($"{num1} är ett negativt tal");
            else if (num1 > 0)
                Console.WriteLine($"{num1} är ett positivt tal");
            else
                Console.WriteLine($"{num1} är varken ett positivt eller ett negativt tal");
        }
        public static void BiggestTal()
        {
            // 2.   Skriv ett program som ber användaren mata in två tal och sedan skriva ut 
            // vilket av talen som är störst. Om båda talen är lika skrivs ”:(” ut på skärmen istället.

            Console.Write("Ge mig ett tal, positivt eller negativt: ");
            float num1 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Ge mig ett till tal, positivt eller negativt: ");
            float num2 = Convert.ToSingle(Console.ReadLine());

            float result = Math.Max(num1, num2);

            if (num1 == num2)
            {
                Console.WriteLine(":(");
            }
            else
            {
                Console.WriteLine($"{result} är det största talet");
            }
        }
        public static void AddSub()
        {
            // 3.Skriv ett program som frågar användaren om den vill addera eller subtrahera, 
            // och sedan utför den efterfrågade operationen på de två tal användaren matat in. 
            // Resultatet ska presenteras i konsolfönstret.
            Console.Write("Ge mig ett tal, positivt eller negativt: ");
            float num1 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Ge mig ett till tal, positivt eller negativt: ");
            float num2 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Vill du addera(+) eller subtrahera(-) dessa tal? (+/-)");
            char op = Convert.ToChar(Console.ReadLine());

            if (op == '+')
            {
                Console.WriteLine($"Om vi adderar dina tal får vi: {num1} + {num2} = {num1 + num2}");
            }
            else if (op == '-')
            {
                Console.WriteLine($"Om vi subtraherar dina tal får vi: {num1} - {num2} = {num1 - num2}");
            }
            else
                Console.WriteLine("Du skrev inte ett giltigt operator");
        }
        public static void DivOmInteNoll()
        {
            // 4.Skriv ett program som ber användaren om ett tal. Om det inte är noll, 
            // be om ett andra tal.Om inte heller det är noll, dividera det första talet med det andra.

            Console.Write("Ge mig ett tal, positivt eller negativt: ");
            float num1 = Convert.ToSingle(Console.ReadLine());

            if (num1 != 0)
            {
                Console.Write("Ge mig ett till tal, positivt eller negativt: ");
                float num2 = Convert.ToSingle(Console.ReadLine());

                if (num1 != 0 && num2 != 0) // Behövs num1 != 0?
                {
                    Console.WriteLine($"Här är dina siffror dividerade: {num1} / {num2} = {num1 / num2}");
                }
                else
                    Console.WriteLine("Vi får inte dividera med Noll tyvärr!");
            }
            else
                Console.WriteLine("Vi får inte dividera med Noll tyvärr!");
        }
        public static void MaxTreTal()
        {
            // 5. Skriv ett program som tar tre tal från användaren och skriver ut det största.
            // Om alla tal är lika skrivs ”:O” ut på skärmen istället.

            Console.Write("Ge mig ett tal, positivt eller negativt: ");
            float num1 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Ge mig ett till tal, positivt eller negativt: ");
            float num2 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Ge mig ett tredje tal, positivt eller negativt: ");
            float num3 = Convert.ToSingle(Console.ReadLine());

            if ((num1 + num2 + num3) / 3 == num1)
            {
                Console.WriteLine("Alla 3 nummer var lika! :0");
            }
            else
            {
                float result = Math.Max(num1, Math.Max(num2, num3));
                Console.WriteLine($"Det största talet av de 3 tal du matade in är: {result}");
            }
        }
        public static void LikaMedTio()
        {
            // 6. Skriv ett program som ber användaren mata in ett tal och skriver ut till konsolfönstret 
            // om talet är större, mindre, eller lika med 10.

            Console.Write("Ge mig en siffra: ");
            float num1 = Convert.ToSingle(Console.ReadLine());
            if (num1 < 10)
            {
                Console.WriteLine($"Siffran {num1} är mindre än 10!");
            }
            else if (num1 > 10)
            {
                Console.WriteLine($"Siffran {num1} är större än 10!");
            }
            else
                Console.WriteLine($"Siffran är 10!");
        }
        public static void Temperatur()
        {
            // 7.Skriv ett program som ber användare mata in en temperatur som sedan ger tillbaka ett 
            // svar i konsolfönstret beroende på vad temperaturen är.Programmet skriver ut:

            Console.Write("Ge mig en temperatur: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 < -10)
            {
                Console.WriteLine($"{num1} grader: \"Det är jättekallt\"!");
            }
            else if (num1 >= -10 && num1 <= -1)
            {
                Console.WriteLine($"{num1} grader: \"Det är kallt\"!");
            }
            else if (num1 >= 0 && num1 <= 10)
            {
                Console.WriteLine($"{num1} grader: \"Det är milt\"!");
            }
            else if (num1 >= 11 && num1 <= 20)
            {
                Console.WriteLine($"{num1} grader: \"Det är lagom\"!");
            }
            else if (num1 >= 21 && num1 <= 30)
            {
                Console.WriteLine($"{num1} grader: \"Det är varmt\"!");
            }
            else
            {
                Console.WriteLine($"{num1} grader: \"Hjälp jag smälter\"!");
            }
        }

        // LOOPS LOOPS LOOPS LOOPS LOOPS LOOPS LOOPS LOOPS LOOPS LOOPS LOOPS
        // LOOPS LOOPS LOOPS LOOPS LOOPS LOOPS LOOPS LOOPS LOOPS LOOPS LOOPS
        // LOOPS LOOPS LOOPS LOOPS LOOPS LOOPS LOOPS LOOPS LOOPS LOOPS LOOPS
        // LOOPS LOOPS LOOPS LOOPS LOOPS LOOPS LOOPS LOOPS LOOPS LOOPS LOOPS
        public static void WhileNollTillTrettio()
        {
            // 8. Skriv ett program som med en while-loop skriver ut siffrorna 0 till 30 i konsolfönstret.

            int counter = 1;
            while (counter <= 30)
            {
                Console.WriteLine(counter);
                ++counter; // counter++ funkar också! Skillnad?
            }
        }

        public static void WhileTillMinusFem()
        {
            // 9. Skriv ett program som med en while-loop skriver ut siffrorna 15 till -5 i konsolfönstret.

            int counter = 15;
            while (counter >= -5)
            {
                Console.WriteLine(counter);
                --counter;
            }
        }

        public static void DelbartMedTre()
        {
            // 10. Skriv ett program som med en while-loop endast skriver ut tal som är 
            // jämnt delbara med 3 från 0 till 45.

            int counter = 1;
            while (counter <= 45)
            {
                if (counter % 3 == 0)
                {
                    Console.WriteLine(counter);
                }
                ++counter;
            }
        }

        public static void DoWhileNollTillHundra()
        {
            // 11. Skriv ett program som med en do-while-loop skriver ut siffrorna 0 till 100.

            int counter = 0;

            do
            {
                Console.WriteLine(counter);
                ++counter;
            }
            while (counter <= 100);
        }

        public static void ForMinusFemTillTjugotre()
        {
            // 12. Skriv ett program som med en for-loop skriver ut siffrorna -5 till 23.

            for (int counter = -5; counter <= 23; counter++)
            {
                Console.WriteLine(counter);
            }

        }
        public static void ForMinusTioTillMinusFyrtio()
        {
            // 13. Skriv ett program som med en for-loop skriver ut siffrorna -10 till -40.

            for (int counter = -10; counter >= -40; --counter)
            {
                Console.WriteLine(counter);
            }

        }
        public static void ForMinusTrettioTillMinusTio()
        {
            // 14. Skriv ett program som med en for-loop skriver ut siffrorna -30 till -10.

            for (int counter = -30; counter <= -10; ++counter)
            {
                Console.WriteLine(counter);
            }

        }

        public static void WhileDelbartMedTre()
        {
            // 15.	Skriv ett program som med en while-loop endast skriver ut tal 
            // som är jämnt delbara med 5 från 0 till 100.

            int counter = 0;

            while (counter <= 100)
            {
                if (counter % 5 == 0 && counter != 0)
                    Console.WriteLine(counter);
                counter += 5;
            }

        }
        public static void SkrivSiffran()
        {
            // 16. Skriv ett program som ber användaren om en siffra och sedan skriver ut den 
            // siffran lika många gånger som talet. Så skriver användaren ”5”, 
            // skriver programmet ut ”55555”.

            Console.WriteLine("Ge mig ett heltal: ");
            int siffran = Convert.ToInt32(Console.ReadLine());

            for (int counter = 1; counter <= siffran; counter++)
            {
                Console.Write(siffran);
            }
        }
        public static void AlmostFizzBuzz()
        {
            // 17.	Skriv ett program som skriver ut siffrorna 0 - 30 i konsolfönstret, 
            // men istället för 3, 15, och 27, skriver den ut ”hej!”.

            for (int counter = 0; counter <= 30; counter++)
            {
                if (counter == 3 || counter == 15 || counter == 27)
                    Console.WriteLine("Hej");
                else
                    Console.WriteLine(counter);
            }
        }

        public static void AlltUtomEttTal()
        {
            // 18.	Skriv ett program som skriver ut siffrorna 40 - 70 i konsolfönstret, 
            // utom ett tal som användaren matar in inom 40 - 70.

            bool loopar = true;

            while (loopar)
            {
                Console.Write("Ge mig ett heltal mellan 40 - 70: ");
                int myHeltal = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                if (myHeltal < 40 || myHeltal > 70)
                    continue;

                for (int counter = 40; counter <= 70; counter++)
                {
                    if (counter != myHeltal)
                        Console.WriteLine(counter);
                }
                loopar = false;
            }
        }
        public static void UddaTalTillSju()
        {
            // 19. Använd en while-loop för att skriva ett program som skriver ut udda tal från 15 ner till 7.

            int counter = 15;

            while (counter >= 7)
            {
                if (counter % 2 != 0)
                {
                    Console.WriteLine(counter);
                }
                --counter;
            }
        }


        public static void Sluta()
        {
            // 20.	Skriv ett program som ber användaren skriva in en text. 
            // När användaren gjort det ska texten skrivas ut till fönstret på en ny rad. 
            // Detta sa repeteras tills användaren skriver in sluta – 
            // vilket ska resultera i att programmet avslutas.

            while(true)
            {
                Console.WriteLine("Loopen forstätter tills det att du skriver 'sluta': ");
                Console.WriteLine("Var vänlig och skriv din sträng: ");
                string myString = Console.ReadLine();

                Console.WriteLine("Det här var din sträng: ");
                Console.WriteLine(myString);
                Console.WriteLine(" ");

                if (myString == "sluta")
                break;
            }
        }

        public static void DrawTriA1()
        {
            // 21. Skriv ett program som med hjälp av loopar skriver ut följande mönster till skärmen:
            // a.  *
            //     **
            //     ***
            //     ****
            //     *****
            //     ******

            for (int rader = 1; rader <= 6; rader++)
            {
                for (int stars = 1; stars <= rader; stars++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static void DrawTriA2()
        {
            // 21.	Skriv ett program som med hjälp av loopar skriver ut följande mönster till skärmen:
            // a2. ******
            //     *****
            //     ****
            //     ***
            //     **
            //     *

            for (int rader = 1; rader <= 6; rader++)
            {
                for (int stars = 5; stars >= rader; stars--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }


        public static void DrawTriB()
        {
            // 21.	Skriv ett program som med hjälp av loopar skriver ut följande mönster till skärmen:
            // b.  *
            //     **
            //     ***
            //     ****
            //     *****
            //     ****
            //     ***
            //     **
            //     *


            // del 1 - Uppåt
            for (int rader = 1; rader <= 5; rader++)
            {
                for (int stars = 1; stars <= rader; stars++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // Del 2 - Neråt
            for (int rader = 1; rader <= 4; rader++)
            {
                for (int stars = 4; stars >= rader; stars--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }

        public static void DrawTriC()
        {
            // 21.	Skriv ett program som med hjälp av loopar skriver ut följande mönster till skärmen:
            // c.  *
            //     **
            //     ***
            //     ****
            //     *****
            //     ****
            //     ***
            //     **
            //     *
            //     **
            //     ***
            //     ****
            //     *****
            //     ****
            //     ***
            //     **
            //     *

            // first triangel
            for (int rader = 1; rader <= 5; rader++)
            {
                for (int stars = 1; stars <= rader; stars++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int rader = 1; rader <= 4; rader++)
            {
                for (int stars = 4; stars >= rader; stars--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // second triangel
            for (int rader = 2; rader <= 5; rader++)
            {
                for (int stars = 1; stars <= rader; stars++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int rader = 1; rader <= 4; rader++)
            {
                for (int stars = 4; stars >= rader; stars--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static void DrawTriD1()
        {
            // 21.	Skriv ett program som med hjälp av loopar skriver ut följande mönster till skärmen:
            // d.  *
            //     **
            //     ****
            //     ********
            //     ****************
            //     ********
            //     ****
            //     **
            //     *

            // Row 1-5
            int[] myArray1 = { 1, 2, 4, 8, 16 };

            for (int rader = 1; rader <= 5; rader++)
            {
                for (int stars = 1; stars <= myArray1[rader - 1]; stars++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            // Row 6-9
            int[] myArray2 = { 8, 4, 2, 1 };

            for (int rader = 1; rader <= 4; rader++)
            {
                for (int stars = 1; stars <= myArray2[rader - 1]; stars++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }

        public static void DrawTriD2()
        {
            // 21.	Skriv ett program som med hjälp av loopar skriver ut följande mönster till skärmen:
            // d.  *
            //     **
            //     ****
            //     ********
            //     ****************
            //     ********
            //     ****
            //     **
            //     *
            // Detta är Joakims lösning - mycket bättre....
            // Han slipper arrays som med min lösning tack vare variabeln "starsPerRow" 

            int starsPerRow = 1;

            for (int rowIndex = 0; rowIndex < 5; rowIndex++)
            {
                for (int starIndex = 0; starIndex < starsPerRow; starIndex++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

                starsPerRow += starsPerRow;
            }
            starsPerRow /= 2;

            for (int rowIndex = 0; rowIndex < 4; rowIndex++)
            {
                starsPerRow /= 2;
                for (int starIndex = 0; starIndex < starsPerRow; starIndex++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }

        public static void DrawTriD3()
        {
            // 21.	Skriv ett program som med hjälp av loopar skriver ut följande mönster till skärmen:
            // d.  *
            //     **
            //     ****
            //     ********
            //     ****************
            //     ********
            //     ****
            //     **
            //     *
            // Detta är Joakims andra lösning - mycket bättre....
            // Han slipper arrays som med min lösning tack vare variabeln "starsPerRow" 

            int starsPerRow = 1;
            int peak = 5;

            for (int rowIndex = 0; rowIndex < 9; rowIndex++)
            {
                for (int starIndex = 0; starIndex < starsPerRow; starIndex++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

                bool shouldIncreaseStars = rowIndex < peak - 1;
                if (shouldIncreaseStars)
                {
                    starsPerRow += starsPerRow;
                }
                else
                {
                    starsPerRow /= 2;
                }

            }
        }

        public static void gissaTalet()
        {
            // Skriv ett Gissa talet-spel där användaren får mata in ett värde mellan 1 till 20 
            // där programmet svarar om användaren gissade rätt, för högt, eller för lågt. 
            // När användaren gissar rätt ska programmet gratulera användaren och avsluta. 
            // När användaren gissar ett tal för högt eller för lågt ska programmet uppmana om 
            // detta och låta användaren försöka igen. Låt det rätta svaret vara ett hårdkodat värde 
            // (ett värde som du själv sätter direkt i koden och aldrig blir förändrat).

            // a.Lägg till en variabel som räknar hur många försök användaren behövde för att gissa rätt.

            // b.Sök upp hur objektet Random fungerar och låt programmet slumpgenerera det rätta svaret 
            // varje gång programmet startar.

            // c.Tillåt användaren att bara gissa 5 gånger.Om användaren inte lyckas gissa rätt 
            // efter 5 försök ska programmet skriva ut att användaren förlorat spelet och avslutas.

            // Set the Foreground color to blue 
            // Console.ForegroundColor = ConsoleColor.Blue;

            Random rnd = new Random();
            int korrektSvar = rnd.Next(1, 21);

            int gissning = 0;
            int antalGissningar = 0;

            Console.Clear();

            while (korrektSvar != gissning && antalGissningar < 5)
            {
                if (antalGissningar > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Du har {5 - antalGissningar} gissningar kvar!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }

                Console.Write("\nGe mig ett nummer mellan 1-20: ");
                gissning = Convert.ToInt32(Console.ReadLine());

                if (gissning > korrektSvar)
                {
                    antalGissningar++;
                    if (antalGissningar == 5)
                    {
                        break;
                    }
                    Console.WriteLine("Din gissning var för hög tyvärr, Försök igen:");

                }
                else if (gissning < korrektSvar)
                {
                    antalGissningar++;
                    if (antalGissningar == 5)
                    {
                        break;
                    }
                    Console.WriteLine("Din gissning var för låg tyvärr, Försök igen:");
                }
                else if (gissning == korrektSvar)
                {
                    Console.WriteLine($"Congrats! Det korrekta svaret var {korrektSvar}!");
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nDet tog slut på gissningar tyvärr!");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Det korrekta svaret var {korrektSvar}!");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

    }
}

