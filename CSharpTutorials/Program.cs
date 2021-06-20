using System;

namespace CSharpTutorials
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string message = "SpeciFIX";
            Console.WriteLine(message);

            var kata = new Kata();

            Console.WriteLine(kata.GetSum(3, 5));
            Console.WriteLine(kata.GetSum(-3, 5));
            Console.WriteLine(kata.GetSum(5, 5));
            Console.WriteLine(kata.GetSum(5, -0));
            Console.WriteLine(kata.GetSum(-5, -5));

            Console.WriteLine(kata.GetSumBetween(3, 5));
            Console.WriteLine(kata.GetSumBetween(-3, 5));
            Console.WriteLine(kata.GetSumBetween(5, 5));
            Console.WriteLine(kata.GetSumBetween(5, -0));
            Console.WriteLine(kata.GetSumBetween(-5, -5));
            Console.WriteLine(kata.GetSumBetween(5, 2));
        }
    }
}
