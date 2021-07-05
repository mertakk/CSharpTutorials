using System;

public class MyClass
{
    public string myField = string.Empty;

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
}
