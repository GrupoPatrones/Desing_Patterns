using System;
using ObserverPattern.Model;
using ObserverPattern.Techniques.UsingEventsAndDelegates.Providers;

namespace ObserverPattern.Techniques.UsingEventsAndDelegates.Observers
{
    public class ForecastDisplay
    {
        private readonly WeatherDataProvider _wDprovider;
        private WeatherData _data;
        /// <summary>
        /// Registra el evento de cambio de informacion
        /// </summary>
        /// <param name="provider"></param>
        public ForecastDisplay(WeatherDataProvider provider)
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
        ///     Metodo privado que muestra los resultados de la prediccion
        /// </summary>
        private void UpdateDisplay()
        {
            Console.WriteLine(
                $"Forecast Conditions : Temp = {_data.Temperature + 6}Deg | Humidity = {_data.Humidity + 20}% | Pressure = {_data.Pressure - 3}bar");
        }
        /// <summary>
        ///     Metodo publico que desinscribe [Forecast Conditions] de la clase observada
        /// </summary>
        /// <remarks>
        ///     Nótese que ésta clase mantiene un metodo para desinscribirse (la clase CurrentConditionsDisplay no lo provee)
        /// </remarks>
        public void Unsubscribe()
        {
            _wDprovider.RaiseWeatherDataChangedEvent -= provider_RaiseWeatherDataChangedEvent;
            Console.WriteLine("Forecast Display removed");
        }
    }
}