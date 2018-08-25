namespace StrategyPattern
{
    class OperationMultiply : IStrategy
    {
        public int DoOperation(int a, int b)
        {
            return a * b;
        }
    }
}
