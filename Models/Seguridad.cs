using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLMotos.Models
{
    public class UsuarioApi
    {
        public Int64 iUsuarioApi { get; set; }
        public string tMessage { get; set; }
        public int iEstado { get; set; }
        public string tVersionAndroid { get; set; }
        public string tVersionIOS { get; set; }
        public string accountSid { get; set; }
        public string authToken { get; set; }
        public string twilioNumber { get; set; }
    }
    public class Usuario
    {
        public Int64 iMCliente { get; set; }
        public string tNombre { get; set; }
        public string tNroDocumento { get; set; }
        public string tTelefonoPrincipal { get; set; }
        public string iMTipoDocumentoIdentidad { get; set; }
        public string tTipoDocumentoIdentidad { get; set; }
        public string tCiudad { get; set; }
        public string tCorreo { get; set; }
        public string fFechaNacimiento { get; set; }
        public string tDireccion { get; set; }
        public string tNacionalidad { get; set; }
        public int iDepartamento { get; set; }
        public int iProvincia { get; set; }
        public int iDistrito { get; set; }
        
    }
}
