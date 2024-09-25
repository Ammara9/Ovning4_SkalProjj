using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning4_SkalProjj
{
    internal class ParenthesesChecker
    {
        /*Stack är den bästa datastrukturen för detta problem eftersom
         * vi kan "pusha" öppningsparenteser på stacken och "poppa" dem när vi hittar en matchande stängningsparentes.
         * Stackens Last-In-First-Out (LIFO) egenskap gör den till en naturlig lösning för att hantera par av parenteser. */
        internal static void CheckParentheses()
        {
            // Läs in en sträng från användaren
            Console.WriteLine("Skriv in en sträng för att kontrollera om den är välformad:");
            string input = Console.ReadLine();

            // Stack för att hålla öppningsparenteser
            Stack<char> stack = new Stack<char>();

            // Gå igenom varje tecken i strängen
            foreach (char ch in input)
            {
                // Om tecknet är en öppningsparentes, lägg det på stacken
                if (ch == '(' || ch == '{' || ch == '[')
                {
                    stack.Push(ch);
                }
                // Om tecknet är en stängningsparentes
                else if (ch == ')' || ch == '}' || ch == ']')
                {
                    // Kontrollera om stacken är tom (ingen matchande öppningsparentes)
                    if (stack.Count == 0)
                    {
                        Console.WriteLine("Strängen är inte välformad.");
                        return; // Mismatch, avsluta kontrollen
                    }

                    // Poppa från stacken och kontrollera om det matchar rätt öppningsparentes
                    char last = stack.Pop();
                    if (
                        (ch == ')' && last != '(')
                        || (ch == '}' && last != '{')
                        || (ch == ']' && last != '[')
                    )
                    {
                        Console.WriteLine("Strängen är inte välformad.");
                        return; // Felaktig matchning, avsluta kontrollen
                    }
                }
            }

            // Om stacken är tom efter genomgång är strängen välformad
            if (stack.Count == 0)
            {
                Console.WriteLine("Strängen är välformad.");
            }
            else
            {
                Console.WriteLine("Strängen är inte välformad.");
            }
        }
    }
}
