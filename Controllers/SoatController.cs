using ApiLMotos.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;
using ApiLMotos.DbHandle;
using Nancy.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Microsoft.Extensions.DependencyModel;
using System.IO;
using System.Web;
namespace ApiLMotos.Controllers
{
    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class SoatController : ControllerBase
    {

        [Route("GetSoatCliente")]
        [HttpGet]
        public Response DSoatCliente_Listar(Int64 iMCliente)
        {
            Response result = null;
            SoatDb db = new SoatDb();
            var list = db.DSoatCliente_Listar(iMCliente);
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

        [Route("GetVehiculoPlacaBuscar")]
        [HttpGet]
        public Response DVehiculoPlaca_Buscar(string tPlaca, int iAnio)
        {
            Response result = null;
            SoatDb db = new SoatDb();
            var list = db.DVehiculoPlaca_Buscar(tPlaca,iAnio);
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

        [Route("GetRequisitosPrevio")]
        [HttpGet]
        public Response DRequisitosPrevio_Listar(Int64 iMContrato, Boolean isLMotos)
        {
            Response result = null;
            SoatDb db = new SoatDb();
            var list = db.DRequisitosPrevio_Listar(iMContrato, isLMotos);
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
        
        [Route("GetCuotas")]
        [HttpGet]
        public Response DCuotas_Listar(Int64 iMContrato)
        {
            Response result = null;
            SoatDb db = new SoatDb();
            var list = db.DCuotas_Listar(iMContrato);
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

        [Route("PostContratoValidacion")]
        [HttpPost]
        public Response DContratoValidacion_Registrar([FromForm] ContratoValidacion data)
        {
            Response result = null;
            SoatDb db = new SoatDb();
            var list = db.DContratoValidacion_Registrar(data);
            if (list != null)
            {
                result = new Response()
                {
                    code = list.code,
                    message = list.message,
                    data = list.code == 0 ? new { iMContrato = Ok(list.data).Value } : new { }
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

        [Route("PostContratoRequisito")]
        [HttpPost]
        public Response DContratoRequisitoRegistrar([FromForm] ContratoRequisito data)
        {
            Response result = null;
            SoatDb db = new SoatDb();
            var list = db.DContratoRequisitoRegistrar(data);
            if (list != null)
            {
                result = new Response()
                {
                    code = list.code,
                    message = list.message,
                    data = list.code == 0 ? new { iMContrato = Ok(list.data).Value } : new { }
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
        
        [Route("PostContratoCuota")]
        [HttpPost]
        public Response DContratoCuotaRegistrar([FromForm] ContratoCuota data)
        {
            Response result = null;
            SoatDb db = new SoatDb();
            var list = db.DContratoCuotaRegistrar(data);
            if (list != null)
            {
                result = new Response()
                {
                    code = list.code,
                    message = list.message,
                    data = list.code == 0 ? new { iMContrato = Ok(list.data).Value } : new { }
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

        [Route("PostContratoCuotaNew")]
        [HttpPost]
        public Response DContratoCuotaRegistrarNew([FromForm] ContratoCuotaNew data)
        {
            Response result = null;
            SoatDb db = new SoatDb();
            var list = db.DContratoCuotaRegistrarNew(data);
            if (list != null)
            {
                result = new Response()
                {
                    code = list.code,
                    message = list.message,
                    data = list.code == 0 ? new { iMContrato = Ok(list.data).Value } : new { }
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

        [Route("PostContrato")]
        [HttpPost]
        public Response DContratoRegistrar([FromForm] Contrato data)
        {
            Response result = null;
            SoatDb db = new SoatDb();
            var list = db.DContratoRegistrar(data);
            if (list != null)
            {
                result = new Response()
                {
                    code = list.code,
                    message = list.message,
                    data = list.code == 0 ? new { iMContrato = Ok(list.data).Value } : new { }
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

        [Route("PostCotizacion")]
        [HttpPost]
        public Response DCotizacionRegistrar([FromForm] Cotizacion data)
        {
            Response result = null;
            SoatDb db = new SoatDb();
            var list = db.DCotizacionRegistrar(data);
            if (list != null)
            {
                result = new Response()
                {
                    code = list.code,
                    message = list.message,
                    data = list.code == 0 ? new { iMCotizacion = Ok(list.data).Value } : new { }
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

        [Route("PostUpdateContrato")]
        [HttpPost]
        public Response DContratActualizar([FromForm] Contrato data)
        {
            Response result = null;
            SoatDb db = new SoatDb();
            var list = db.DContratoActualizar(data);
            if (list != null)
            {
                result = new Response()
                {
                    code = list.code,
                    message = list.message,
                    data = list.code == 0 ? new { iMContrato = Ok(list.data).Value } : new { }
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

        [Route("GetPrecioSoat")]
        [HttpGet]
        public Response DPrecioSoat_Listar(String tOrigen, int iPago)
        {
            Response result = null;
            SoatDb db = new SoatDb();
            var list = db.DPrecioSoat_Listar(tOrigen, iPago);
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

        [Route("GetDatosPersonsalesContrato")]
        [HttpGet]
        public Response DDatosPersonsalesContrato_Listar(Int64 iMContrato)
        {
            Response result = null;
            SoatDb db = new SoatDb();
            var list = db.DDatosPersonsalesContrato_Listar(iMContrato);
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

        [Route("GetZona")]
        [HttpGet]
        public Response MZona_Listar()
        {
            Response result = null;
            SoatDb db = new SoatDb();
            var list = db.MZona_Listar();
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

        [Route("GetUso")]
        [HttpGet]
        public Response MUso_Listar()
        {
            Response result = null;
            SoatDb db = new SoatDb();
            var list = db.MUso_Listar();
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

        [Route("GetClase")]
        [HttpGet]
        public Response MClase_Listar()
        {
            Response result = null;
            SoatDb db = new SoatDb();
            var list = db.MClase_Listar();
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

        [Route("GetCategoria")]
        [HttpGet]
        public Response MCategoria_Listar()
        {
            Response result = null;
            SoatDb db = new SoatDb();
            var list = db.MCategoria_Listar();
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
        [Route("GetMarca")]
        [HttpGet]
        public Response MMarca_Listar()
        {
            Response result = null;
            SoatDb db = new SoatDb();
            var list = db.MMarca_Listar();
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
        [Route("GetModelo")]
        [HttpGet]
        public Response MModelo_Listar(Int64 iMMarca)
        {
            Response result = null;
            SoatDb db = new SoatDb();
            var list = db.MModelo_Listar(iMMarca);
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
        [Route("GetVersion")]
        [HttpGet]
        public Response MVersion_Listar(Int64 iMModelo)
        {
            Response result = null;
            SoatDb db = new SoatDb();
            var list = db.MVersion_Listar(iMModelo);
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

        [Route("GetCotizacionCliente")]
        [HttpGet]
        public Response DCotizacionCliente_Listar(Int64 iMCliente)
        {
            Response result = null;
            SoatDb db = new SoatDb();
            var list = db.DCotizacionCliente_Listar(iMCliente);
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

        [Route("GetDataCliente")]
        [HttpGet]
        public Response DDataCliente_Listar(Int64 iMCliente, string tTipo , Int64 iD)
        {
            Response result = null;
            SoatDb db = new SoatDb();
            var list = db.DDataCliente_Listar(iMCliente, tTipo, iD);
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

        [Route("GetDataVehiculo")]
        [HttpGet]
        public Response DDataVehiculo_Listar(Int64 iMVehiculo, string tTipo)
        {
            Response result = null;
            SoatDb db = new SoatDb();
            var list = db.DDataVehiculo_Listar(iMVehiculo, tTipo);
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

        [Route("GetActualizarCaracteristicas")]
        [HttpGet]
        public Response ActualizarCaracteristicas(string? marca, string? modelo, string? clase, string? uso)
        {
            Response result = null;
            SoatDb db = new SoatDb();
            var list = db.ActualizarCaracteristicas(marca, modelo,clase,uso);
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

        [Route("GetDescargaSoat")]
        [HttpGet]
        public Response DescargaSoat(Int64 iMContrato)
        {
            Response result = null;
            SoatDb db = new SoatDb();
            var list = db.DescargaSoat(iMContrato);
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

        [Route("GetcontactarAsesorCotizacion")]
        [HttpGet]
        public Response contactarAsesorCotizacion(Int64 iMUsuario, string tOrigen, Int64 iId)
        {
            Response result = null;
            SoatDb db = new SoatDb();
            var list = db.contactarAsesorCotizacion(iMUsuario, tOrigen, iId);
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

        [Route("RegistroPagoPosExterno")]
        [HttpPost]
        public Response DPagoExterno([FromForm] PagoExterno data)
        {
            Response result = null;
            SoatDb db = new SoatDb();
            var list = db.DPagoExterno(data);
            if (list != null)
            {
                result = new Response()
                {
                    code = list.code,
                    message = list.message
                };
            }
            else
            {
                result = new Response()
                {
                    code = 2,
                    message = "Datos invalidos, vuelva  a intentarlo"
                };
            }
            return result;
        }

        [Route("GetContratoporId")]
        [HttpGet]
        public Response ContratoporId(Int64 iMContrato)
        {
            Response result = null;
            SoatDb db = new SoatDb();
            var list = db.ContratoporId(iMContrato);
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
        
        [Route("GetCuentaPago")]
        [HttpGet]
        public Response GetCuentaPago_Listar()
        {
            Response result = null;
            SoatDb db = new SoatDb();
            var list = db.GetCuentaPago_Listar();
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

        [Route("RegistrarPDFSoat")]
        [HttpPost]
        public Response RegistrarPDFSoat([FromForm] Int64? IDOportunidad, [FromForm] string? pdf)
        {
            Response result = null;
            List<string> errors = new List<string>();
            if(IDOportunidad == 0 || IDOportunidad == null)
            {
                errors.Add("El parametro IDOportunidad es requerido y debe ser un número."); 
                
            }
            if (string.IsNullOrEmpty(pdf))
            {
                errors.Add("El parametro PDF en base64 es requerido.");

            }
            byte[] bytesPDF = Convert.FromBase64String(pdf);
            if (!EsArchivoPDFValido(bytesPDF))
            {
                errors.Add("La cadena Base64 no representa un archivo PDF válido.");
            }
            if (errors.Count > 0)
            {
                result = new Response()
                {
                    code = 0,
                    message = "Parametros no válidos",
                    data = errors
                };
                return result;
            }

            DateTime fechaActual = DateTime.Now;
            string rutaRaiz = "Archivos";
            string carpetaAnio = Path.Combine(rutaRaiz,fechaActual.Year.ToString());
            Directory.CreateDirectory(carpetaAnio);

            string carpetaMes = Path.Combine(carpetaAnio, fechaActual.ToString("MM"));
            Directory.CreateDirectory(carpetaMes);

            string nombreAleatorio = GenerarNombreAleatorio(40);
            string rutaArchivoPDF = Path.Combine(carpetaMes, nombreAleatorio + ".pdf");

            System.IO.File.WriteAllBytes(rutaArchivoPDF, bytesPDF);

            SoatDb db = new SoatDb();
            SoatPdf entidad = db.RegistrarPDFSoat(IDOportunidad, rutaArchivoPDF, bytesPDF);

            if(entidad.IDOportunidad == 0)
            {
                result = new Response()
                {
                    code = 0,
                    message = "El IDOportunidad enviado ya existe en nuestros registros.",
                    data = new { }
                };
            } 
            else
            {
                result = new Response()
                {
                    code = 1,
                    message = "Registro exitoso.",
                    data = new {IDOportunidad = IDOportunidad, pdf = "***********" }
                };
            }

            return result;
        }

        [Route("CotizacionSoat")]
        [HttpPost]
        public Response CotizacionSoat(SoatCotizacion cotizacion)
        {
            Response result = null;
            List<string> errors = new List<string>();
            if (cotizacion.IDOportunidad == 0)
            {
                errors.Add("El parametro IDOportunidad es requerido y debe ser un número.");

            }
            if (cotizacion.tarifaTotal == 0)
            {
                errors.Add("El parametro tarifaTotal es requerido y debe ser un número.");
            }

            if (errors.Count > 0)
            {
                result = new Response()
                {
                    code = 0,
                    message = "Parametros no válidos",
                    data = errors
                };
                return result;
            }
            SoatDb db = new SoatDb();
            SoatCotizacion entidad = db.RegistrarCotizacionSoat(cotizacion);
            if (entidad.IDOportunidad == 0)
            {
                result = new Response()
                {
                    code = 0,
                    message = "El IDOportunidad enviado no existe en nuestros registros.",
                    data = new { }
                };
            }
            else
            {
                result = new Response()
                {
                    code = 1,
                    message = "Registro exitoso.",
                    data = new { 
                        IDOportunidad = entidad.IDOportunidad, 
                        tarifaTotal = entidad.tarifaTotal, 
                        tarifaSemanal = entidad.tarifaSemanal, 
                        interes = entidad.interes, 
                        code = entidad.code, 
                        message =  entidad.message
                    }
                };
            }
            return result;
        }

        static bool EsArchivoPDFValido(byte[] bytes)
        {
            byte[] pdfSignature = { 0x25, 0x50, 0x44, 0x46, 0x2D };

            for (int i = 0; i < pdfSignature.Length; i++)
            {
                if (bytes.Length <= i || bytes[i] != pdfSignature[i])
                {
                    return false;
                }
            }

            return true;
        }

        static string GenerarNombreAleatorio(int longitud)
        {
            const string caracteresPermitidos = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            char[] aleatorio = new char[longitud];
            Random random = new Random();

            for (int i = 0; i < longitud; i++)
            {
                aleatorio[i] = caracteresPermitidos[random.Next(caracteresPermitidos.Length)];
            }

            return new string(aleatorio);
        }
    }
}
