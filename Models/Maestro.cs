using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApiLMotos.Models
{
    public class MDepartamento
    {
        public int iDepartamento { get; set; }
        public string tDepartamento { get; set; }
    }
    public class MMProvincia
    {
        public int iMProvincia { get; set; }
        public string tMProvincia { get; set; }
    }
    public class MDistrito
    {
        public int iDistrito { get; set; }
        public string tDistrito { get; set; }
    }
    public class MTipoDocumentoIdentidad
    {
        public string iMTipoDocumentoIdentidad { get; set; }
        public string tDescripcion { get; set; }
    }

    public class MCliente
    {
        public Int64 iMCliente { get; set; }
        public string tNroDocumento { get; set; }
        public string tNombre { get; set; }
        public string tDireccion { get; set; }
        public string tCorreo { get; set; }
        public string iMTipoDocumentoIdentidad { get; set; }
        public string tTelefonoPrincipal { get; set; }
    }

    public class ClienteBuscarWSDni
    {
        public string TNroDocumento { get; set; }
        public string TNombres { get; set; }
        public string TSexo { get; set; }
        public string FFechaNacimiento { get; set; }
        public long Statuscode { get; set; }
        public long Codeerror { get; set; }
        public string Message { get; set; }
        public object Username { get; set; }
        public object Password { get; set; }
        public long StatusCode { get; set; }
        public object StatusMessage { get; set; }
    }

    public class Maestro
    {
    }
}
