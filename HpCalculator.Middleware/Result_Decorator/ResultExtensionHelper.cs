using System;

namespace HpCalculator.Middleware.Result_Decorator
{
    public static class ResultExtensionHelper
    {
        public static string GetColor (object result)
        {
            if (result == null)
            {
                return "unknown";
            }
            return IsOdd(result) ? "red" : "green";
        }

        public static bool IsOdd (object result)
        {
            return int.Parse(result.ToString()) % 2 != 0;
        }

        public static bool IsPrime(object result)
        {
            var number = int.Parse(result.ToString());

            if (number <= 1)
                return false;
            else if (number % 2 == 0)
                return number == 2;

            long N = (long)(Math.Sqrt(number) + 0.5);

            for (int i = 3; i <= N; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
    }
}
