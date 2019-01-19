using System.Collections.Generic;
using static HpCalculator.Middleware.Lookups;

namespace HpCalculator.Middleware.Result_Decorator
{
    public class ResultWithColor : ResultDecorator
    {
        private IResultBuilder _builder;
        public ResultWithColor(IResultBuilder builder)
        {
            _builder = builder;
        }
        public override Dictionary<string, object> Build(Dictionary<string, object> arguments)
        {
            var resultDictionary = _builder.Build(arguments); //Initial build
            var resultValue = resultDictionary[RESULT_ATTR.VALUE.ToString()]; //Get the result value (basic info)

            resultDictionary.Add(RESULT_ATTR.COLOR.ToString(), ResultExtensionHelper.GetColor(resultValue)); //Extend the result attributes (add more info)

            return resultDictionary;
        }
    }
}
