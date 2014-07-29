using Loggery;

namespace Assets
{
    class DeepObject
    {
        public static readonly LoggeryLogger Logger = LoggeryManager.GetCurrentClassLogger();
        private readonly DeeperObject _deeper = new DeeperObject();

        public string GetMeSomething()
        {
            return "something";
        }

        public string GetMeSomethingDeep()
        {
            Logger.Debug("Getting something from deeper");
            return _deeper.GetMeSomethingDeeper();
        }

    }
}
