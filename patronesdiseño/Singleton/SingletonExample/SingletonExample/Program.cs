using SingletonImplement;
using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var instanciasingleb = SingletonB.Instancia;
            //var instanciasinglest = SingletonSt.Instancia;

            //Console.WriteLine("Antes de llamar al método:");
            //Console.WriteLine();
            //Console.WriteLine($"Mensaje Singleton B: {instanciasingleb.Mensaje}");
            //Console.WriteLine($"Mensaje Singleton Static: {instanciasinglest.Mensaje}");
            //Console.ReadLine();

            //CallSingleton();

            //Console.WriteLine("Después de llamar al método:");
            //Console.WriteLine();
            //Console.WriteLine($"Mensaje Singleton B: {instanciasingleb.Mensaje}");
            //Console.WriteLine($"Mensaje Singleton Static: {instanciasinglest.Mensaje}");
            //Console.ReadLine();

            //Console.WriteLine("Before start thread");

            MultiThreadingEx();

            Console.ReadLine();
        }

        private static void CallSingleton()
        {
           
            var instanciasingleb = SingletonB.Instancia;

            instanciasingleb.Mensaje = "Este es el Singleton B.";
        }

        private static void MultiThreadingEx()
        {
            

            Thread t1 = new Thread(
                new ThreadStart(() =>
                {
                    
                    for (int i = 0; i < 3; i++)
                    {
                        SingletonA.GetInstance();
                        Console.WriteLine("H1: " + SingletonA.Mensaje);
                        //Thread.Sleep(1000);
                        var instanciasinglemth1 = SingletonLazy.Instance;
                        //Console.WriteLine("H1: " + SingletonLazy.Mensaje);
                        //Thread.Sleep(1000);
                    }
                }));

            Thread t2 = new Thread(
                new ThreadStart(() =>
                {
                    for (int i = 0; i < 3; i++)
                    {
                        SingletonA.GetInstance();
                        Console.WriteLine("H2: " + SingletonA.Mensaje);
                        //Thread.Sleep(1000);
                        var instanciasinglemth1 = SingletonLazy.Instance;
                        //Console.WriteLine("H2: " + SingletonLazy.Mensaje);
                       // Thread.Sleep(1000);
                    }
                }));

            t1.Start();
            t2.Start();
        }
    }
}
