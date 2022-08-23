using System;

namespace Chain_of_Responsibility
{
    public class CalculatorHandler : Handler
    {
        public override void HandlerRequest(int valueA, int valueB, EOperation eOperation)
        {
            if(_nextHandler != null)
            {
                _nextHandler.HandlerRequest(valueA, valueB, eOperation);
            }
            else
            {
                base.HandlerRequest(valueA, valueB,eOperation);
            }
        }
    }
}
