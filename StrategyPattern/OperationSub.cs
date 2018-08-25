namespace StrategyPattern
{
    class OperationSub : IStrategy
    {
        public int DoOperation(int a, int b)
        {
            return b - a;
        }
    }
}
