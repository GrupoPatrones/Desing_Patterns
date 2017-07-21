using System;
using System.Collections.Generic;
using System.Linq;
using ClaseObserver.Modelos;

namespace ClaseObserver.Observadores
{
    /// <summary>
    ///     Solo aplicable a clientes prepago (Prepago, Prepago Casa, Prepago Edificio)
    /// </summary>
    public class ProgramacionFoxGratis : IObserver<Cliente>
    {
        private readonly List<Cliente> _clientes = new List<Cliente>();
        private readonly IDisposable _unsubscriber;
        private Cliente _data;

        public ProgramacionFoxGratis(IObservable<Cliente> proveedor)
        {
            _unsubscriber = proveedor.Subscribe(this);
        }

        public void OnNext(Cliente value)
        {
            if (value.TipoCliente.Equals(TipoCliente.PrepagoEdificio) ||
                value.TipoCliente.Equals(TipoCliente.PrepagoCasa) || 
                value.TipoCliente.Equals(TipoCliente.Prepago))
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
            Console.WriteLine($"Enviando programacion FOX+ al cliente {_data.Ibs} [{_data.Nombre}]");
        }

        public void RemoverProgramacion()
        {
            _unsubscriber.Dispose();
            Console.WriteLine(
                $"Removiendo programacion FOX+ de los clientes {string.Join(",", _clientes.Select(s => s.Ibs).ToArray())}");
        }
    }
}