using Assets;
using Loggery;
using UnityEngine;

public class Blink : MonoBehaviour
{
    public static readonly LoggeryLogger Logger = LoggeryManager.GetCurrentClassLogger();
    private readonly DeepObject _deep = new DeepObject();

    public void Start()
    {
        Logger.Info("Start blinking repeat 1");
        InvokeRepeating("Blinking", 1/25, 1.0f);
        Logger.Info("Start blinking repeat 2");
    }

    public void Blinking()
    {
        Logger.Debug("Blink");
        GetColor();
        var blah = _deep.GetMeSomethingDeep();
        Logger.Debug("Got something deeper: " + blah);
    }

    private void GetColor()
    {
        Logger.Debug("Getting color");
        light.color = Color.Lerp(Color.white, Color.white, 10.0f);
        var blah = _deep.GetMeSomething();
        Logger.Debug("Got something " + blah);
    }
}