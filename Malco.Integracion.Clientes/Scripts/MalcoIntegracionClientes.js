function consultarDatosNuevosFactura() {
    var numFactura = $("#numeroFactura").val();
    if (numFactura != null  && numFactura!=="") {
        
        $.ajax({
            url: urlConsultarNumeroFactura,
            type: 'POST',
            data: { numeroFactura: numFactura },
            success: function (resultado) {
                $("#divResultado").css("display", "block");
                $("#divResultado").html(resultado);
            },
            error: function (resultado) {
                alert("Ocurrio un error");
            }
        });
    } else {
        var id = $("#idTercero").val();
        $.ajax({
            url: urlConsultarDatosNuevos,
            type: 'POST',
            data: { idTercero: id },
            success: function (resultado) {
                $("#divResultado").css("display", "block");
                $("#divResultado").html(resultado);
            },
            error: function (resultado) {
                alert("Ocurrio un error");
            }
        });
    }

}