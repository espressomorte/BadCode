using System;
using System.IO;

namespace BadCodeTestApp
{
    internal class CreateTxtCommand : ICommandStrategy
    {
        public void execute(string path)
        {
            File.Create(path + "\\test.txt");
        }
    }
}