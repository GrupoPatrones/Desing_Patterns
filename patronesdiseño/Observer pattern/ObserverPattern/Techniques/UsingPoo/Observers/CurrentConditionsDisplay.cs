using System;
using ObserverPattern.Model;
using ObserverPattern.Techniques.UsingPoo.Providers;

namespace ObserverPattern.Techniques.UsingPoo.Observers
{
    public class CurrentConditionsDisplay : ISubscriber
    {
        private WeatherData _data;
        /// <summary>
        /// Constructor que al ser indicado el publicador se registra al mismo
        /// </summary>
        /// <param name="publisher"></param>
        public CurrentConditionsDisplay(IPublisher publisher)
        {
            publisher.RegisterSubscriber(this);
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
        ///     Metodo privado que muestra las condiciones actuales del clima
        /// </summary>
        private void Display()
        {
            Console.WriteLine(
                $"Current Conditions : Temp = {_data.Temperature}Deg | Humidity = {_data.Humidity}% | Pressure = {_data.Pressure}bar");
        }
    }
}