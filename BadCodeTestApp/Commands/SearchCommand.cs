using System;
using System.IO;
using System.Linq;

namespace BadCodeTestApp
{
    internal class SearchCommand : ICommandStrategy
    {
        public void execute(string path)
        {
            Directory.GetFiles(path, "*").ToList().ForEach(n => Console.WriteLine(n));
        }
    }
}