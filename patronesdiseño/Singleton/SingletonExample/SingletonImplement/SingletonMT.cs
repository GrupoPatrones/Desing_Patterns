namespace SingletonImplement
{
    public class SingletonMt
    {
        private static volatile SingletonMt _instancia;
        private static object syncRoot = new object();
        public static string Mensaje { get; set; }

        private SingletonMt()
        { }

        public static SingletonMt Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    lock (syncRoot)
                    {
                        if (_instancia == null)
                        {
                            
                            _instancia = new SingletonMt();
                            Mensaje = $"Se crea una instancia de SingletonMT {_instancia.GetType().Name}";
                        }
                        else
                            Mensaje = string.Empty;
                    }
                }
                else
                    Mensaje = string.Empty;

                return _instancia;
            }
        }
    }
}
