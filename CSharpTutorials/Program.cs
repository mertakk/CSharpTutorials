using System;
using System.Collections.Generic;
using System.Linq;
using static MyClass;

namespace CSharpTutorials
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string message = "SpeciFIX";
            //Console.WriteLine(message);

            var kata = new Kata();

            //Console.WriteLine(kata.GetSum(3, 5));
            //Console.WriteLine(kata.GetSum(-3, 5));
            //Console.WriteLine(kata.GetSum(5, 5));
            //Console.WriteLine(kata.GetSum(5, -0));
            //Console.WriteLine(kata.GetSum(-5, -5));

            //Console.WriteLine(kata.GetSumBetween(3, 5));
            //Console.WriteLine(kata.GetSumBetween(-3, 5));
            //Console.WriteLine(kata.GetSumBetween(5, 5));
            //Console.WriteLine(kata.GetSumBetween(5, -0));
            //Console.WriteLine(kata.GetSumBetween(-5, -5));
            //Console.WriteLine(kata.GetSumBetween(5, 2));

            int implicitlyTypedVariable = 100;
            var explicitlyTypedVariable = 100;

            var ano = new { name = "Steve" };
            //Console.WriteLine("Type of ano is {0}", ano.GetType());

            var arr = new[] { 1, 10, 20, 30 };
            //Console.WriteLine("Type of arr is {0}", arr.GetType());

            IList<string> stringList = new List<string>() {
                "C# Tutorials",
                "VB.NET Tutorials",
                "Learn C++",
                "MVC Tutorials" ,
                "Java"
            };

            var result = from s in stringList
                         where s.Contains("Tutorials")
                         select s;

            var result_2 = stringList.Where(s => s.Contains("Tutorials"));

            ulong soLong = 18446744073709551615ul;

            //Console.WriteLine(kata.SeriesSum(0));
            //Console.WriteLine(kata.SeriesSum(5));
            //Console.WriteLine(kata.SeriesSum(3));
            //Console.WriteLine(kata.SeriesSum(2));
            //Console.WriteLine(kata.SeriesSum(1));
            //Console.WriteLine(kata.SeriesSum(79));
            //Console.WriteLine(kata.SeriesSum(48));

            //Console.WriteLine(kata.FindNextSquare(121));
            //Console.WriteLine(kata.FindNextSquare(625));
            //Console.WriteLine(kata.FindNextSquare(114));

            Coordinate point = new Coordinate(10, 20);

            point.x = 20;

            Console.WriteLine(point.x);

            //it is easier to transfer a class object than a struct. So do not use struct when you are passing data across the wire or to other classes.
            // TODO: Structure alttaki iki kod bloğu incelenecek

            // TODO: Interface'e kadar gelinecek

            int? x = null;

            x ??= 5; //??= assigns value of the right operand only if the left operand is null
        }
    }
}
