namespace SingletonImplement
{
    public class SingletonB
    {
        private static SingletonB _instancia;
        public string Mensaje { get; set; }

        private SingletonB()
        {}

        public static SingletonB Instancia {
            get{
                if (_instancia == null)
                    _instancia = new SingletonB();
                return _instancia;
            }
        }
    }
}
