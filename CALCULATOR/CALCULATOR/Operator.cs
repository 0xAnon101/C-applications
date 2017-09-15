using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULATOR
{
    class Operator
    {
        public static int add(int a, int b)
        {
            return a + b;
        }
        public static double add(double a, double b )
        {
            return a + b;
        }

        public static int mul(int a, int b)
        {
            return a * b;
        }
        public static double mul(double a, double b)
        {
            return a * b;
        }

        public static int sub(int a, int b)
        {
            return a-b;
        }
        public static double sub(double a, double b)
        {
            return a-b;
        }

        public static int div(int a, int b)
        {
            return a / b;
        }
        public static double div(double a, double b)
        {
            return a / b;
        }
    }
}
