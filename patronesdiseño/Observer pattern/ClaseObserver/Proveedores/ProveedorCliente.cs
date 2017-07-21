using System;
using System.Collections.Generic;
using ClaseObserver.Modelos;

namespace ClaseObserver.Proveedores
{
    public class ProveedorCliente : IObservable<Cliente>
    {
        private readonly IList<IObserver<Cliente>> _observadores = new List<IObserver<Cliente>>();
        public IDisposable Subscribe(IObserver<Cliente> observer)
        {
            _observadores.Add(observer);
            return new UnSubscriber<Cliente>(_observadores, observer);
        }

        public void RegistrarCliente(int ibs, string nombre, TipoCliente tipoCliente)
        {
            var cliente = new Cliente() {Ibs = ibs, Nombre = nombre, TipoCliente = tipoCliente};
            NotificarObservadores(cliente);
        }

        private void NotificarObservadores(Cliente cliente)
        {
            foreach (var obs in _observadores)
            {
                obs.OnNext(cliente);
            }
        }
    }
    internal class UnSubscriber<T> : IDisposable
    {
        private readonly IObserver<T> _observer;
        private readonly IList<IObserver<T>> _observers;

        public UnSubscriber(IList<IObserver<T>> observers, IObserver<T> observer)
        {
            _observers = observers;
            _observer = observer;
        }

        public void Dispose()
        {
            if (_observer != null)
            {
                _observers.Remove(_observer);
            }
        }
    }
}
