using log4net;

namespace BadCodeTestApp
{
    public static class Logger
    {
        private static readonly ILog log = LogManager.GetLogger("LOGGER");

        public static ILog Log
        {
            get { return log; }
        }
    }
}