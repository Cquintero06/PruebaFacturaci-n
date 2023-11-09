namespace FacturaciónTienda.Models
{
    public class TblClientesModel
    {
        public int id { get; set; }
        public string RazonSocial { get; set; }
        public int IdTipoCliente { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string RFC { get; set; }

        public TblClientesModel()
        {
            id = 0;
            RazonSocial = string.Empty;
            IdTipoCliente = 0;
            FechaCreacion = DateTime.MinValue;
            RFC = string.Empty;
        }
    }
}
