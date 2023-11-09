// Agrega otra fila en la tabla 
// hace el calculo de totales,subtotal,impuesto,total
document.addEventListener("DOMContentLoaded", function () {
    var tabla = document.querySelector("table tbody");
    var subtotalInput = document.getElementById("subtotal");
    var impuestosInput = document.getElementById("impuestos");
    var totalInput = document.getElementById("total");

    tabla.addEventListener("input", function (event) {
        var target = event.target;
        if (target.classList.contains("cantidad")) {
            
            var filas = tabla.querySelectorAll("tr");
            var totalFilas = 0;
            filas.forEach(function (fila) {
                var cantidadInput = fila.querySelector(".cantidad");
                var precioUnitarioSpan = fila.querySelector(".precioUnitario");
                var totalInput = fila.querySelector(".total");
                var cantidad = parseFloat(cantidadInput.value) || 0;
                var precioUnitario = parseFloat(precioUnitarioSpan.textContent) || 0;
                var total = cantidad * precioUnitario;
                totalInput.value = total.toFixed(2);
                totalFilas += total;
            });

            subtotalInput.value = totalFilas.toFixed(2);

            var impuestos = totalFilas * 0.19; // 19%
            impuestosInput.value = impuestos.toFixed(2);

            var total = totalFilas + impuestos;
            totalInput.value = total.toFixed(2);
        }
    });

    var botonAgregarProducto = document.getElementById("agregar-producto");
    botonAgregarProducto.addEventListener("click", function () {
        var filaClonada = document.getElementById("fila-producto").cloneNode(true);
        var camposClonados = filaClonada.querySelectorAll("input, select");
        camposClonados.forEach(function (campo) {
            campo.value = "";
        });

        tabla.appendChild(filaClonada);
    });
});
