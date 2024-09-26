namespace Ovning4_SkalProjj
{
    internal class IterativeMethods
    {
        internal static void Fibonacciräknare()
        {
            Console.WriteLine("Ange n för Fibonaccisekvensen:");
            int fibN = int.Parse(Console.ReadLine());
            Console.WriteLine(
                $"Det {fibN}:te talet i Fibonaccisekvensen är: {CalculateFibonacci(fibN)}"
            );
        }

        private static int CalculateFibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }

            int previous = 0;
            int current = 1;

            for (int i = 2; i <= n; i++)
            {
                int temp = current;
                current = previous + current;
                previous = temp;
            }

            return current;
        }

        internal static void IterativeEven()
        {
            Console.WriteLine("Ange n för det n:te jämna talet:");
            int evenN = int.Parse(Console.ReadLine());
            Console.WriteLine($"Det {evenN}:te jämna talet är: {CalculateEven(evenN)}");
        }

        private static int CalculateEven(int n)
        {
            int evenNumber = 0; // Börja med det första jämna talet
            for (int i = 0; i < n; i++)
            {
                evenNumber += 2; // Addera 2 för varje iteration
            }
            return evenNumber;
        }
    }
}
