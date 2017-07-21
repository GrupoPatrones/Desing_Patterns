using System;
using ObserverPattern.Model;

namespace ObserverPattern.Techniques.UsingEventsAndDelegates.Providers
{
    /// <summary>
    ///     Subject
    /// </summary>
    public class WeatherDataProvider : IDisposable
    {
        /// <summary>
        /// Metodo que libera los eventos que han realizado attach
        /// </summary>
        public void Dispose()
        {
            if (RaiseWeatherDataChangedEvent != null)
            {
                foreach (EventHandler<WeatherDataEventArgs> item in RaiseWeatherDataChangedEvent.GetInvocationList())
                {
                    RaiseWeatherDataChangedEvent -= item;
                }
            }
        }

        /// <summary>
        ///     Metodo expuesto que permite registrar las medidas del clima
        ///     Dispara el evento <see cref="WeatherDataEventArgs" />
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
            OnRaiseWeatherDataChangedEvent(new WeatherDataEventArgs(new WeatherData(temp, humid, pres)));
        }
        /// <summary>
        /// EventHandler para el <see cref="WeatherDataEventArgs" />
        /// </summary>
        public event EventHandler<WeatherDataEventArgs> RaiseWeatherDataChangedEvent;
        /// <summary>
        /// Metodo encargado de realizar el llamado del evento
        /// </summary>
        /// <param name="e">Evento</param>
        protected virtual void OnRaiseWeatherDataChangedEvent(WeatherDataEventArgs e)
        {
            var handler = RaiseWeatherDataChangedEvent;
            handler?.Invoke(this, e);
        }
    }
}