namespace SingletonImplement
{
    public sealed class SingletonSt
    {
        private static readonly SingletonSt _instancia = new SingletonSt();
        public string Mensaje { get; private set; }

        private SingletonSt()
        {
            Mensaje = "Se inicializa desde el constructor privado.";
        }

        public static SingletonSt Instancia {
            get{
                return _instancia;
            }
        }
    }
}
