using static HpCalculator.Middleware.Lookups;

namespace HpCalculator.Middleware.Operations_Command
{
    class AddCommand : OperationCommand
    {
        public AddCommand(ICalculator reciever)
            : base(reciever)
        {

        }
        public override int? Execute()
        {
            _calculator.SetAction(ACTION.ADD);
            return _calculator.GetResult();
        }
    }

    class SubtractCommand : OperationCommand
    {
        public SubtractCommand(ICalculator reciever)
            : base(reciever)
        {

        }
        public override int? Execute()
        {
            _calculator.SetAction(ACTION.SUB);
            return _calculator.GetResult();
        }
    }

    class MultiplyCommand : OperationCommand
    {
        public MultiplyCommand(ICalculator reciever)
            : base(reciever)
        {

        }
        public override int? Execute()
        {
            _calculator.SetAction(ACTION.MLT);
            return _calculator.GetResult();
        }
    }

    class DivisionCommand : OperationCommand
    {
        public DivisionCommand(ICalculator reciever)
            : base(reciever)
        {

        }
        public override int? Execute()
        {
            _calculator.SetAction(ACTION.DIV);
            return _calculator.GetResult();
        }
    }
}