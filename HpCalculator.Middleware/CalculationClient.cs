using HpCalculator.Middleware.Result_Decorator;
using System.Collections.Generic;
using static HpCalculator.Middleware.Lookups;

namespace HpCalculator.Middleware
{
    public static class CalculationClient
    {
        public static Dictionary<string, object> CalculateBasic(int x, int y, ACTION operation)
        {
            var arguments = new Dictionary<string, object>();
            arguments.Add("firstNumber", x);
            arguments.Add("secondNumber", y);
            arguments.Add("operation", operation);

            var resultBuilder = new ResultBuilder();

            return resultBuilder.Build(arguments);

        }

        public static Dictionary<string, object> CalculateWithColor(int x, int y, ACTION operation)
        {
            var arguments = new Dictionary<string, object>();
            arguments.Add("firstNumber", x);
            arguments.Add("secondNumber", y);
            arguments.Add("operation", operation);

            var resultBuilder = new ResultWithColor(new ResultBuilder());

            return resultBuilder.Build(arguments);

        }
    }
}
