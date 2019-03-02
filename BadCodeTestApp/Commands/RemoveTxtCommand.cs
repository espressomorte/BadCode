using System;
using System.IO;

namespace BadCodeTestApp
{
    internal class RemoveTxtCommand : ICommandStrategy
    {
        public void execute(string path)
        {
            File.Delete(path + "\\test.txt");
        }
    }
}