using Malco.Integracion.Clientes.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Malco.Integracion.Clientes.Dominio.IRepositorioIntegracionClientes
{
    public interface IFacturasRepositorio
    {
        /// <summary>
        /// Mètodo encargado de obtener las facturas de un tercero cliente,
        /// registradas en la base de datos de DBSIASQL
        /// </summary>
        /// <param name="idTercero">identificador del cliente o tercero</param>
        /// <returns></returns>
        IEnumerable<EncabezadoFacturas> ListarFacturasCliente(long idTercero);

        /// <summary>
        /// Metodo encargado de obtener las facturas de un cliente mediante un rango de fechas,
        /// registradas en la base de datos de DBSIASQL
        /// </summary>
        /// <param name="idTercero"> identificador del cliente o tercero</param>
        /// <param name="fechaInicial"> fecha inicial de la elaboración de la factura</param>
        /// <param name="fechaFinal"> fecha final de la elaboración de la factura </param>
        /// <returns></returns>
        IEnumerable<EncabezadoFacturas> ListarFacturasClienteRangoFecha(long idTercero, DateTime fechaInicial,DateTime fechaFinal);

        /// <summary>
        /// Metodo encargado de obtener las facturas de un cliente mediante un rango de fechas,
        /// registradas en la base de datos de DBSIASQL
        /// </summary>
        /// <param name="idTercero">identificador del cliente o tercero</param>
        /// <param name="numeroInicial">numero inicial de las facturas que se quieren listar</param>
        /// <param name="numeroFinal">numero final de las facturas que se quieren listar</param>
        /// <returns></returns>
        IEnumerable<EncabezadoFacturas> ListarFacturasClienteRangoNumero(long idTercero,int numeroInicial,int numeroFinal);

        /// <summary>
        /// Mètodo encargado de obtener uan factura de un cliente por medio del numero de la factura
        /// </summary>
        /// <param name="idTercero">identificador del cliente o tercero</param>
        /// <param name="numeroFactura">numero final de las facturas que se quieren listar</param>
        /// <returns></returns>
        IEnumerable<EncabezadoFacturas> ObtenerFacturaClientePorNumero(long idTercero, int numeroFactura);

        EncabezadoFacturas ObtenerFacturaPorNumero(int numeroFactura);
    }
}
