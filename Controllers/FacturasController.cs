using Microsoft.AspNetCore.Mvc;
using FacturaciónTienda.Models;
using FacturaciónTienda.Data;

namespace FacturaciónTienda.Controllers
{
    public class FacturasController : Controller
    {
        private readonly FacturasRepository _facturasRepository;
        public FacturasController(FacturasRepository facturasRepository)
        {
            _facturasRepository = facturasRepository;
        }

        public IActionResult Index()
        {
            List<string> razonesSociales = _facturasRepository.ObtenerRazonesSociales();
            List<CatProductosModel> productos = _facturasRepository.ObtenerProductos();

            var viewModel = new FacturasViewModel
            {
                RazonesSociales = razonesSociales,
                Productos = productos
            };

            return View(viewModel);
        }

        public IActionResult BusquedaFactura()
        {
            var viewModel = new FacturasViewModel
            {
                RazonesSociales = _facturasRepository.ObtenerRazonesSociales(),
                Productos = _facturasRepository.ObtenerProductos(),
                FacturasList = new List<TblFacturasModel>()
            };

            return View(viewModel);
        }

        [HttpGet]
        public IActionResult BusquedaFacturaPost(string tipoBusqueda, string criterio)
        {
            List<TblFacturasModel> facturasList = _facturasRepository.Busqueda(tipoBusqueda, criterio);

            return Json(facturasList);
        }

        //[HttpPost]
        //public IActionResult GuardarFactura(FacturasViewModel viewModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        bool exito = _facturasRepository.GuardarFactura(viewModel);

        //        if (exito)
        //        {
        //            // Redirigir a la página de éxito u otra página
        //            return RedirectToAction("Exito");
        //        }
        //        else
        //        {
        //            ModelState.AddModelError(string.Empty, "Error al guardar la factura en la base de datos.");
        //        }
        //    }

        //    return View("Index", viewModel);
        //}
    }
}
