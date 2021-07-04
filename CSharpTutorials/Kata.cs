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

        public string SeriesSum(int input)
        {
            if (input == 0)
            {
                return "0.00";
            }

            float sum = 1.00f;

            for (int i = 1; i < input; i++)
            {
                sum += (float)1 / (3 * i + 1);

            }

            float roundedSum = (float)Math.Round((float)sum, 2);

            if (roundedSum % 1 == 0)
            {
                return roundedSum.ToString() + ".00";
            }
            else if ((float)(roundedSum * 10) % 1 == 0)
            {
                return roundedSum.ToString() + "0";
            }

            return roundedSum.ToString();
        }

        public int FindNextSquare(int input)
        {
            if (Math.Sqrt(input) % 1 != 0)
            {
                return -1;
            }

            bool isPerfectFound = false;

            while (!isPerfectFound)
            {
                input++;
                if (Math.Sqrt(input) % 1 == 0)
                {
                    isPerfectFound = true;
                }
            }

            return input;
        }
    }
}
