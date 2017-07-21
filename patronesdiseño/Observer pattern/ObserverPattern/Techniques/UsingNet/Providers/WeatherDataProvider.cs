using System;
using System.Collections.Generic;
using ObserverPattern.Model;

namespace ObserverPattern.Techniques.UsingNet.Providers
{
    /// <summary>
    ///     Subject
    /// </summary>
    public class WeatherDataProvider : IObservable<WeatherData>
    {
        /// <summary>
        ///     Variable para almacenar todos los observadores que se han registrado/suscrito
        /// </summary>
        private readonly IList<IObserver<WeatherData>> _observers = new List<IObserver<WeatherData>>();

        /// <summary>
        ///     Metodo expuesto que permite registrar/suscribir un observador
        /// </summary>
        /// <param name="observer">Observador</param>
        /// <returns></returns>
        public IDisposable Subscribe(IObserver<WeatherData> observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }
            return new UnSubscriber<WeatherData>(_observers, observer);
        }

        /// <summary>
        ///     Metodo privado que se encarga de crear la clase de trabajo y notificar su creacion
        ///     a los observadores
        /// </summary>
        /// <param name="temp">Temperatura</param>
        /// <param name="humid">Humedad</param>
        /// <param name="pres">Presión</param>
        private void MeasurementsChanged(float temp, float humid, float pres)
        {
            foreach (var obs in _observers)
            {
                obs.OnNext(new WeatherData(temp, humid, pres));
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
            MeasurementsChanged(temp, humid, pres);
        }
    }
}