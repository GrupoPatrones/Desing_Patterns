using System;
using System.Collections.Generic;
using System.Linq;
using ClaseObserver.Modelos;

namespace ClaseObserver.Observadores
{
    /// <summary>
    /// Solo aplicable a clientes de edificio (Prepago Edificio, Normal Edificio)
    /// </summary>
    public class ProgramacionHotPackGratis : IObserver<Cliente>
    {
        private Cliente _data;
        private readonly List<Cliente> _clientes = new List<Cliente>();
        private readonly IDisposable _unsubscriber;
        public ProgramacionHotPackGratis(IObservable<Cliente> proveedor)
        {
            _unsubscriber = proveedor.Subscribe(this);
        }
        public void OnNext(Cliente value)
        {
            if (value.TipoCliente.Equals(TipoCliente.PrepagoEdificio)
                || value.TipoCliente.Equals(TipoCliente.NormalEdificio))
            {
                _data = value;
                _clientes.Add(_data);
                Display();
            }
        }

        private void Display()
        {
            Console.WriteLine($"Enviando programacion HOT PACK al cliente {_data.Ibs} [{_data.Nombre}]");
        }
        public void RemoverSuscripcion()
        {
            _unsubscriber.Dispose();
            Console.WriteLine($"Removiendo programacion HOT PACK de los clientes {string.Join(",", _clientes.Select(s => s.Ibs).ToArray())}");
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }
    }
}
