using System;
using System.Collections.Generic;

namespace ObserverPattern.Techniques.UsingNet
{
    /// <summary>
    ///     Clase generica que implementa IDisposable <see cref="IDisposable" />
    ///     debido a que cada subject [WeatherDataProvider] en su método [Subscribe] (proveido IObservable)
    ///     debe devolver on objeto de tipo IDisposable
    ///     Basicamente, esta clase, remueve de la lista de observadores (pasado como parametro del constructor)
    ///     un observador (igualmente pasado como parametro en el cosntructor)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class UnSubscriber<T> : IDisposable
    {
        private readonly IObserver<T> _observer;
        private readonly IList<IObserver<T>> _observers;

        public UnSubscriber(IList<IObserver<T>> observers, IObserver<T> observer)
        {
            _observers = observers;
            _observer = observer;
        }

        /// <summary>
        ///     Remueve de la lista de observadores el observador indicado
        /// </summary>
        public void Dispose()
        {
            if (_observer != null)
            {
                _observers.Remove(_observer);
            }
        }
    }
}