using Loggery;

namespace Assets
{
    class DeeperObject
    {
        public static readonly LoggeryLogger Logger = LoggeryManager.GetCurrentClassLogger();

        public string GetMeSomethingDeeper()
        {
            Logger.Debug("returning something deeper");    
            return "deeper";
        } 

    }
}
