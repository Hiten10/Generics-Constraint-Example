using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context(new OperationAdd());
            Console.WriteLine(context.ExecuteStratey(5, 4));

            context = new Context(new OperationSub());
            Console.WriteLine(context.ExecuteStratey(10, 19));

            context = new Context(new OperationMultiply());
            Console.WriteLine(context.ExecuteStratey(15, 12));
        }

    }
}
