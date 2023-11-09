
document.addEventListener("DOMContentLoaded", function () {
    var botonNuevo = document.getElementById("nuevo");
    var tablaProductos = document.querySelector("table tbody");
    var numeroFacturaInput = document.getElementById("numero-factura");
    var razonSocialSelect = document.getElementById("razonSocial");
   
    botonNuevo.addEventListener("click", function () {
        
        var filasProductos = tablaProductos.querySelectorAll("tr");
        for (var i = 1; i < filasProductos.length; i++) {
            tablaProductos.removeChild(filasProductos[i]);
        }

        var camposSelect = document.querySelectorAll("select[name='nombreProducto']");
        camposSelect.forEach(function (select) {
            select.value = "";
        });

        numeroFacturaInput.value = "";

        razonSocialSelect.value = "";

        var camposCantidad = document.querySelectorAll("input[name='cantidad']");
        var camposTotales = document.querySelectorAll("input[name='total']");
        camposCantidad.forEach(function (campo) {
            campo.value = "";
        });
        camposTotales.forEach(function (campo) {
            campo.value = "";
        });

        var segundaTabla = document.getElementById("segunda-tabla");
        var camposSegundaTabla = segundaTabla.querySelectorAll("input[type='number']");
        camposSegundaTabla.forEach(function (campo) {
            campo.value = "";
        });
    });
});
