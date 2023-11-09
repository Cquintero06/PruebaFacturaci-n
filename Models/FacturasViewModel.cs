namespace FacturaciónTienda.Models
{
    public class FacturasViewModel
    {
        public List<string> RazonesSociales { get; set; }
        public List<CatProductosModel> Productos { get; set; }
        public List<TblFacturasModel> FacturasList { get; set; }
        public List<GuardarRequest> GuardarRequests { get; set; }
        public FacturasViewModel()
        {
            RazonesSociales = new List<string>();
            Productos = new List<CatProductosModel>();
            FacturasList = new List<TblFacturasModel>();
            GuardarRequests = new List<GuardarRequest>();
        }
    }
}
