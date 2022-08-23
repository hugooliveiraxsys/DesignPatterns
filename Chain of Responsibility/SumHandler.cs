using System;

namespace Chain_of_Responsibility
{
    public class SumHandler : Handler
    {
        public override void HandlerRequest(int valueA, int valueB, EOperation eOperation)
        {
            if (EOperation.Sum.Equals(eOperation))
            {
                Console.WriteLine(valueA + valueB);
            }
            if (_nextHandler != null)
            {
                _nextHandler.HandlerRequest(valueA, valueB, eOperation);
            }
            else
            {
                base.HandlerRequest(valueA, valueB, eOperation);
            }
        }
    }
}
