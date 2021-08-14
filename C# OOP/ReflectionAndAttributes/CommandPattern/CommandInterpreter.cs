using CommandPattern.Core.Contracts;
using System;
using System.Linq;
using System.Reflection;

namespace CommandPattern
{
    internal class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            string[] tokens = args.Split();
            string cmdName = tokens[0];
            var cmdArgs = tokens[1..];

            Type cmdType = Assembly
                .GetCallingAssembly()
                .GetTypes()
                .FirstOrDefault(x => x.Name == $"{cmdName}Command");

            ICommand command = (ICommand)Activator.CreateInstance(cmdType);
            string result = command.Execute(cmdArgs);

            return result;
        }
    }
}