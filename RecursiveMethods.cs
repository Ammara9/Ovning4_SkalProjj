internal class RecursiveMethods
{
    // Metod för att hantera inmatning och beräkna det n:te jämna talet
    public static void RecursiveEven()
    {
        Console.WriteLine("Ange n för det n:te jämna talet:");
        int evenN = int.Parse(Console.ReadLine());
        Console.WriteLine($"Det {evenN}:te jämna talet är: {CalculateEven(evenN)}");
    }

    // Privat rekursiv metod för att faktiskt beräkna det n:te jämna talet
    private static int CalculateEven(int n)
    {
        if (n == 0)
        {
            return 0;
        }
        return CalculateEven(n - 1) + 2;
    }

    // Metod för att hantera inmatning och beräkna det n:te Fibonacci-talet
    public static void Fibonacci()
    {
        Console.WriteLine("Ange n för Fibonaccisekvensen:");
        int fibN = int.Parse(Console.ReadLine());
        Console.WriteLine(
            $"Det {fibN}:te talet i Fibonaccisekvensen är: {CalculateFibonacci(fibN)}"
        );
    }

    // Privat rekursiv metod för att faktiskt beräkna det n:te Fibonacci-talet
    private static int CalculateFibonacci(int n)
    {
        if (n == 0)
        {
            return 0;
        }
        else if (n == 1)
        {
            return 1;
        }
        return CalculateFibonacci(n - 1) + CalculateFibonacci(n - 2);
    }
}
