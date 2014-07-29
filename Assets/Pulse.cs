using Loggery;
using UnityEngine;

public class Pulse : MonoBehaviour
{
    private const float Duration = 1.0f;
    private static readonly LoggeryLogger Logger = LoggeryManager.GetCurrentClassLogger();
    public Color Color0 = Color.red;
    public Color Color1 = Color.blue;

    private void Start()
    {
        Logger.Info("Start pulse script");
    }

    private void Update()
    {
        Logger.Trace("Adjusting color");
        float t = Mathf.PingPong(Time.time, Duration)/Duration;
        light.color = Color.Lerp(Color0, Color1, t);
    }
}