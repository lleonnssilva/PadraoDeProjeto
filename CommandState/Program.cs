using CommandState;

var commandState = (State)new Receiver().Action(new Command(1,"Comando 1"));
Console.WriteLine($"{commandState.StatusCode} - {commandState.Message}");