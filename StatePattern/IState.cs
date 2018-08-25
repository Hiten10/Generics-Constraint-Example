namespace StatePattern
{
    public interface IState
    {
        void DoAction(Context context);
        string MyState();
    }
}
