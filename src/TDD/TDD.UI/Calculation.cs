using System;
using System.Collections.Generic;

namespace TDD.UI
{
    public static class Calculation
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static int Ave(List<int> list)
        {
            int values = 0;

            foreach (var val in list)
            {
                values += val;
            }

            return values / list.Count;
        }
    }
}
