namespace HpCalculator.Middleware.Operations_Command
{
    abstract class OperationCommand
    {
        protected ICalculator _calculator = null;

        public OperationCommand(ICalculator calculator)
        {
            _calculator = calculator;
        }

        public abstract int? Execute();
    }
}