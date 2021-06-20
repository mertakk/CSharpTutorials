using System;
namespace CSharpTutorials
{
    public class Kata
    {
        public Kata()
        {
        }

        public int GetSum(int a, int b) => (a != b) ? (a + b) : a;

        public int GetSumBetween(int a, int b)
        {
            int sum = 0;

            if (a == b)
            {
                return a;
            }
            else if (a < b)
            {
                for (int i = a; i <= b; i++)
                {
                    sum += i;
                }
                return sum;
            }
            else
            {
                for (int i = a; i >= b; i--)
                {
                    sum += i;
                }
                return sum;
            }
        }
    }
}
