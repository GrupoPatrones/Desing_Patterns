namespace SingletonImplement
{
    public class SingletonA
    {
        private static SingletonA _instancia;
        public static string Mensaje { get; set; }

        private SingletonA()
        {
            
        }

        public static SingletonA GetInstance()
        {
            if (_instancia == null)
            {
                _instancia = new SingletonA();
                Mensaje = "Se ha creado una instancia de SA.";
            }
            else
                Mensaje = string.Empty;
            return _instancia;
        }
    }
}
