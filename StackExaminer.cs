using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning4_SkalProjj
{
    internal class StackExaminer
    {
        public static void ExamineStack()
        {
            // Skapa en stack som håller namn på personer i "kön"
            Stack<string> stack = new Stack<string>();

            // ICA öppnar och "kön" är tom
            Console.WriteLine("ICA öppnar. 'Kön' är tom.");

            // Kalle ställer sig i kön
            stack.Push("Kalle");
            Console.WriteLine("Kalle ställer sig i 'kön'.");

            // Greta ställer sig i kön
            stack.Push("Greta");
            Console.WriteLine("Greta ställer sig i 'kön'.");

            // Kalle borde bli expedierad, men Greta blir expedierad istället (LIFO-problem)
            string servedPerson = stack.Pop();
            Console.WriteLine($"{servedPerson} blir expedierad och lämnar 'kön'. (LIFO-problem)");

            // Stina ställer sig i kön
            stack.Push("Stina");
            Console.WriteLine("Stina ställer sig i 'kön'.");

            // Greta borde vara kvar, men Kalle blir nu expedierad istället
            servedPerson = stack.Pop();
            Console.WriteLine($"{servedPerson} blir expedierad och lämnar 'kön'. (LIFO-problem)");

            // Olle ställer sig i kön
            stack.Push("Olle");
            Console.WriteLine("Olle ställer sig i 'kön'.");

            // Kolla vilka som är kvar i stacken (kön)
            Console.WriteLine("Personer kvar i 'kön' (stack):");
            foreach (var person in stack)
            {
                Console.WriteLine(person);
            }

            /*En stack följer LIFO, vilket innebär att den person som står sist i kön blir först expedierad, vilket strider mot hur en riktig kö fungerar.
             * I en verklig kö (t.ex. i en mataffär som ICA) ska den person som kommer först också betjänas först, alltså FIFO-principen. men i det här fallet kalle som ståg först i kön ståg kvar till sist*/
        }

        //ReversMetod
        public static void ReverseText()
        {
            // Be användaren att mata in en sträng
            Console.WriteLine("Skriv in en text som du vill vända:");
            string input = Console.ReadLine();

            // Skapa en stack för att lagra tecknen i strängen
            Stack<char> stack = new Stack<char>();

            // Lägg till varje tecken i strängen i stacken
            foreach (char c in input)
            {
                stack.Push(c);
            }

            // Bygg den omvända strängen genom att poppa tecken från stacken
            string reversedText = "";
            while (stack.Count > 0)
            {
                reversedText += stack.Pop();
            }

            // Skriv ut den omvända strängen
            Console.WriteLine("Den omvända texten är:");
            Console.WriteLine(reversedText);
        }
    }
}
