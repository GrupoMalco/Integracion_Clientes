using System;
using System.Collections.Generic;
using Malco.Integracion.Clientes.Dominio.IRepositorioIntegracionClientes;
using Malco.Integracion.Clientes.Dominio;

namespace Malco.Integracion.Clientes.TDDTest.Mocks
{
    public class FacturasRepositorioMock : IFacturasRepositorio
    {  
        public bool _escenarioFallido { get; set; }

        public FacturasRepositorioMock()
        {
            _escenarioFallido = false;
        }

        public EncabezadoFacturas ObtenerFacturaPorNumero(int numeroFactura)
        {
            var facturaCliente = new EncabezadoFacturas();
            if (!_escenarioFallido)
            {
                facturaCliente = DatosFacturaPrueba(numeroFactura);
            }
            else
            {
                facturaCliente = new EncabezadoFacturas();
            }
            return facturaCliente;
        }

        public IEnumerable<EncabezadoFacturas> ObtenerFacturaClientePorNumero(long idTercero, int numeroFactura)
        {
            var facturaCliente = new EncabezadoFacturas();
            if (!_escenarioFallido)
            {
                facturaCliente = DatosFacturaPrueba(idTercero,numeroFactura);
            }
            else
            {
                facturaCliente = new EncabezadoFacturas();
            }
            return (IEnumerable<EncabezadoFacturas>)facturaCliente;
        }

        public IEnumerable<EncabezadoFacturas> ListarFacturasCliente(long idTercero)
        {
            var listarFacturasCliente = new List<EncabezadoFacturas>();
            if (!_escenarioFallido)
            {
                //List<EncabezadoFacturas> listarFacturasCliente = new List<EncabezadoFacturas>();
                listarFacturasCliente.Add(DatosFacturaPruebaUno());
                listarFacturasCliente.Add(DatosFacturaPruebaDos());
                listarFacturasCliente.Add(DatosFacturaPruebaTres());
                // lista = (IEnumerable<EncabezadoFacturas>)listarFacturasCliente;
            }
            else
            {
               listarFacturasCliente = new List<EncabezadoFacturas>();
                // lista = (IEnumerable<EncabezadoFacturas>)listarFacturasCliente;
            }
            return listarFacturasCliente;
        }

        public IEnumerable<EncabezadoFacturas> ListarFacturasClienteRangoFecha(long idCliente, DateTime fechaInicial, DateTime fechaFinal)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EncabezadoFacturas> ListarFacturasClienteRangoNumero(long idCliente, int numeroInicial, int numeroFinal)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EncabezadoFacturas> ListarFacturaClientePorNumero(long idCliente, int numeroFactura)
        {
            throw new NotImplementedException();
        }


        public EncabezadoFacturas DatosFacturaPrueba(int numeroFactura)
        {
            EncabezadoFacturas facturaUno = new EncabezadoFacturas();
            facturaUno.NNroFactura = numeroFactura;   // 274790;
            facturaUno.CFechaElaboracionFactura = "2015/11/23";
            facturaUno.NVlrFactura = new decimal(900138.00);
            facturaUno.NVlrIva = new decimal(63248.64);
            facturaUno.NVlrSaldo = 963387;
            facturaUno.NSede = 2;
            facturaUno.CEstado = "";

            IEnumerable<DetalleFacturas> detallesFactura = new List<DetalleFacturas>();

            //Detalle de gasto
            DetalleFacturas detalle1Factura = new DetalleFacturas();
            detalle1Factura.NCodigoGasto = 6;
            detalle1Factura.NNroFactura = 274790;
            detalle1Factura.NValor = 61385;
            detalle1Factura.NIva = new decimal(9822.00);
            detalle1Factura.nVlrSaldoNotaCredito = 71207;
            detalle1Factura.CTipo = "G";

            //Detalle de gasto
            DetalleFacturas detalle2Factura = new DetalleFacturas();
            detalle2Factura.NCodigoGasto = 8;
            detalle2Factura.NNroFactura = 274790;
            detalle2Factura.NValor = 94000;
            detalle2Factura.NIva = new decimal(0.00);
            detalle2Factura.nVlrSaldoNotaCredito = 94000;
            detalle2Factura.CTipo = "G";

            //Detalle de servicio
            DetalleFacturas detalle3Factura = new DetalleFacturas();
            detalle3Factura.NCodigoGasto = 74;
            detalle3Factura.NNroFactura = 274790;
            detalle3Factura.NValor = 2011;
            detalle3Factura.NIva = new decimal(0.00);
            detalle3Factura.nVlrSaldoNotaCredito = 2011;
            detalle3Factura.CTipo = "S";

            facturaUno.tbDetalleFacturas.Add(detalle1Factura);
            facturaUno.tbDetalleFacturas.Add(detalle2Factura);
            facturaUno.tbDetalleFacturas.Add(detalle3Factura);

            return facturaUno;
        }

