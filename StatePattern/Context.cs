﻿namespace StatePattern
{
    public class Context
    {
        IState _state;

        public Context()
        {
            _state = null;
        }
        public void SetState(IState state)
        {
            _state = state;
        }

        public IState GetState()
        {
            return _state;
        }
    }
}
