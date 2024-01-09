using ApiLMotos.DbHandle;
using ApiLMotos.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestaApiLMotosurante.Controllers
{
    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [Route("GetEmpresas")]
        [HttpGet]
        public Response Empresas_ListarPorUsuario(int iMUsuario)
        {
            Response result = null;
            UsuarioDb db = new UsuarioDb();
            var list = db.Empresas_ListarPorUsuario(iMUsuario);
            if (list != null)
            {
                result = new Response()
                {
                    code = 0,
                    message = "Búsqueda exitosa",
                    data = list
                };
            }
            else
            {
                result = new Response()
                {
                    code = 2,
                    message = "Sin información disponible",
                    data = new string[] { }
                };
            }
            return result;
        }

        [Route("PostTokenAndroid")]
        [HttpPost]
        public Response DTokenAndroid([FromForm] TokenAndroid data)
        {
            Response result = null;
            UsuarioDb db = new UsuarioDb();
            var list = db.DTokenAndroid(data);
            if (list != null)
            {
                result = new Response()
                {
                    code = list.code,
                    message = list.message,
                    data = new { }
                };
            }
            else
            {
                result = new Response()
                {
                    code = 2,
                    message = "Datos invalidos, vuelva  a intentarlo",
                    data = new { }
                };
            }
            return result;
        }
    }
}
