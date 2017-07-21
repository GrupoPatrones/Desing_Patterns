using System;
using ObserverPattern.Model;
using ObserverPattern.Techniques.UsingPoo.Providers;

namespace ObserverPattern.Techniques.UsingPoo.Observers
{
    public class ForecastDisplay : ISubscriber, IDisposable
    {
        private readonly IPublisher _publisher;
        private WeatherData _data;
        /// <summary>
        /// Constructor que al ser indicado el publicador se registra al mismo
        /// </summary>
        /// <param name="publisher"></param>
        public ForecastDisplay( IPublisher publisher)
        {
            _publisher = publisher;
            _publisher.RegisterSubscriber(this);
        }
        /// <summary>
        ///     Metodo publico que desinscribe [Forecast Conditions] de la clase observada
        /// </summary>
        /// <remarks>
        ///     Nótese que ésta clase mantiene un metodo para desinscribirse (la clase CurrentConditionsDisplay no lo provee)
        /// </remarks>
        public void Dispose()
        {
            _publisher.RemoveSubscriber(this);
            Console.WriteLine("Forecast Display removed");
        }
        /// <summary>
        /// Metodo encargado de realizar la accion posterior a la notificacion del publicador
        /// </summary>
        /// <param name="data"></param>
        public void Update(WeatherData data)
        {
            _data = data;
            Display();
        }
        /// <summary>
        ///     Metodo privado que muestra los resultados de la prediccion
        /// </summary>
        private void Display()
        {
            Console.WriteLine(
                $"Forecast Conditions : Temp = {_data.Temperature + 6}Deg | Humidity = {_data.Humidity + 20}% | Pressure = {_data.Pressure - 3}bar");
        }
    }
}