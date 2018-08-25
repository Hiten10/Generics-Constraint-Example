namespace StrategyPattern
{
    public class Context
    {
        IStrategy _strategy;
        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public int ExecuteStratey(int x, int y)
        {
            return _strategy.DoOperation(x, y);
        }
    }
}
