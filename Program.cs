namespace Ovning4_SkalProjj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListExaminer.ExaminList();
            QueueExaminer.ExamineQueue();
            StackExaminer.ExamineStack();
            StackExaminer.ReverseText();
            ParenthesesChecker.CheckParentheses();
            RecursiveMethods.RecursiveEven();
            RecursiveMethods.Fibonacci();
            IterativeMethods.Fibonacciräknare();
            IterativeMethods.IterativeEven();
        }
    }
}
