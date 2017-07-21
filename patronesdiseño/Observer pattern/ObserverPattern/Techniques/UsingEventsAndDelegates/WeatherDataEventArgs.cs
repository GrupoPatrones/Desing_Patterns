using System;
using ObserverPattern.Model;

namespace ObserverPattern.Techniques.UsingEventsAndDelegates
{
    /// <summary>
    /// EventArgs de <see cref="WeatherData"/>
    /// </summary>
    public class WeatherDataEventArgs : EventArgs
    {
        public WeatherDataEventArgs(WeatherData data)
        {
            Data = data;
        }

        public WeatherData Data { get; private set; }
    }
}