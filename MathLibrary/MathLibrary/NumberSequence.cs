using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public class NumberSequence
    {
        static List<long> fiboSequence = new List<long>();
        static List<ulong> factorialSequence = new List<ulong>();
        static List<long> catalanSequence = new List<long>();


        public static long Fibonacci(int position)
        {
            if (fiboSequence.Count <= position)
            {
                if (position == 0)
                {
                    fiboSequence.Add(0);
                }
                else if (position == 1)
                {
                    fiboSequence.Add(1);
                }
                else
                {
                    fiboSequence.Add(Fibonacci(position - 1) + Fibonacci(position - 2));
                }
            }

            return fiboSequence[position];
        }

        public static ulong Catalan(int position)
        {
            return (Factorial(position * 2)) / (Factorial(position + 1) * Factorial(position));
        }

        public static ulong Factorial(int position)
        {
            if (factorialSequence.Count <= position)
            {
                if (position == 0)
                {
                    factorialSequence.Add(1);
                }
                else
                {
                    factorialSequence.Add((ulong)position * Factorial(position - 1));
                }
            }

            return factorialSequence[position];
        }

        public static int Bell(int position)
        {
            return 0;
        }
    }
}
