using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning4_SkalProjj
{
    internal class ListExaminer
    {
        // 1.1 Skapa ExaminList funktion för att undersöka hur en List fungerar och hanterar kapacitet.
        internal static void ExaminList()
        {
            // Skapar en ny lista av heltal (int) som börjar med en standardkapacitet på 0.
            List<int> num = new List<int>();

            /* 1.2 Listans kapacitet ökar automatiskt när antalet element överskrider dess nuvarande kapacitet.
             * Detta sker när man försöker lägga till fler element än vad listan kan hålla just nu.
             * Här visas den initiala kapaciteten som förväntas vara 0 i början. */
            Console.WriteLine($"Initial Capacity: {num.Capacity}");

            /* 1.3 Kapaciteten fördubblas ofta när listans gräns nås. I loopen nedan läggs element till en
             * efter en, och varje gång listan behöver utökas, fördubblas kapaciteten för att optimera prestandan.
             * Vi observerar hur kapaciteten förändras efter att varje element lagts till i listan. */
            for (int i = 0; i < 10; i++)
            {
                num.Add(i); // Lägg till elementet i listan.
                Console.WriteLine($"Capacity after adding {i}: {num.Capacity}"); // Skriv ut den aktuella kapaciteten.
            }

            /* 1.4 Kapaciteten ökar inte varje gång ett enskilt element läggs till. Istället växer den exponentiellt
             * (oftast genom att fördubblas) för att minimera behovet av frekvent minnesallokering och därmed öka effektiviteten.
             * Detta sparar tid vid frekventa insättningar. */

            /* 1.5 När du tar bort ett element från listan minskar inte kapaciteten automatiskt.
             * Detta är för att undvika att dynamiskt ändra storlek för ofta, vilket skulle påverka prestandan negativt.
             * TrimExcess() kan dock användas för att manuellt justera kapaciteten efter behov. */

            /* 1.6 Du kan vilja sätta en specifik kapacitet i förväg om:
             * - Du vet exakt hur många element du behöver och vill undvika onödiga tilldelningar.
             * - Du söker maximal prestanda och vill undvika overhead som kommer med dynamisk kapacitetsändring.
             * - Du arbetar med begränsat minne och behöver strikt kontrollera minnesanvändningen. */
        }
    }
}
