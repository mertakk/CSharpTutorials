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

            dynamic MyDynamicVar = 100;
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = "Hello World!!";
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = true;
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = DateTime.Now;
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            //Partial methods must use the partial keyword and must return void.

            MyClass mycls = new MyClass();

            if (mycls.i == null)
            {
                Console.WriteLine("Null");
            }

            //It must be assigned a value before using it if nullable types are declared in a function as local variables.
            //If it is a field of any class then it will have a null value by default.

            int? i = null;
            int j = 10;

            if (Nullable.Compare<int>(i, j) < 0)
                Console.WriteLine("i < j");
            else if (Nullable.Compare<int>(i, j) > 0)
                Console.WriteLine("i > j");
            else
                Console.WriteLine("i = j");

            //compare method to compare nullable types

            //Nullable types can only be used with value types.

            //You can only use == and != operators with a nullable type. For other comparison use the Nullable static class.

            //STRUCT IS A VALUE TYPE!!!

            //CLASS IS A REFERENCE TYPE!!!

            //When you pass a reference type variable from one method to another, it doesn't create a new copy;
            //instead, it passes the variable's address. So, If we change the value of a variable in a method,
            //it will also be reflected in the calling method.

            //String is a reference type, but it is immutable. It means once we assigned a value, it cannot be changed.
            //If we change a string value, then the compiler creates a new string object in the memory and point a variable to the new memory location.
            //So, passing a string value to a function will create a new variable in the memory,
            //and any change in the value in the function will not be reflected in the original value

            Console.WriteLine(Kata.SquareDigits(0));
            Console.WriteLine(Kata.SquareDigits(99));
            Console.WriteLine(Kata.SquareDigits(11));
            Console.WriteLine(Kata.SquareDigits(3245));

            //It is recommended to implement interfaces explicitly (void IBinaryFile.ReadFile()) when implementing multiple interfaces
            //to avoid confusion and more readability.
            //Interface cannot include private, protected, or internal members. All the members are public by default.
            //Use public modifier when implementing interface implicitly, whereas don't use it in case of explicit implementation.
            //An interface can inherit one or more interfaces.

            //Static means something which cannot be instantiated. You cannot create an object of a static class and cannot access static members using an object.
            //All the members of a static class must be static; otherwise the compiler will give an error.
            //var cannot be used to define static members. You must specify a type of member explicitly after the static keyword.
            //Static class members can be accessed using ClassName.MemberName.
            //Static fields of a non-static class is shared across all the instances. So, changes done by one instance would reflect in others.
            //You cannot call static methods using an object of the non-static class.
            //The static methods can only call other static methods and access static members. You cannot access non-static members of the class in the static methods.
            //Static methods can be overloaded but cannot be overridden.
            //Static methods cannot access or call non-static variables unless they are explicitly passed as parameters.
            //The static constructor is called only once whenever the static method is used or creating an instance for the first time.
        }
    }
}
