using System;
using System.IO;


namespace BadCodeTestApp
{
    class Command
    {
        public void Execute(ICommandStrategy strategy, string path)
        {
            try
            {
                strategy.execute(path);
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Error: The directory specified could not be found.");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Error: The argument cannot be null or empty.");
            }

        }
    }
}