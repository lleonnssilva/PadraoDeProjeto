﻿namespace CommandState
{
    public interface IReceiver<in T, out O>
        where T : ICommand
        where O : IState
    {
        IState Action(T command);
    }
}
