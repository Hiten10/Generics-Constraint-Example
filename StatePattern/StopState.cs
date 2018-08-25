using System;

namespace StatePattern
{
    public class StopState : IState
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("Player is in stop state");
            context.SetState(this);
        }

        public string MyState()
        {
            return "Stop State";
        }
    }
}
