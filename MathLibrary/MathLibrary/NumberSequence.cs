using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public class NumberSequence
    {
        static List<int> fiboSequence = new List<int>();
        public static int Fibonacci(int position)
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

        public static uint Catalan(uint position)
        {
            return 0;
        }

        public static uint Bell(uint position)
        {
            return 0;
        }
    }
}
