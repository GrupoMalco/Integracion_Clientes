Feature: FiltrarDatosNuevosFactura

Background: 
	Given Usuario logueado en la aplicacion

Scenario: Filtrado de datos nuevos de una factura
	Given El usuario ingresa a la opcion de filtrar facturas
	And se presiona el boton aceptar
	Then se muestran los datos nuevos de las facturas
