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
    }
}
