using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnScript
{
    public class CalcClass
    {
        public static long Add(long i, long j)
        {
            return (i+j);
        }
        public static long Mul(long i, long j)
        {
            return (i * j);
        }
        public static long Mod(long i, long j)
        {
            return (i % j);
        }
    }
}