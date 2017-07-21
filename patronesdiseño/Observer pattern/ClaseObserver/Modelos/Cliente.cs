namespace ClaseObserver.Modelos
{
    public class Cliente
    {
        public int Ibs { get; set; }
        public string Nombre { get; set; }
        public TipoCliente TipoCliente { get; set; }
        /*6: - PRE-Casa | 7 - PRE- Edificio | 8 - Prepago | 3- Normal Casa | 21 - Normal Edificio*/
    }

    public enum TipoCliente
    {
        PrepagoCasa = 6,
        PrepagoEdificio = 7,
        Prepago = 8,
        NormalCasa = 3,
        NormalEdificio = 21
    }
}