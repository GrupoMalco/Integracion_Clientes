using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Malco.Integracion.Clientes.Models
{
    public class DatosFacturaViewModel
    {
        public string IdentificacionRegistro { get; set; }
        public string NitMarioLondono { get; set; }

        public int NumeroFactura { get; set; }

        public string FechaFactura { get; set; }

        public decimal SubTotalFactura { get; set; }

        public decimal ValorIva { get; set; }

        public string Retencion1 { get; set; }

        public int TotalFactura { get; set; }
        
        public byte NSede { get; set; }

        public string Estado { get; set; }

        public string  IdentificacionRegistroDetalle { get; set; }

        public long NitProveedor { get; set; }

        public short CodigoEventoMalco { get; set; }

        public int SubTotalFacturaDetalle { get; set; }

        public decimal ValorIvaDetalle { get; set; }

        public int SaldoNotaCredito { get; set; }

        public String TipoDetalle { get; set; }

    }
}