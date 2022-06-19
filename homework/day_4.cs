using System;
using System.Collections.Generic;

namespace ChallangeApp
{
    class day_4
    {
        static void Main()
        {
            // small integers
            int i1 = 10;
            int i2 = 15;
            // big intigers
            long l1 = 4535435435454;
            long l2 = 534453245325435432;
            // intigers that end with .0
            float f1 = 11.0f;
            float f2 = 42.0f;
            // 28-29 digit precision number
            decimal dec1 = 30.5m;
            decimal dec2 = 50.8m;
            // 14-15 digit precision number
            double d = 18.543534;
            //  chain of characters
            string name = "Bartek";

            var sum = i1 + i2;
            var sub = l1 - l2;
            var div = f1 / f2;
            var mul = dec1 * dec2;
            var pow = d * d;
            var str = i1 + name;
        }
    }
}
