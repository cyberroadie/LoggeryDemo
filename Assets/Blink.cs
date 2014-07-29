using Loggery;
using UnityEngine;

public class Blink : MonoBehaviour
{
    public static readonly LoggeryLogger Logger = LoggeryManager.GetCurrentClassLogger();

    public void Start()
    {
        Logger.Info("Start blinking repeat 1");
        InvokeRepeating("Blinking", 1/25, 1.0f);
        Logger.Info("Start blinking repeat 2");
    }

    public void Blinking()
    {
        Logger.Debug("Blink");
        light.color = Color.Lerp(Color.white, Color.white, 10.0f);
    }
}