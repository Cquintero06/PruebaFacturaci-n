using System.Drawing;

namespace FacturaciónTienda.Models
{
    public class CatProductosModel
    {
        public int Id { get; set; }
        public string NombreProducto { get; set; }
        public byte[] ImagenProducto { get; set; }
        public decimal PrecioUnitario { get; set; }
        public string ext { get; set; }

        public Image kaisck { get; set; }

        public CatProductosModel() 
        { 
            Id = 0;
            NombreProducto = string.Empty;
            ImagenProducto = null;
            PrecioUnitario = 0;
            ext = string.Empty;
        }

    }
}
