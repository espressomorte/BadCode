using System;
using System.IO;
using System.Linq;

namespace BadCodeTestApp
{
    internal class CsSearchCommand : ICommandStrategy
    {
        public void execute(string path)
        {
            Directory.GetFiles(path, "*.cs").ToList().ForEach(n => Console.WriteLine(n));
        }
    }
}