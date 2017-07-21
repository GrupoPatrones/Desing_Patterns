using System;
using ClaseObserver.Modelos;
using ClaseObserver.Observadores;
using ClaseObserver.Proveedores;

namespace ClaseObserver
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var proveedor = new ProveedorCliente();
            var fox = new ProgramacionFoxGratis(proveedor);
            var hbo = new ProgramacionHboGratis(proveedor);
            var hotpack = new ProgramacionHotPackGratis(proveedor);

            proveedor.RegistrarCliente(63641509, "JOAN MANUEL RESTREPO ALARCON", TipoCliente.Prepago);
            Console.WriteLine();
            proveedor.RegistrarCliente(91090660, "PEPITO PEREZ PAEZ", TipoCliente.PrepagoCasa);
            Console.WriteLine();
            proveedor.RegistrarCliente(91332661, "LUIS CASALLAS", TipoCliente.NormalCasa);
            Console.WriteLine();
            proveedor.RegistrarCliente(91993775, "ANA VICTORIA MORA LOPEZ", TipoCliente.NormalEdificio);
            Console.WriteLine();
            proveedor.RegistrarCliente(91993777, "ANA MARIA MORA LOPEZ", TipoCliente.PrepagoEdificio);
            fox.RemoverProgramacion();
            Console.WriteLine();
            proveedor.RegistrarCliente(91993778, "ANA MARIA LINARES", TipoCliente.PrepagoEdificio);
            Console.WriteLine();
        }
    }
}