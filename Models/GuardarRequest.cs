namespace FacturaciónTienda.Models
{
    public class GuardarRequest
    {
        public string RazonSocial { get; set; }
        public int NumeroFactura { get; set; }
        public decimal SubTotalFactura { get; set; }
        public decimal TotalImpuesto { get; set; }
        public decimal TotalFactura { get; set; }
        public int CantidadDeProducto { get; set; }
        public decimal SubtotalProducto { get; set; }
        public string NombreProducto { get; set; }
        public byte[] ImagenProducto { get; set; }
        public decimal PrecioUnitario { get; set; }
    }
}
