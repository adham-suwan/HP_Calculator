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

            var result = new ResultBuilder();

            return result.Build(arguments);

        }

        public static Dictionary<string, object> CalculateWithColor(int x, int y, ACTION operation)
        {
            var arguments = new Dictionary<string, object>();
            arguments.Add("firstNumber", x);
            arguments.Add("secondNumber", y);
            arguments.Add("operation", operation);

            var basicResult = new ResultBuilder();
            var colorAddedResult = new ResultWithColor(basicResult);

            return colorAddedResult.Build(arguments);

        }


        public static Dictionary<string, object> CalculateWithPrime(int x, int y, ACTION operation)
        {
            var arguments = new Dictionary<string, object>();
            arguments.Add("firstNumber", x);
            arguments.Add("secondNumber", y);
            arguments.Add("operation", operation);

            var basicResult = new ResultBuilder();
            var primeAddedResult = new ResultWithPrime(basicResult);

            return primeAddedResult.Build(arguments);

        }

        public static Dictionary<string, object> CalculateWithColorAndPrime(int x, int y, ACTION operation)
        {
            var arguments = new Dictionary<string, object>();
            arguments.Add("firstNumber", x);
            arguments.Add("secondNumber", y);
            arguments.Add("operation", operation);

            var basicResult = new ResultBuilder();
            var colorAddedResult = new ResultWithColor(basicResult);
            var primeAddedResult = new ResultWithPrime(colorAddedResult);



            return primeAddedResult.Build(arguments);

        }
    }
}
