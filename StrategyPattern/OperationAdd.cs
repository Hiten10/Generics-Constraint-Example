namespace StrategyPattern
{
    class OperationAdd : IStrategy
    {
        public int DoOperation(int a, int b)
        {
            return a + b;
        }
    }
}
