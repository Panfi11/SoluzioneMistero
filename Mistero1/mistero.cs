using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Mistero1
{
    class mistero
    {
         public static int mistero1(int x, int y)
        {
            int prec;
            if (y == 0)
                return x;
            else
            {
                prec = mistero1(x, y - 1) + 1;
                return prec;
            }
        }

        public static int mistero2(int x, int y)
        {
            if (y == 0)
                return 0;
            else
            {
                return (mistero1(x, mistero2(x, y - 1)));

            }
        }
        public static int mistero3(int x, int y)
        {

            if (y == 0)
                return 1;
            else
            {
                return mistero2(x, mistero3(x, y - 1));
            }
        }
        public static string mistero4(long n)
        {
            Console.Write(n % 10);
            if (n / 10 != 0)
                return mistero4(n / 10);
            else
                return "";
        }
        public static int mistero5(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            return (mistero5(n - 1) + mistero5(n - 2));
        }
        public static int mistero6(int x, int y)
        {
            if (x < 0)
                return mistero6(x + y, y);
            else if (x < y)
                return x;
            else
                return mistero6(x - y, y);
        }
        public static int mistero7(int x, int y)
        {
            int z = 1;
            if (y < 0)
                z = 0;
            else if (y > 0)
                z = x * mistero7(x, y - 1);
            return z;
        }
        public static int mistero8(int a, int b)
        {
            int z;
            z = a % b;
            if (z == 0)
                return b;
            else
                a = b;
            b = z;
            return mistero8(a, b);
        }
    }
}
