using System;
using System.Collections.Generic;
using System.Linq;
using ClaseObserver.Modelos;

namespace ClaseObserver.Observadores
{
    /// <summary>
    ///     Solo aplicable a clientes pospago (Normal Casa, Normal Edificio, Prepago Casa)
    /// </summary>
    public class ProgramacionHboGratis : IObserver<Cliente>
    {
        private readonly List<Cliente> _clientes = new List<Cliente>();
        private readonly IDisposable _unsubscriber;
        private Cliente _data;

        public ProgramacionHboGratis(IObservable<Cliente> provider)
        {
            _unsubscriber = provider.Subscribe(this);
        }

        public void OnNext(Cliente value)
        {
            if (value.TipoCliente.Equals(TipoCliente.NormalCasa) || 
                value.TipoCliente.Equals(TipoCliente.NormalEdificio) ||
                value.TipoCliente.Equals(TipoCliente.PrepagoCasa))
            {
                _data = value;
                _clientes.Add(_data);
                Display();
            }
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        private void Display()
        {
            Console.WriteLine($"Enviando programacion HBO al cliente {_data.Ibs} [{_data.Nombre}]");
        }

        public void RemoverSuscripcion()
        {
            _unsubscriber.Dispose();
            Console.WriteLine(
                $"Removiendo programacion HBO de los clientes {string.Join(",", _clientes.Select(s => s.Ibs).ToArray())}");
        }
    }
}