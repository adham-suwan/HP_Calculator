using System.Collections.Generic;
using static HpCalculator.Middleware.Lookups;

namespace HpCalculator.Middleware.Result_Decorator
{
    public interface IResultBuilder
    {
        Dictionary<string, object> Build(Dictionary<string, object> arguments);
    }
}
