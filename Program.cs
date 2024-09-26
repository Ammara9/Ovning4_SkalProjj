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

            /*Iteration är mer effektiv när det gäller minnesanvändning, eftersom den inte skapar nya stackanrop för varje iteration.*/
        }
    }
}
