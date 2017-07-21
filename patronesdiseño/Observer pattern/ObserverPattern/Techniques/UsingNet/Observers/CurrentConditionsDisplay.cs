using System;
using ObserverPattern.Model;

namespace ObserverPattern.Techniques.UsingNet.Observers
{
    /// <summary>
    ///     Observador: Realiza las condiciones actuales del clima creado (clase observada)
    /// </summary>
    public class CurrentConditionsDisplay : IObserver<WeatherData>
    {
        private WeatherData _data;
        private IDisposable _unsubscriber;

        /// <summary>
        ///     Constructor
        /// </summary>
        /// <param name="provider">clase observada</param>
        public CurrentConditionsDisplay(IObservable<WeatherData> provider)
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
            Console.WriteLine("Current Conditions completed.");
        }

        /// <summary>
        ///     Metodo privado que muestra las condiciones actuales del clima
        /// </summary>
        private void Display()
        {
            Console.WriteLine(
                $"Current Conditions : Temp = {_data.Temperature}Deg | Humidity = {_data.Humidity}% | Pressure = {_data.Pressure}bar");
        }
    }
}