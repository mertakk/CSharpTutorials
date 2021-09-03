using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static MyClass;

namespace CSharpTutorials
{

    public delegate void MyDelegate(string msg); //declaring a delegate

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

            IList<string> stringList = new List<string>()
            {
                "C# Tutorials",
                "VB.NET Tutorials",
                "Learn C++",
                "MVC Tutorials",
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

            IList<Student> studentList = new List<Student>()
            {
                new Student() { StudentID = 1, StudentName = "John", age = 18 },
                new Student() { StudentID = 2, StudentName = "Steve", age = 21 },
                new Student() { StudentID = 3, StudentName = "Bill", age = 18 },
                new Student() { StudentID = 4, StudentName = "Ram", age = 20 },
                new Student() { StudentID = 5, StudentName = "Ron", age = 21 }
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

            //    int[,,,] arr4d2 = new int[1, 2, 2, 2]{
            //    {
            //        {{1, 2}, {3, 4}},
            //        {{5, 6}, {7, 8}}
            //    }
            //};

            //    arr4d2[1, 1, 1, 1] = 2;

            //    int[][][] intJaggedArray = new int[2][][]
            //                    {
            //                        new int[2][]
            //                        {
            //                            new int[3] { 1, 2, 3},
            //                            new int[2] { 4, 5}
            //                        },
            //                        new int[1][]
            //                        {
            //                            new int[3] { 7, 8, 9}
            //                        }
            //                    };

            //    Console.WriteLine(intJaggedArray[0][0][0]); // 1

            //    Console.WriteLine(intJaggedArray[0][1][1]); // 5

            //    Console.WriteLine(intJaggedArray[1][0][2]); // 9

            //In the above example of a jagged array, three brackets[][][] means an array of array of array. So, intJaggedArray will contain two elements,
            //which means two arrays. Now, each of these arrays also contains an array(single-dimension). intJaggedArray[0][0][0] points to the first
            //element of first inner array.intJaggedArray[1][0][2] points to the third element of the second inner array.

            StringDataStore strStore = new StringDataStore();

            strStore[0] = "One";
            strStore[1] = "Two";
            strStore[2] = "Three";
            strStore[3] = "Four";

            for (int b = 0; b < 4; b++)
                Console.WriteLine(strStore[b]);

            //Why use indexers:
            //            -instead of a new data structure, the class itself is a data structure.
            //- simplified syntax - syntactic sugar

            //When to use:
            //- if your class needs list(/array) of its instances
            //- if your class represents list(/array) of values directly related to your class

            //Generic and Overloading indexers are important!

            //Console.WriteLine(kata.RowSumOddNumbers(1));
            //Console.WriteLine(kata.RowSumOddNumbers(2));
            //Console.WriteLine(kata.RowSumOddNumbers(3));
            //Console.WriteLine(kata.RowSumOddNumbers(42));

            //Console.WriteLine(kata.GetMiddle("test"));
            //Console.WriteLine(kata.GetMiddle("testing"));
            //Console.WriteLine(kata.GetMiddle("middle"));
            //Console.WriteLine(kata.GetMiddle("A"));

            //Generic constraint descriptions are important!

            DataStore<int> store = new DataStore<int>(); // valid
            DataStore<char> store2 = new DataStore<char>(); // valid

            //In most cases, it is recommended to use the generic collections because they perform faster than non-generic collections
            //and also minimize exceptions by giving compile-time errors.

            var arlist = new ArrayList();

            //An ArrayList can be used to add unknown data where you don't know the types and the size of the data.

            //It is not recommended to use the ArrayList class due to performance issue. Instead, use List<object> to store heterogeneous objects.
            //To store data of same data type, use Generic List<T>.

            var cities = new List<string>();
            cities.Add("New York");
            cities.Add("London");
            cities.Add("Mumbai");
            cities.Add("Chicago");
            cities.Add(null); // nulls are allowed for reference type list

            //SortedList Sorts elements as soon as they are added.
            //It is recommended to use generic SortedList<TKey, TValue> because it performs faster and less error-prone than the non-generic SortedList.
            //Keys cannot be null or duplicate.

            SortedList<int, string> numberNames = new SortedList<int, string>()
            {
                { 3, "Three" },
                { 5, "Five" },
                { 1, "One" }
            };

            Console.WriteLine("---Initial key-values--");

            foreach (KeyValuePair<int, string> kvp in numberNames)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);

            numberNames.Add(6, "Six");
            numberNames.Add(2, "Two");
            numberNames.Add(4, "Four");

            Console.WriteLine("---After adding new key-values--");

            foreach (var kvp in numberNames)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);

            //Use Keys and Values properties if you want to iterate a SortedList using a for loop.

            //The difference between SortedList and Dictionary is that Dictionary is not ordered.

