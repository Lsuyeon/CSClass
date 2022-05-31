using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass
{
    class Method
    {
        public double Multi(double v1, int v2)
        {
            return v1 * v2;
        }

        public int Sum(int min, int max)
        {
            int output = 0;
            for (int i = min; i <= max; i++)
            {
                output += i;
            }
            return output;
        }

        public int Multiply(int min, int max)
        {
            int output = 1;
            for (int i = min; i <= max; i++)
            {
                output *= i;
            }
            return output;
        }
    }
}
