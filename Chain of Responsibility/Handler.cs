using System;

namespace Chain_of_Responsibility
{
    public abstract class Handler
    {
        protected Handler _nextHandler;
        public void SetNextHandler(Handler handler)
        {
            _nextHandler = handler;
        }
        public virtual void HandlerRequest(int valueA, int valueB, EOperation eOperation)
        {
            Console.WriteLine("Chegou o fim");
        }
    }
}
