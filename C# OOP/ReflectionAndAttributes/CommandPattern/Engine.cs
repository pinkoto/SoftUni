using CommandPattern.Core.Contracts;
using System;

namespace CommandPattern
{
    internal class Engine : IEngine
    {
        private ICommandInterpreter commandInterpreter;

        public Engine(ICommandInterpreter commandInterpreter)
        {
            this.commandInterpreter = commandInterpreter;
        }

        public void Run()
        {
            while (true)
            {
                string cmd = Console.ReadLine();
                string result=commandInterpreter.Read(cmd);
                if (result==null)
                {
                    break;
                }
                Console.WriteLine(result);
            }
        }
    }
}