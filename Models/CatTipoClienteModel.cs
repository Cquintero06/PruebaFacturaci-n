namespace FacturaciónTienda.Models
{
    public class CatTipoClienteModel
    {
        public int ID { get; set; }
        public string TipoCliente { get; set; }

        public CatTipoClienteModel()
        {
            ID = 0;
            TipoCliente = string.Empty;
        }
    }
}
