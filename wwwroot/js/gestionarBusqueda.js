document.addEventListener("DOMContentLoaded", function () {
    var tipoBusquedaCliente = document.getElementById("tipo-busqueda-cliente");
    var tipoBusquedaFactura = document.getElementById("tipo-busqueda-factura");
    var razonSocialSelect = document.getElementById("razonSocial");
    var numeroFacturaInput = document.getElementById("numero-factura");

    function limpiarNumeroFactura() {
        numeroFacturaInput.value = ""; // Limpiar el valor del campo
    }

    tipoBusquedaCliente.addEventListener("change", function () {
        if (tipoBusquedaCliente.checked) {
            razonSocialSelect.disabled = false;
            numeroFacturaInput.disabled = true;
            limpiarNumeroFactura(); // Limpia el campo al cambiar a "Cliente"
        }
    });

    tipoBusquedaFactura.addEventListener("change", function () {
        if (tipoBusquedaFactura.checked) {
            razonSocialSelect.disabled = true;
            numeroFacturaInput.disabled = false;
            limpiarNumeroFactura(); // Limpia el campo al cambiar a "Número de Factura"
        }
    });

    //var buscarFacturaButton = document.getElementById("buscar-factura");
    //buscarFacturaButton.addEventListener("click", function () {
    //    var tipoBusquedaCliente = document.getElementById("tipo-busqueda-cliente");
    //    var razonSocialSelect = document.getElementById("razonSocial");
    //    var numeroFacturaInput = document.getElementById("numero-factura");

    //    var tipoBusqueda = tipoBusquedaCliente.checked ? "cliente" : "factura";
    //    var criterio = tipoBusqueda === "cliente" ? razonSocialSelect.value : numeroFacturaInput.value;

    //    console.log("Tipo de búsqueda: " + tipoBusqueda);
    //    console.log("Criterio: " + criterio);

    //    $.ajax({
    //        url: '/Facturas/BusquedaFacturaPost',
    //        type: 'GET',
    //        data: { tipoBusqueda: tipoBusqueda, criterio: criterio },
    //        success: function (data) {
    //            $('#resultados-container').empty();
    //            $.each(data, function (index, factura) {
    //                $('#resultados-container').append(
    //                    '<div>' +
    //                    '<span>Número de Factura: ' + factura.NumeroFactura + '</span>' +
    //                    '<span>Fecha de Emisión: ' + factura.FechaEmisionFactura + '</span>' +
    //                    '<span>Total Facturado: ' + factura.TotalFactura + '</span>' +
    //                    '</div>'
    //                );
    //            });
    //        }
    //    });
    //});

});
