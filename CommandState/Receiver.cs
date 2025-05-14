namespace CommandState
{
    public class Receiver : IReceiver<Command, IState>
    {


        public IState Action(Command command)
        {
            command.Execute();
            return new State(200, "Comando executado com sucesso");
        }
    }
}
