using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public static int SquareDigits(int n)
        {
            string inputNumberAsText = n.ToString();
            StringBuilder outputNumberAsText = new StringBuilder();

            for (int i = 0; i < inputNumberAsText.Length; i++)
            {
                var tempNumber = Convert.ToInt32(inputNumberAsText[i] - '0');
                // TODO: - '0' işlemini sil. Neden 57 çıkıyor '9'?
                outputNumberAsText.Append(Math.Pow(tempNumber, 2).ToString());
            }
            return Convert.ToInt32(outputNumberAsText.ToString());
        }

        public long RowSumOddNumbers(long n)
        {
            var firstOfRow = n * (n - 1) + 1;
            long sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += firstOfRow + i * 2;

            }
            return sum;
        }

        public string GetMiddle(string s)
        {
            if (s.Length == 1)
            {
                return s;
            }
            if (s.Length % 2 == 1)
            {
                return s[(s.Length - 1) / 2].ToString();
            }
            return s[(s.Length - 1) / 2].ToString() + s[((s.Length - 1) / 2) + 1].ToString();
        }

        public string OddOrEven(int[] array)
        {
            var sum = 0;
            
            foreach (var member in array)
            {
                sum += member;
            }

            if (sum % 2 == 1 || sum % 2 == -1)
            {
                return "odd";
            }

            return "even";
        }

        public bool IsSquare(int n)
        {
            if (n  == null)
                throw new NullReferenceException("Object is null.");

            if (n < 0 || Math.Sqrt(n) - Math.Floor(Math.Sqrt(n)) > 0)
            {
                return false;
            }

            return true;
        }

        public int Factorial(int n)
        {
            if (n < 0 || n > 12)
            {
                throw new ArgumentOutOfRangeException();
            }

            var result = 1;

            for (int i = n; i > 0; i--)
            {
                    result *= i;
            }

            return result;
        }

        public string HighAndLow(string numbers)
        {
            int[] parsed = numbers.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            
            Array.Sort(parsed);

            StringBuilder result = new StringBuilder();

            result.Append(parsed[parsed.Length-1]);
            result.Append(" ");
            result.Append(parsed[0]);
            
            //string lowest = parsed[0].ToString();
            //string highest = parsed[parsed.Length-1 ].ToString();
            
            //string result = highest + " " + lowest;

            return result.ToString();
        }
        
        public int Angle(int n)
        {
            return (n - 2) * 180;
        }
        
        public int Stray(int[] numbers)
        {
            Array.Sort(numbers);
            
            return numbers[0] != numbers[1] ? numbers[0] : numbers[numbers.Length - 1];
        }
        
        public string Accum(string s)
        {
            StringBuilder result = new StringBuilder();
            
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < i+1; j++)
                {
                    if (j == 0)
                    {
                        result.Append(Char.ToUpper(s[i]));
                    }
                    else
                    {
                        result.Append(Char.ToLower(s[i]));
                    }
                }
                
                if (i != s.Length-1)
                {
                    result.Append('-');
                }
            }
            
            return result.ToString();
        }
        
        public int DescendingOrder(int num)
        {
            var tempString = num.ToString();
            
            List<int> tempList = tempString.Select(c => int.Parse(c.ToString())).ToList();
            
            tempList.Sort();
            tempList.Reverse();
            
            var result = 0;
            
            foreach (int entry in tempList)
            {
                result = 10 * result + entry;
            }
            
            return result;
        }
        
        public double Arithmetic(double a, double b, string op)
        {
            switch (op)
            {
                case "add":
                    return a + b;
                case "subtract":
                    return a - b;
                case "multiply":
                    return a * b;
                case "divide":
                    return a / b;
                default:
                    throw new Exception();
            }
        }

        public bool IsAscOrder(int[] arr)
        {
            int[] temp = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                temp[i] = arr[i];
            }
            
            Array.Sort(arr);

            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] != temp[j])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
