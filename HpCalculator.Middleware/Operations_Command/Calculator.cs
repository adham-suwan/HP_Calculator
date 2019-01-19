using static HpCalculator.Middleware.Lookups;

namespace HpCalculator.Middleware.Operations_Command
{
    class Calculator : ICalculator
    {
        int _x;
        int _y;

        ACTION currentAction;

        public Calculator(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public void SetAction(ACTION action)
        {
            currentAction = action;
        }

        public int? GetResult()
        {
            int? result = null;

            if (currentAction == ACTION.ADD)
            {
                result = _x + _y;

            }
            else if (currentAction == ACTION.MLT)
            {
                result = _x * _y;
            }
            else if (currentAction == ACTION.SUB)
            {
                result = _x - _y;
            }
            else if (currentAction == ACTION.DIV)
            {
                result = _x / _y;
            }
            return result;
        }

    }
}