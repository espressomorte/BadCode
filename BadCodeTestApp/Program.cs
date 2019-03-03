using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadCodeTestApp
{
    class Program
    {

        static void Main(string[] args)
        {
            Logger.Log.Info("Programm started");
            string command = args[0];
            string workingDirectory = args[1];
            Commandore strategy = new Commandore();
            Command operation = new Command();

            operation.Execute(strategy.getStrategy(command), workingDirectory);

            Console.ReadLine();
        }
    }
}
