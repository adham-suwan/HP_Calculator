using HpCalculator.Middleware.Operations_Command;
using System;
using System.Collections.Generic;
using static HpCalculator.Middleware.Lookups;

namespace HpCalculator.Middleware.Result_Decorator
{
    public class ResultBuilder : IResultBuilder
    {
        public Dictionary<string, object> Build(Dictionary<string, object> arguments)
        {
            var dictionaryResult = new Dictionary<string, object>();
            var calculator = new Calculator((int)arguments["firstNumber"], (int)arguments["secondNumber"]);

            OperationCommand command = null;

            switch ((ACTION)arguments["operation"])
            {
                case ACTION.ADD:
                    command = new AddCommand(calculator);
                    break;
                case ACTION.MLT:
                    command = new MultiplyCommand(calculator);
                    break;
                case ACTION.DIV:
                    command = new DivisionCommand(calculator);
                    break;
                case ACTION.SUB:
                    command = new SubtractCommand(calculator);
                    break;
            }

            var calculationResult = command.Execute();
            dictionaryResult.Add(RESULT_ATTR.VALUE.ToString(), calculationResult);

            return dictionaryResult;

        }
    }
}