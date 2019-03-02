using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BadCodeTestApp
{
    internal class Commandore
    {
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
            return strategies[command];
    }

}
}