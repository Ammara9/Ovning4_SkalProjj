using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning4_SkalProjj
{
    internal class QueueExaminer
    {
        // ExamineQueue simulerar köhanteringen
        internal static void ExamineQueue()
        {
            // Skapa en kö som håller namn på personer i kön
            Queue<string> queue = new Queue<string>();

            // ICA öppnar och kön är tom
            Console.WriteLine("ICA öppnar. Kön är tom.");

            // Kalle ställer sig i kön
            queue.Enqueue("Kalle");
            Console.WriteLine("Kalle ställer sig i kön.");

            // Greta ställer sig i kön
            queue.Enqueue("Greta");
            Console.WriteLine("Greta ställer sig i kön.");

            // Kalle blir expedierad och lämnar kön
            string servedPerson = queue.Dequeue();
            Console.WriteLine($"{servedPerson} blir expedierad och lämnar kön.");

            // Stina ställer sig i kön
            queue.Enqueue("Stina");
            Console.WriteLine("Stina ställer sig i kön.");

            // Greta blir expedierad och lämnar kön
            servedPerson = queue.Dequeue();
            Console.WriteLine($"{servedPerson} blir expedierad och lämnar kön.");

            // Olle ställer sig i kön
            queue.Enqueue("Olle");
            Console.WriteLine("Olle ställer sig i kön.");

            // Visa vilka som är kvar i kön
            Console.WriteLine("Personer kvar i kön:");
            foreach (var person in queue)
            {
                Console.WriteLine(person);
            }
        }
    }
}
