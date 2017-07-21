using System;
using ObserverPattern.Model;
using ObserverPattern.Techniques.UsingEventsAndDelegates.Providers;

namespace ObserverPattern.Techniques.UsingEventsAndDelegates.Observers
{
    public class CurrentConditionsDisplay
    {
        private readonly WeatherDataProvider _wDprovider;
        private WeatherData _data;
        /// <summary>
        /// Registra el evento de cambio de informacion
        /// </summary>
        /// <param name="provider"></param>
        public CurrentConditionsDisplay(WeatherDataProvider provider)
        {
            _wDprovider = provider;
            _wDprovider.RaiseWeatherDataChangedEvent += provider_RaiseWeatherDataChangedEvent;
        }
        /// <summary>
        /// Metodo encargado de realizar la accion posterior a la notificacion del publicador
        /// </summary>
        private void provider_RaiseWeatherDataChangedEvent(object sender, WeatherDataEventArgs e)
        {
            _data = e.Data;
            UpdateDisplay();
        }
        /// <summary>
        ///     Metodo privado que muestra las condiciones actuales del clima
        /// </summary>
        private void UpdateDisplay()
        {
            Console.WriteLine(
                $"Current Conditions : Temp = {_data.Temperature}Deg | Humidity = {_data.Humidity}% | Pressure = {_data.Pressure}bar");
        }
    }
}