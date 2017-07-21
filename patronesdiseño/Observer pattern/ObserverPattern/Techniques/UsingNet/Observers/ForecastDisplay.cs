using System;
using ObserverPattern.Model;

namespace ObserverPattern.Techniques.UsingNet.Observers
{
    /// <summary>
    ///     Observador: Realiza las predicciones del clima creado (clase observada)
    /// </summary>
    public class ForecastDisplay : IObserver<WeatherData>
    {
        private readonly IDisposable _unsubscriber;
        private WeatherData _data;

        /// <summary>
        ///     Constructor
        /// </summary>
        /// <param name="provider">clase observada</param>
        public ForecastDisplay(IObservable<WeatherData> provider)
        {
            _unsubscriber = provider.Subscribe(this);
        }

        /// <summary>
        ///     Accion tomada cuando la clase observada cumple el proceso de creacion de una nueva condicion del clima
        /// </summary>
        /// <param name="value"></param>
        public void OnNext(WeatherData value)
        {
            _data = value;
            Display();
        }

        /// <summary>
        ///     Ocurre cuando el proveedor ha experimentado una condición de error
        /// </summary>
        /// <param name="error">Excepcion proveida por el proveedor</param>
        public void OnError(Exception error)
        {
            Console.WriteLine("Some error has occurred..");
        }

        /// <summary>
        ///     Ocurre cuando el proveedor ha terminado de enviar las notificaciones
        /// </summary>
        public void OnCompleted()
        {
            Console.WriteLine("Forecast Conditions completed.");
        }

        /// <summary>
        ///     Metodo privado que muestra los resultados de la prediccion
        /// </summary>
        private void Display()
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
            _unsubscriber.Dispose();
            Console.WriteLine("Forecast Display removed");
        }
    }
}