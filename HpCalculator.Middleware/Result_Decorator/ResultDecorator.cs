using System.Collections.Generic;
using static HpCalculator.Middleware.Lookups;

namespace HpCalculator.Middleware.Result_Decorator
{
    public abstract class ResultDecorator : IResultBuilder
    {
        public abstract Dictionary<string, object> Build(Dictionary<string, object> arguments);
    }
}
