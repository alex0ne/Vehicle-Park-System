﻿namespace VehicleParkSystem2
{
    using System;
    using Comandos;

    class Mecanismo :IMecanismo
    {
        private CommandExecutor ex;
        Mecanismo (CommandExecutor ex)
        {
            this.ex = ex;
        }

        public Mecanismo(): this(new CommandExecutor())
        {
        }

        public void Runrunrunrunrun()
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