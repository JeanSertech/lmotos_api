using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLMotos.Models
{
    public class Empresas
    {
        public string tEmpresaRuc { get; set; }
        public string tEmpresa { get; set; }
        public List<Sucursal> Sucursal { get; set; }
    }
    public class Sucursal
    {
        public Int64 iDSucursal { get; set; }
        public string tSucursal { get; set; }
    }
    public class TokenAndroid
    {
        public Int64? iMUsuario { get; set; }
        public string? tTotenAndroid { get; set; }
    }
}
