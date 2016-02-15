using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Malco.Integracion.Clientes.Dominio;
using Malco.Integracion.Clientes.Dominio.IRepositorioIntegracionClientes;
using System.Collections;

namespace Malco.Integracion.Clientes.Repositorio.RepositorioIntegracionClientes
{
    public class FacturasRepositorio : IFacturasRepositorio
    {

        public DBSIASQLContext DbsiasqlContext;
    
        /// <summary>
        /// Contructor de la clase
        /// </summary>
        public FacturasRepositorio()
        {
            DbsiasqlContext = new DBSIASQLContext();
        }

        public IEnumerable<EncabezadoFacturas> ListarFacturaClientePorNumero(long idCliente, int numeroFactura)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Mètodo encargado de obtener las facturas de un tercero cliente,
        /// registradas en la base de datos de DBSIASQL
        /// </summary>
        /// <param name="idTercero">identificador del cliente o tercero</param>
        /// <returns></returns>
        public IEnumerable<EncabezadoFacturas> ListarFacturasCliente(long idTercero)
        {
            IEnumerable<EncabezadoFacturas> facturas = DbsiasqlContext
                .tbEncabezadoFacturas.Where(f => f.NidTercero == idTercero &&
                f.CEstado == Util.Utilidades.MessagesConstants.FACTURA_SIN_ESTADO);

            return facturas;
        }

        /// <summary>
        /// Metodo encargado de obtener las facturas de un cliente mediante un rango de fechas,
        /// registradas en la base de datos de DBSIASQL
        /// </summary>
        /// <param name="idTercero"> identificador del cliente o tercero</param>
        /// <param name="fechaInicial"> fecha inicial de la elaboración de la factura</param>
        /// <param name="fechaFinal"> fecha final de la elaboración de la factura </param>
        /// <returns></returns>
        public IEnumerable<EncabezadoFacturas> ListarFacturasClienteRangoFecha(long idTercero, DateTime fechaInicial, DateTime fechaFinal)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Metodo encargado de obtener las facturas de un cliente mediante un rango de fechas,
        /// registradas en la base de datos de DBSIASQL
        /// </summary>
        /// <param name="idTercero">identificador del cliente o tercero</param>
        /// <param name="numeroInicial">numero inicial de las facturas que se quieren listar</param>
        /// <param name="numeroFinal">numero final de las facturas que se quieren listar</param>
        /// <returns></returns>
        public IEnumerable<EncabezadoFacturas> ListarFacturasClienteRangoNumero(long idTercero, int numeroInicial, int numeroFinal)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Mètodo encargado de obtener una factura de un cliente por medio del numero de la factura
        /// </summary>
        /// <param name="idTercero">identificador del cliente o tercero</param>
        /// <param name="numeroFactura">numero final de la facturas que se quiere listar</param>
        /// <returns></returns>
        public IEnumerable<EncabezadoFacturas> ObtenerFacturaClientePorNumero(long idTercero, int numeroFactura)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Mètodo encargado de obtener  una factura por medio del numero de la misma
        /// </summary>
        /// <param name="numeroFactura">numero final de la facturas que se quiere listar</param>
        /// <returns></returns>
        public EncabezadoFacturas ObtenerFacturaPorNumero(int numeroFactura)
        {
            var factura =
                DbsiasqlContext.tbEncabezadoFacturas.SingleOrDefault(f => f.NNroFactura == numeroFactura
                && f.CEstado == Util.Utilidades.MessagesConstants.FACTURA_SIN_ESTADO);
            return factura;
        }
    }
}
