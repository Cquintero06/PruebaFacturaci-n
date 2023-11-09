namespace FacturaciónTienda.Models
{
    public class TblDetallesFacturaModel
    {
        public int Id { get; set; }
        public int IdFactura { get; set; }
        public int IdProducto { get; set; }
        public int CantidadDeProducto { get; set; }
        public decimal PrecioUnitarioProducto { get; set; }
        public decimal SubtotalProducto { get; set; }
        public string Notas { get; set; }

        public TblDetallesFacturaModel() 
        {
            Id = 0;
            IdFactura = 0;
            IdProducto = 0;
            CantidadDeProducto = 0;
            PrecioUnitarioProducto = 0;
            SubtotalProducto = 0;
            Notas = string.Empty;
        }
    }
}
