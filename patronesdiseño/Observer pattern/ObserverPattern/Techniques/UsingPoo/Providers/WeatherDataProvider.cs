using System.Collections.Generic;
using ObserverPattern.Model;
using ObserverPattern.Techniques.UsingPoo.Observers;

namespace ObserverPattern.Techniques.UsingPoo.Providers
{
    /// <summary>
    ///     Subject
    /// </summary>
    public class WeatherDataProvider : IPublisher
    {
        private readonly IList<ISubscriber> _subscribers = new List<ISubscriber>();
        private WeatherData _data;
        /// <summary>
        ///     Metodo expuesto que permite registrar/suscribir un observador
        /// </summary>
        /// <param name="subscriber">Observador</param>
        /// <returns></returns>
        public void RegisterSubscriber(ISubscriber subscriber)
        {
            _subscribers.Add(subscriber);
        }
        /// <summary>
        ///     Metodo expuesto que permite desinscribir un observador
        /// </summary>
        /// <param name="subscriber">Observador</param>
        /// <returns></returns>
        public void RemoveSubscriber(ISubscriber subscriber)
        {
            if (_subscribers.Contains(subscriber))
                _subscribers.Remove(subscriber);
        }
        /// <summary>
        /// Metodo privado que se encarga de notificar a los observadores
        /// </summary>
        private void NotifySubscribers()
        {
            foreach (var subscriber in _subscribers)
            {
                subscriber.Update(_data);
            }
        }
        /// <summary>
        ///     Metodo expuesto que permite registrar las medidas del clima
        /// </summary>
        /// <param name="temp">Temperatura</param>
        /// <param name="humid">Humedad</param>
        /// <param name="pres">Presión</param>
        /// <remarks>
        ///     Nótese que en ningún momento ponemos como parámetro la clase WeatherData,
        ///     ésto para no generar dependencia con clases de trabajo
        ///     Es la D de SOLID: Las clases de alto nivel no deberían depender de las clases de bajo nivel. Ambas deberían
        ///     depender de las abstracciones
        ///     (Depender de abstracciones, no depender de implementaciones)
        /// </remarks>
        public void SetMeasurements(float temp, float humid, float pres)
        {
            _data = new WeatherData(temp, humid, pres);
            NotifySubscribers();
        }
    }
}