        public EncabezadoFacturas DatosFacturaPrueba(long idTercero, int numeroFactura)
        {
            EncabezadoFacturas facturaUno = new EncabezadoFacturas();
            facturaUno.NidTercero = idTercero;
            facturaUno.NNroFactura = numeroFactura;   // 274790;
            facturaUno.CFechaElaboracionFactura = "2015/11/23";
            facturaUno.NVlrFactura = new decimal(900138.00);
            facturaUno.NVlrIva = new decimal(63248.64);
            facturaUno.NVlrSaldo = 963387;
            facturaUno.NSede = 2;
            facturaUno.CEstado = "";

            IEnumerable<DetalleFacturas> detallesFactura = new List<DetalleFacturas>();

            //Detalle de gasto
            DetalleFacturas detalle1Factura = new DetalleFacturas();
            detalle1Factura.NCodigoGasto = 6;
            detalle1Factura.NNroFactura = 274790;
            detalle1Factura.NValor = 61385;
            detalle1Factura.NIva = new decimal(9822.00);
            detalle1Factura.nVlrSaldoNotaCredito = 71207;
            detalle1Factura.CTipo = "G";

            //Detalle de gasto
            DetalleFacturas detalle2Factura = new DetalleFacturas();
            detalle2Factura.NCodigoGasto = 8;
            detalle2Factura.NNroFactura = 274790;
            detalle2Factura.NValor = 94000;
            detalle2Factura.NIva = new decimal(0.00);
            detalle2Factura.nVlrSaldoNotaCredito = 94000;
            detalle2Factura.CTipo = "G";

            //Detalle de servicio
            DetalleFacturas detalle3Factura = new DetalleFacturas();
            detalle3Factura.NCodigoGasto = 74;
            detalle3Factura.NNroFactura = 274790;
            detalle3Factura.NValor = 2011;
            detalle3Factura.NIva = new decimal(0.00);
            detalle3Factura.nVlrSaldoNotaCredito = 2011;
            detalle3Factura.CTipo = "S";

            facturaUno.tbDetalleFacturas.Add(detalle1Factura);
            facturaUno.tbDetalleFacturas.Add(detalle2Factura);
            facturaUno.tbDetalleFacturas.Add(detalle3Factura);

            return facturaUno;
        }

        /// <summary>
        /// Mètodo encargado de definir una factura de prueba y sus detalles
        /// </summary>
        /// <returns></returns>
        public EncabezadoFacturas DatosFacturaPruebaUno()
        {
            EncabezadoFacturas facturaUno = new EncabezadoFacturas();
            facturaUno.NidTercero = 9999999;
            facturaUno.NNroFactura = 274790;
            facturaUno.CFechaElaboracionFactura = "2015/11/23";
            facturaUno.NVlrFactura = new decimal(900138.00);
            facturaUno.NVlrIva = new decimal(63248.64);
            facturaUno.NVlrSaldo = 963387;
            facturaUno.NSede = 2;
            facturaUno.CEstado = "";

            IEnumerable<DetalleFacturas> detallesFactura = new List<DetalleFacturas>();

            //Detalle de gasto
            DetalleFacturas detalle1Factura = new DetalleFacturas();
            detalle1Factura.NCodigoGasto = 6;
            detalle1Factura.NNroFactura = 274790;
            detalle1Factura.NValor = 61385;
            detalle1Factura.NIva = new decimal(9822.00);
            detalle1Factura.nVlrSaldoNotaCredito = 71207;
            detalle1Factura.CTipo = "G";

            //Detalle de gasto
            DetalleFacturas detalle2Factura = new DetalleFacturas();
            detalle2Factura.NCodigoGasto = 8;
            detalle2Factura.NNroFactura = 274790;
            detalle2Factura.NValor = 94000;
            detalle2Factura.NIva = new decimal(0.00);
            detalle2Factura.nVlrSaldoNotaCredito = 94000;
            detalle2Factura.CTipo = "G";

            //Detalle de servicio
            DetalleFacturas detalle3Factura = new DetalleFacturas();
            detalle3Factura.NCodigoGasto = 74;
            detalle3Factura.NNroFactura = 274790;
            detalle3Factura.NValor = 2011;
            detalle3Factura.NIva = new decimal(0.00);
            detalle3Factura.nVlrSaldoNotaCredito = 2011;
            detalle3Factura.CTipo = "S";

            facturaUno.tbDetalleFacturas.Add(detalle1Factura);
            facturaUno.tbDetalleFacturas.Add(detalle2Factura);
            facturaUno.tbDetalleFacturas.Add(detalle3Factura);

            return facturaUno;
        }

