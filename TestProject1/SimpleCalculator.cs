using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    /// <summary>
    /// This is my simple calculator (Edited from GitHub).
    /// </summary>
    public static class SimpleCalculator
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }

        /// <summary>
        /// Subtracts y from x.
        /// </summary>
        public static int Subtract(int x, int y)
        {
            return x - y;
        }

        public static double Multiply(int x, int y)
        {
            // This edit has been made on GitHub.
            return x * y;
        }
    }
}
