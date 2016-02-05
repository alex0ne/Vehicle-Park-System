namespace VehicleParkSystem.Core
{
    using System;

    class Engine :IEngine
    {
        private CommandExecutor ex;
        Engine (CommandExecutor ex)
        {
            this.ex = ex;
        }

        public Engine(): this(new CommandExecutor())
        {
        }

        public void Run()
        {
            while (true)
            {
                string commandLine = Console.ReadLine();

                if (commandLine == null) break;

                commandLine.Trim();

                if (string.IsNullOrEmpty(commandLine))

                try
                {
                    var comando = new CommandExecutor.Comando(commandLine);
                    string commandResult = ex.execução(comando);
                    Console.WriteLine(commandResult);
                }

                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}