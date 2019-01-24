using System.Collections.Generic;
using static HpCalculator.Middleware.Lookups;

namespace HpCalculator.Middleware.Result_Decorator
{
    public class ResultWithPrime : ResultDecorator
    {
        private IResultBuilder _builder;
        public ResultWithPrime(IResultBuilder builder)
        {
            _builder = builder;
        }
        public override Dictionary<string, object> Build(Dictionary<string, object> arguments)
        {
            var resultDictionary = _builder.Build(arguments); //Initial build
            var resultValue = resultDictionary[RESULT_ATTR.VALUE.ToString()]; //Get the result value (basic info)

            resultDictionary.Add(RESULT_ATTR.PRIME.ToString(), ResultExtensionHelper.IsPrime(resultValue)); //Extend the result attributes (add more info)

            return resultDictionary;
        }
    }
}
