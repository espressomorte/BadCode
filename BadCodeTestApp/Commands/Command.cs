namespace BadCodeTestApp
{
    class Command
    {
        public void Execute(ICommandStrategy strategy, string path)
        {
            strategy.execute(path);
        }
    }
}