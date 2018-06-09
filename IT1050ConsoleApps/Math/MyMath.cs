using System;
using System.Collections.Generic;
using System.Text;

namespace Math
{
    public class MyMath
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Factorial(int n)
        {
            int answer = 1;
            for (int i = 2; i <= n; i++)
            {
                answer *= i;
            }
            return answer;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Min(int a, int b)
        {
            return System.Math.Min(a, b); 

            //If you wanted the work shown, here it is:
            //int answer = a;
            //if (a > b)
            //{
            //    answer = b;
            //}
            //return answer;
        }
    }
}