        /// <summary>
        /// Mètodo encargado de definir una factura de prueba y sus detalles
        /// </summary>
        /// <returns></returns>
        public EncabezadoFacturas DatosFacturaPruebaDos()
        {
            EncabezadoFacturas facturaUno = new EncabezadoFacturas();
            facturaUno.NidTercero = 9999999;
            facturaUno.NNroFactura = 272910;
            facturaUno.CFechaElaboracionFactura = "2015/11/09";
            facturaUno.NVlrFactura = new decimal(619089.00);
            facturaUno.NVlrIva = new decimal(0.00);
            facturaUno.NVlrSaldo = 619089;
            facturaUno.NSede = 2;
            facturaUno.CEstado = "";

            IEnumerable<DetalleFacturas> detallesFactura = new List<DetalleFacturas>();

            //Detalle de gasto
            DetalleFacturas detalle1Factura = new DetalleFacturas();
            detalle1Factura.NCodigoGasto = 2;
            detalle1Factura.NNroFactura = 272910;
            detalle1Factura.NValor = 117700;
            detalle1Factura.NIva = new decimal(0.00);
            detalle1Factura.nVlrSaldoNotaCredito = 117700;
            detalle1Factura.CTipo = "G";

            //Detalle de gasto
            DetalleFacturas detalle2Factura = new DetalleFacturas();
            detalle2Factura.NCodigoGasto = 6;
            detalle2Factura.NNroFactura = 272910;
            detalle2Factura.NValor = 430106;
            detalle2Factura.NIva = new decimal(68817.00);
            detalle2Factura.nVlrSaldoNotaCredito = 498923;
            detalle2Factura.CTipo = "G";

            //Detalle de servicio
            DetalleFacturas detalle3Factura = new DetalleFacturas();
            detalle3Factura.NCodigoGasto = 74;
            detalle3Factura.NNroFactura = 272910;
            detalle3Factura.NValor = 2466;
            detalle3Factura.NIva = new decimal(0.00);
            detalle3Factura.nVlrSaldoNotaCredito = 2466;
            detalle3Factura.CTipo = "S";


            //Detalle de pago o abono
            DetalleFacturas detalle4Factura = new DetalleFacturas();
            detalle4Factura.NCodigoGasto = 0;
            detalle4Factura.NNroFactura = 272910;
            detalle4Factura.NValor = 619089;
            detalle4Factura.NIva = new decimal(0.00);
            detalle4Factura.nVlrSaldoNotaCredito = 0;
            detalle4Factura.CTipo = "Z";

            facturaUno.tbDetalleFacturas.Add(detalle1Factura);
            facturaUno.tbDetalleFacturas.Add(detalle2Factura);
            facturaUno.tbDetalleFacturas.Add(detalle3Factura);
            facturaUno.tbDetalleFacturas.Add(detalle4Factura);

            return facturaUno;
        }

        /// <summary>
        /// Mètodo encargado de definir una factura de prueba y sus detalles
        /// </summary>
        /// <returns></returns>
        public EncabezadoFacturas DatosFacturaPruebaTres()
        {
            EncabezadoFacturas facturaUno = new EncabezadoFacturas();
            facturaUno.NidTercero = 9999999;
            facturaUno.NNroFactura = 235700;
            facturaUno.CFechaElaboracionFactura = "2015/03/02";
            facturaUno.NVlrFactura = new decimal(351774.00);
            facturaUno.NVlrIva = new decimal(0.00);
            facturaUno.NVlrSaldo = 351774;
            facturaUno.NSede = 2;
            facturaUno.CEstado = "";

            IEnumerable<DetalleFacturas> detallesFactura = new List<DetalleFacturas>();

            //Detalle de gasto
            DetalleFacturas detalle1Factura = new DetalleFacturas();
            detalle1Factura.NCodigoGasto = 254;
            detalle1Factura.NNroFactura = 235700;
            detalle1Factura.NValor = 350373;
            detalle1Factura.NIva = new decimal(0.00);
            detalle1Factura.nVlrSaldoNotaCredito = 350373;
            detalle1Factura.CTipo = "G";

            //Detalle de servicio
            DetalleFacturas detalle3Factura = new DetalleFacturas();
            detalle3Factura.NCodigoGasto = 74;
            detalle3Factura.NNroFactura = 235700;
            detalle3Factura.NValor = 1401;
            detalle3Factura.NIva = new decimal(0.00);
            detalle3Factura.nVlrSaldoNotaCredito = 1401;
            detalle3Factura.CTipo = "S";


            //Detalle de pago o abono
            DetalleFacturas detalle4Factura = new DetalleFacturas();
            detalle4Factura.NCodigoGasto = 0;
            detalle4Factura.NNroFactura = 235700;
            detalle4Factura.NValor = 351774;
            detalle4Factura.NIva = new decimal(0.00);
            detalle4Factura.nVlrSaldoNotaCredito = 0;
            detalle4Factura.CTipo = "Z";

            facturaUno.tbDetalleFacturas.Add(detalle1Factura);
            facturaUno.tbDetalleFacturas.Add(detalle3Factura);
            facturaUno.tbDetalleFacturas.Add(detalle4Factura);


            return facturaUno;
        }

    }


}

