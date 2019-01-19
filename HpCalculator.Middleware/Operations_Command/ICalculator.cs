using static HpCalculator.Middleware.Lookups;

namespace HpCalculator.Middleware.Operations_Command
{
    interface ICalculator
    {
        void SetAction(ACTION action);
        int? GetResult();
    }
}
