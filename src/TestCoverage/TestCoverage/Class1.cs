namespace TestCoverage
{
    public class Class1
    {
        public static int CallA(int a, int b)
        {
            return a + b;
        }

        public static int CallB(int a, int b)
        {
            if (a == 0)
            {
                return 1;
            }

            return a + b;
        }

        public static int CallC(int a, int b)
        {
            return a - b;
        }
    }
}
