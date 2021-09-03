using System;

public delegate void Notify();

public class MyClass
{
    
    public event Notify ProcessCompleted; // event

    public void StartProcess()
    {
        Console.WriteLine("Process Started!");
        // some code here..
        OnProcessCompleted();
    }

    protected virtual void OnProcessCompleted() //protected virtual method
    {
        //if ProcessCompleted is not null then call delegate
        ProcessCompleted?.Invoke(); 
    }
    
    public static bool IsUpperCase(string str)
    {
        return str.Equals(str.ToUpper());
    }
    
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int age { get; set; }
    }

    public string myField = string.Empty;
    public Nullable<int> i;

    public MyClass()
    {
    }

public void MyMethod(int parameter1, string parameter2)
{
    Console.WriteLine("First Parameter {0}, second parameter {1}",
                                                parameter1, parameter2);
}

public int MyAutoImplementedProperty { get; set; }

private int _myPropertyVar;

public int MyProperty
{
    get
    {
        return _myPropertyVar / 2;
    }

    set
    {
        if (value > 100)
            _myPropertyVar = 100;
        else
            _myPropertyVar = value; ;
    }
}

public struct Coordinate
{
    public int x;
    public int y;

    public Coordinate(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}

public enum State : byte
{
    Passive,
    Active
}
    public class StringDataStore
    {
        private string[] strArr = new string[10]; // internal data storage

        public string this[int index]
        {
            get => strArr[index];

            set => strArr[index] = value;
        }
    }
    public class DataStore<T> where T : struct
    {
        public T Data { get; set; }
    }
}