            //Hashtable is a loosely typed (non-generic) collection, this means it stores key-value pairs of any data types.
            //Dictionary is a generic collection. So it can store key-value pairs of specific data types.
            //Data retrieval is slower than dictionary because of boxing-unboxing.
            //Data retrieval is faster than Hashtable.

            Hashtable numberNames2 = new Hashtable();
            numberNames2.Add(1, "One"); //adding a key/value using the Add() method
            numberNames2.Add(2, "Two");
            numberNames2.Add(3, "Three");

            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "one");
            dict.Add(2, "two");
            dict.Add(3, "three");

            Hashtable ht = new Hashtable(dict);

            //HashTable is non-generic, Dictionary is generic.

            //Console.WriteLine(kata.OddOrEven(new int[3] {0, -1, 2}));
            //Console.WriteLine(kata.OddOrEven(new int[3] {0, 1, -4}));
            //Console.WriteLine(kata.OddOrEven(new int[3] {-1023, -1, 3}));

            //It is recommended to use the generic Stack<T> collection.
            //Elements can be retrieved using the Pop() and the Peek() methods. It does not support an indexer.
            //Can't use array initializer style.

            //Dequeue() removes and returns the first element from a queue. Peek() method always returns the first item from a queue
            //collection without removing it.

            //Console.WriteLine(kata.IsSquare(-1));
            //Console.WriteLine(kata.IsSquare(3));
            //Console.WriteLine(kata.IsSquare(4));
            //Console.WriteLine(kata.IsSquare(25));
            //Console.WriteLine(kata.IsSquare(26));

            //A tuple can only include a maximum of eight elements.

            var numbers = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10, 11, 12, 13));

            //When you want to return multiple values from a method without using ref or out parameters.
            //When you want to pass multiple values to a method through a single parameter.
            //The Tuple is a reference type and not a value type.

            //Unlike Tuple, a ValueTuple can include more than eight values.

            var numbersValueTuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14);

            //use discard _ for the unused member LName

            //The ApplicationException was recommended to be base class for all your custom exceptions classes
            //However, Microsoft now recommends to derive custom exception classes from the Exception class rather than the ApplicationException class .

            //The finally block will always be executed whether or not an exception occurred. The finally block generally used for cleaning-up code e.g., disposing of unmanaged objects.
            //It doesn't let control to leave the finally block.

            //When using nested try-catch blocks, an exception will be caught in the first matching catch block that follows the try block where an exception occurred.

            //If there isn't an inner catch block that matches with raised exception type, then the control will flow to the outer catch block until it finds an appropriate exception filter.

            //The throw keyword cannot be used with any other type which does not derive from the Exception class.

            //If you re-throw an exception using exception parameter then it will not preserve the original exception and creates a new exception.
            //never throw an exception using throw <exception parameter>.

            //Microsoft now recommends Exception class to create a custom exception class. You should not throw an ApplicationException exception in your code, and you should not catch
            //an ApplicationException exception unless you intend to re-throw the original exception.

            //Console.WriteLine(kata.Factorial(5));
            ////Console.WriteLine(kata.Factorial(15));
            //Console.WriteLine(kata.Factorial(0));
            //Console.WriteLine(kata.Factorial(-5));

            //Console.WriteLine(kata.HighAndLow("5 2 3 1 2"));
            //Console.WriteLine(kata.HighAndLow("-5 2 2 1 1999"));
            //Console.WriteLine(kata.HighAndLow("5 -2 3 0 1 -2"));
            //Console.WriteLine(kata.HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));

            //Practically, delegates should be declared out of the class.

            MyDelegate del = ClassA.MethodA;
            del("Hello World");

            del = ClassB.MethodB;
            del("Hello World");

            del = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
            del("Hello World");
            
            //In .NET, Func and Action types are built-in generic delegates that should be used for most common delegates instead of creating new custom delegates.
            
            //If a delegate returns a value, then the last assigned target method's value will be return when a multicast delegate called.
            
            //A generic delegate can be defined the same way as a delegate but using generic type parameters or return type. The generic type must be specified when you set a target method.
            
            //Action delegate is same as func delegate except that it does not return anything. Return type must be void.
        }
    }

    public class ClassA
    {
        public static void MethodA(string message)
        {
            Console.WriteLine("Called ClassA.MethodA() with parameter: " + message);
        }
    }

    class ClassB
    {
        public static void MethodB(string message)
        {
            Console.WriteLine("Called ClassB.MethodB() with parameter: " + message);
        }
    }

    [Serializable]
    class InvalidStudentNameException : Exception
    {
        public InvalidStudentNameException()
        {
        }

        public InvalidStudentNameException(string name)
            : base(String.Format("Invalid Student Name: {0}", name))
        {

        }
    }
}