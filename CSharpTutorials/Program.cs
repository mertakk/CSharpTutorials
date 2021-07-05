﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            //Struct does not include in inheritance.

            int? x = null;

            x ??= 5; //??= assigns value of the right operand only if the left operand is null

            //Ternary ----------

            x = 10;
            int y = 100;

            var resultTernary = x > y ? "x is greater than y" : "x is less than y";

            Console.WriteLine(result);

            //Same as ----------

            x = 10;
            y = 100;

            if (x > y)
                Console.WriteLine("x is greater than y");
            else
                Console.WriteLine("x is less than y");

            //Ternary end ----------

            Console.WriteLine((int)State.Active);

            StringBuilder sbAmout = new StringBuilder("Your total amount is ");
            sbAmout.AppendFormat("{0:C} ", 25);

            Console.WriteLine(sbAmout); //9 times out of 10 though... use the string builder.

            IList<Student> studentList = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "John", age = 18 },
            new Student() { StudentID = 2, StudentName = "Steve",  age = 21 },
            new Student() { StudentID = 3, StudentName = "Bill",  age = 18 },
            new Student() { StudentID = 4, StudentName = "Ram" , age = 20  },
            new Student() { StudentID = 5, StudentName = "Ron" , age = 21 }
        };

            var students = from s in studentList
                           select new { Id = s.StudentID, Name = s.StudentName };

            foreach (var stud in students)
                Console.WriteLine(stud.Id + "-" + stud.Name);
            //select clause in the LINQ query selects only StudentID and StudentName properties and renames it to Id and Name, respectively.
            //Thus, it is useful in saving memory and unnecessary code.
        }
    }
}
