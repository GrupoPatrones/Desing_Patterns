using System;

namespace SingletonImplement
{
    public class SingletonLazy
    {
        private static readonly Lazy<SingletonLazy> _mySingleton = new Lazy<SingletonLazy>(() => new SingletonLazy());

        public string mensaje { get; set; }

        private SingletonLazy()
        {
            Console.WriteLine("Nueva Instancia");
        }

        public static SingletonLazy Instance{
            get{
                return _mySingleton.Value;
            }
        }
    }
}
