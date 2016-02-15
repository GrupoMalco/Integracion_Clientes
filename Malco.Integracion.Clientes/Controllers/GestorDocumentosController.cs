using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Malco.Integracion.Clientes.Dominio.IRepositorioIntegracionClientes;
using Malco.Integracion.Clientes.Dominio;
using Malco.Integracion.Clientes.Models;
using Malco.Integracion.Clientes.Repositorio.RepositorioIntegracionClientes;

namespace Malco.Integracion.Clientes.Controllers
{
    public class GestorDocumentosController : Controller

    {
        private readonly IFacturasRepositorio _facturasRepositorio;
        // GET: GestorDocumentos
        public ActionResult Index()
        {
            return View("GestionDocumentos");
        }

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="iFacturasRepositorio">Contrato del repositorio de facturas</param>
        public GestorDocumentosController(IFacturasRepositorio iFacturasRepositorio)
        {
            _facturasRepositorio = iFacturasRepositorio;
        }

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public GestorDocumentosController()
        {
            _facturasRepositorio = new FacturasRepositorio();
        }

        /// <summary>
        /// Mètodo encargado de consultar los datos nuevos de las facturas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<EncabezadoFacturas> ListarDatosNuevosFacturas(long idTercero)
        {
            IEnumerable<EncabezadoFacturas> datosNuevosList = _facturasRepositorio.ListarFacturasCliente(idTercero);
            //Valido si la consulta me trajo resultados
            if (datosNuevosList != null && datosNuevosList.Any())
            {
                ViewBag.HayRegistros = Util.Utilidades.MessagesConstants.CON_RESULTADOS;
            }
            else
            {
                ViewBag.HayRegistros = Util.Utilidades.MessagesConstants.SIN_RESULTADOS;
            }
           
            return datosNuevosList;
        }


        public EncabezadoFacturas ObtenerFacturaPorNumero(int numeroFactura)
        {
           EncabezadoFacturas factura = _facturasRepositorio.ObtenerFacturaPorNumero(numeroFactura);
            return factura;
        }

        [HttpPost]
        public PartialViewResult GridObtenerFacturaPorNumero(string numeroFactura)
        {
            List<EncabezadoFacturas>listaFacturas=new List<EncabezadoFacturas>();
            listaFacturas.Add(ObtenerFacturaPorNumero(int.Parse(numeroFactura)));
            if (listaFacturas != null && listaFacturas.Any())
            {
                ViewBag.HayRegistros = Util.Utilidades.MessagesConstants.CON_RESULTADOS;
            }
            else
            {
                ViewBag.HayRegistros = Util.Utilidades.MessagesConstants.SIN_RESULTADOS;
            }
            return PartialView("GridDatosPartialView", listaFacturas);
        }

        [HttpPost]
        public PartialViewResult GridDatosNuevosFacturas(string idTercero)
        {
            return PartialView("GridDatosPartialView", ListarDatosNuevosFacturas(long.Parse(idTercero)));
        }

        

        [HttpPost]
        public PartialViewResult GridDatosNuevosDetalleFacturas(string idTercero)
        {
            return PartialView("GridDatosDetallePartialView", TransformarDatosFactura(ListarDatosNuevosFacturas(long.Parse(idTercero))));
        }

        /// <summary>
        /// Mètodo encargado de transformar la informacion de los datos de la factura para mostrarla
        /// en el GRID
        /// </summary>
        /// <returns></returns>
        public List<DatosFacturaViewModel> TransformarDatosFactura(IEnumerable<EncabezadoFacturas> datosNuevosList)
        {
            List<DatosFacturaViewModel> listaDatos = new List<DatosFacturaViewModel>();
            foreach (EncabezadoFacturas factura in datosNuevosList)
            {
                foreach (DetalleFacturas detalle in factura.tbDetalleFacturas)
                {
                    DatosFacturaViewModel datoNuevo = new DatosFacturaViewModel();
                    datoNuevo.IdentificacionRegistro = "C";
                    datoNuevo.NitMarioLondono = "890902266";
                    datoNuevo.NumeroFactura = factura.NNroFactura;
                    datoNuevo.FechaFactura = factura.CFechaElaboracionFactura;
                    datoNuevo.SubTotalFactura = factura.NVlrFactura;
                    datoNuevo.ValorIva = factura.NVlrIva != null ? factura.NVlrIva.Value : 0;
                    datoNuevo.TotalFactura = factura.NVlrSaldo;
                    datoNuevo.NSede = factura.NSede;
                    datoNuevo.Estado = factura.CEstado;
                    datoNuevo.IdentificacionRegistroDetalle = "D";
                    datoNuevo.NitProveedor = 890902266;
                    datoNuevo.CodigoEventoMalco = detalle.NCodigoGasto;
                    datoNuevo.SubTotalFacturaDetalle = detalle.NValor;
                    datoNuevo.ValorIvaDetalle = detalle.NIva != null ? detalle.NIva.Value : 0;
                    datoNuevo.SaldoNotaCredito = detalle.nVlrSaldoNotaCredito;
                    datoNuevo.TipoDetalle = detalle.CTipo;
                    listaDatos.Add(datoNuevo);
                }
            }
            return listaDatos;
        }
    }
}