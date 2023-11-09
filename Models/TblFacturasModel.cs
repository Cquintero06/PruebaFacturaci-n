namespace FacturaciónTienda.Models
{
    public class TblFacturasModel
    {
        public int Id { get; set; }
        public DateTime FechaEmisionFactura { get; set; }
        public int IdCliente { get; set; }
        public int NumeroFactura { get; set; }
        public int NumeroTotalArticulos { get; set; }
        public decimal SubTotalFactura { get; set; }
        public decimal TotalImpuesto { get; set; }
        public decimal TotalFactura { get; set; }

        public TblFacturasModel()
        {
            Id = 0;
            FechaEmisionFactura = DateTime.MinValue;
            IdCliente = 0;
            NumeroFactura = 0;
            NumeroTotalArticulos = 0;
            SubTotalFactura = 0;
            TotalImpuesto = 0;
            TotalFactura = 0;
        }
    }
}
