using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BadCodeTestApp
{
    internal class Commandore
    {
        ICommandStrategy strategy;
        private static Dictionary<string, ICommandStrategy> strategies = new Dictionary<string, ICommandStrategy>();

    static Commandore()
        {
            strategies.Add("search", new SearchCommand());
            strategies.Add("cs_search", new CsSearchCommand());
            strategies.Add("create_txt", new CreateTxtCommand());
            strategies.Add("remove_txt", new RemoveTxtCommand());
    }

        public ICommandStrategy getStrategy(string command)
    {
            try
            {
                strategy = strategies[command];
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("Error: Given command is not supported.");
            }
            return strategy;
        }

}
}