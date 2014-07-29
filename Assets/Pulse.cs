using Loggery;
using UnityEngine;

namespace Assets
{
    public class Pulse : MonoBehaviour
    {
        private const float Duration = 1.0f;
        private static readonly LoggeryLogger Logger = LoggeryManager.GetCurrentClassLogger();
        public Color Color0 = Color.red;
        public Color Color1 = Color.blue;
        private double ping = 0;

        private void Start()
        {
            Logger.Info("Start pulse script");
            InvokeRepeating("PingMessage", 1, 1);
        }

        private void Update()
        {
            Logger.Trace("Adjusting color");
            float t = Mathf.PingPong(Time.time, Duration)/Duration;
            light.color = Color.Lerp(Color0, Color1, t);
        }

        public void PingMessage()
        {
            ping++;
            Logger.Trace("Ping set to " + ping);
        
        }
    }
}