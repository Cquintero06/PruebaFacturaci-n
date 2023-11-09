// Selecciona producto y precio unitario y imagen se llenan automaticamente
document.addEventListener("DOMContentLoaded", function () {
    var nombreProductoSelect = document.getElementById("NombreProducto");
    var precioUnitarioSpan = document.getElementById("PrecioUnitario");
    var imagenProducto = document.getElementById("ImagenProducto");
    var productos = @Html.Raw(Json.Serialize(Model.Productos));

    nombreProductoSelect.addEventListener("change", function () {
        
        var seleccion = nombreProductoSelect.value;
        
        var productoSeleccionado = productos.find(function (producto) {
            return producto.NombreProducto === seleccion;
        });

        if (productoSeleccionado) {

            precioUnitarioSpan.textContent = productoSeleccionado.PrecioUnitario;
            imagenProducto.src = "data:image/jpeg;base64," + productoSeleccionado.ImagenProducto;
        } else {
            
            precioUnitarioSpan.textContent = "";
            imagenProducto.src = "";
        }
    });
});
