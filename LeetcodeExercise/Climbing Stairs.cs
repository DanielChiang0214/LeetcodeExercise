using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeExercise
{
    public class Climbing_Stairs
    {
        public int ClimbStairs(int n)
        {
            return GoAhead(n, 0);
        }

        public int GoAhead(int last, int pace)
        {
            var theWay = 0;
            var result = last - pace;
            if (result > 1)
            {
                theWay += GoAhead(result, 2);
            }
            if (result > 0)
            {
                theWay += GoAhead(result, 1);
            }
            return result == 0 ? theWay + 1 : theWay;
        }
    }

    public class Climbing_Stairs_2
    {
        private readonly Dictionary<int, int> DP = new() { { 0, 1 } };
        public int ClimbStairs(int n)
        {
            return GoAhead(n, 0);
        }

        public int GoAhead(int last, int pace)
        {
            var result = last - pace;
            if (DP.TryGetValue(result, out var theWay))
            {
                return theWay;
            }
            if (result > 1)
            {
                theWay += GoAhead(result, 2);
            }
            if (result > 0)
            {
                theWay += GoAhead(result, 1);
            }
            DP[result] = theWay;
            return theWay;
        }


    }

    public class Climbing_Stairs_3
    {
        public int ClimbStairs(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            var a = 1;
            var b = 2;

            for (int i = 2; i < n; i++)
            {
                (a, b) = (b, a + b);
            }
            return b;
        }
    }
}
