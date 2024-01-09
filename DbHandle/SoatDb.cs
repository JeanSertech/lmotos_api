using ApiLMotos.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ApiLMotos.DbHandle
{
    public class SoatDb : GeneralDb
    {
        public List<Zona> MZona_Listar()
        {
            List<Zona> listEntidad = null;
            using (SqlConnection connection = new SqlConnection(Cadena))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("p_api_lm_MZonas_Listar", connection);
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                if (reader.HasRows)
                {
                    Zona entidad = null;
                    listEntidad = new List<Zona>();
                    while (reader.Read())
                    {
                        entidad = new Zona();
                        entidad.iMZona = reader.GetInt64(0);
                        entidad.tZona = reader.GetString(1);
                        listEntidad.Add(entidad);
                    }
                }
                reader.Close();
                connection.Close();
            }
            return listEntidad;
        }
        public List<Uso> MUso_Listar()
        {
            List<Uso> listEntidad = null;
            using (SqlConnection connection = new SqlConnection(Cadena))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("p_api_lm_MUso_Listar", connection);
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                if (reader.HasRows)
                {
                    Uso entidad = null;
                    listEntidad = new List<Uso>();
                    while (reader.Read())
                    {
                        entidad = new Uso();
                        entidad.iMUso = reader.GetInt64(0);
                        entidad.tUso = reader.GetString(1);
                        listEntidad.Add(entidad);
                    }
                }
                reader.Close();
                connection.Close();
            }
            return listEntidad;
        }
        public List<SoatCliente> DSoatCliente_Listar(Int64 iMCliente)
        {
            List<SoatCliente> listEntidad = null;
            using (SqlConnection connection = new SqlConnection(Cadena))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("p_api_lm_DSoat_Listar", connection);
                command.Parameters.Add("@iMCliente", SqlDbType.BigInt).Value = iMCliente;
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                if (reader.HasRows)
                {
                    SoatCliente entidad = null;
                    listEntidad = new List<SoatCliente>();
                    while (reader.Read())
                    {
                        entidad = new SoatCliente();
                        entidad.iMContrato = reader.GetInt64(0);
                        entidad.tPlaca = reader.GetString(1);
                        entidad.iPendiente = reader.GetDecimal(2);
                        entidad.iEstado = reader.GetInt32(3);
                        entidad.tEstado = reader.GetString(4);
                        entidad.iMVehiculo = reader.GetInt64(5);
                        entidad.iPrecioSoat = reader.GetDecimal(6);
                        entidad.iTipoPago = reader.GetInt32(7);
                        entidad.tPagoCuotas = reader.GetString(8);
                        entidad.tVencimiento = reader.GetString(9);
                        listEntidad.Add(entidad);
                    }
                }
                reader.Close();
                connection.Close();
            }
            return listEntidad;
        }
        public List<Vehiculo> DVehiculoPlaca_Buscar(string tPlaca, int iAnio)
        {
            List<Vehiculo> listEntidad = null;
            using (SqlConnection connection = new SqlConnection(Cadena))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("p_api_lm_mVehiculoPlaca_Buscar", connection);
                command.Parameters.Add("@tPlaca", SqlDbType.VarChar).Value = tPlaca;
                command.Parameters.Add("@iAnio", SqlDbType.Int).Value = iAnio;
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                if (reader.HasRows)
                {
                    Vehiculo entidad = null;
                    listEntidad = new List<Vehiculo>();
                    while (reader.Read())
                    {
                        entidad = new Vehiculo();
                        entidad.iMVehiculo = reader.GetInt64(0);
                        entidad.tPlaca = reader.GetString(1);
                        entidad.tMarca = reader.GetString(2);
                        entidad.tSerie = reader.GetString(3);
                        entidad.tVin = reader.GetString(4);
                        entidad.tMotor = reader.GetString(5);
                        entidad.tColor = reader.GetString(6);
                        entidad.iAnio = reader.GetInt32(7);
                        entidad.tModelo = reader.GetString(8);
                        listEntidad.Add(entidad);
                    }
                }
                reader.Close();
                connection.Close();
            }
            return listEntidad;
        }
        public List<SoatRequisitos> DRequisitosPrevio_Listar(Int64 iMContrato)
        {
            List<SoatRequisitos> listEntidad = null;
            using (SqlConnection connection = new SqlConnection(Cadena))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("p_api_lm_DRequisitosPrevio_Listar", connection);
                command.Parameters.Add("@iMContrato", SqlDbType.BigInt).Value = iMContrato;
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                if (reader.HasRows)
                {
                    SoatRequisitos entidad = null;
                    listEntidad = new List<SoatRequisitos>();
                    while (reader.Read())
                    {
                        entidad = new SoatRequisitos();
                        entidad.tTipo = reader.GetString(0);
                        entidad.tTipoDetalle = reader.GetString(1);
                        entidad.lEstado = reader.GetInt32(2);
                        entidad.tEstado = reader.GetString(3);
                        entidad.tEVidencia = reader.GetString(4);
                        entidad.tMotivo = reader.GetString(5);
                        listEntidad.Add(entidad);
                    }
                }
                reader.Close();
                connection.Close();
            }
            return listEntidad;
        }
        public List<SoatCuotas> DCuotas_Listar(Int64 iMContrato)
        {
            List<SoatCuotas> listEntidad = null;
            using (SqlConnection connection = new SqlConnection(Cadena))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("p_api_lm_DCuotas_Listar", connection);
                command.Parameters.Add("@iMContrato", SqlDbType.BigInt).Value = iMContrato;
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                if (reader.HasRows)
                {
                    SoatCuotas entidad = null;
                    listEntidad = new List<SoatCuotas>();
                    while (reader.Read())
                    {
                        entidad = new SoatCuotas();
                        entidad.tCuota = reader.GetString(0);
                        entidad.tCuotaDetalle = reader.GetString(1);
                        entidad.lEstado = reader.GetInt32(2);
                        entidad.iCuota = reader.GetInt32(3);
                        entidad.iPendiente = reader.GetDecimal(4);
                        entidad.tEvidencia = reader.GetString(5);
                        listEntidad.Add(entidad);
                    }
                }
                reader.Close();
                connection.Close();
            }
            return listEntidad;
        }
        
        public Response DContratoValidacion_Registrar(ContratoValidacion data)
        {
            Response listEntidad = null;
            using (SqlConnection connection = new SqlConnection(Cadena))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("p_api_lm_DContratoValidacion_Registrar", connection);
                command.Parameters.Add("@iMContrato", SqlDbType.BigInt).Value = data.iMContrato;
                command.Parameters.Add("@iMCliente", SqlDbType.BigInt).Value = data.iMCliente;
                command.Parameters.Add("@tCorreo", SqlDbType.VarChar).Value = data.tCorreo;
                command.Parameters.Add("@tTelefono", SqlDbType.VarChar).Value = data.tTelefono;
                command.Parameters.Add("@fNacimiento", SqlDbType.Date).Value = data.fNacimiento;
                command.Parameters.Add("@tNacionalidad", SqlDbType.VarChar).Value = data.tNacionalidad;
                command.Parameters.Add("@iMUbigeo", SqlDbType.VarChar).Value = data.iMUbigeo;
                command.Parameters.Add("@tDireccion", SqlDbType.VarChar).Value = data.tDireccion;
                command.Parameters.Add("@iComprobante", SqlDbType.Int).Value = data.iComprobante;
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        listEntidad = new Response();
                        listEntidad.code = reader.GetInt32(0);
                        listEntidad.message = reader.GetString(1);
                        listEntidad.data = reader.GetInt64(2);
                    }
                }
                reader.Close();
                connection.Close();
            }
            return listEntidad;
        }
        public Response DContratoRequisitoRegistrar(ContratoRequisito data)
        {
            Response listEntidad = null;
            using (SqlConnection connection = new SqlConnection(Cadena))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("f", connection);
                command.Parameters.Add("@iMContrato", SqlDbType.BigInt).Value = data.iMContrato;
                command.Parameters.Add("@tTipo", SqlDbType.VarChar).Value = data.tTipo;
                command.Parameters.Add("@tAdjunto", SqlDbType.VarChar).Value = data.tAdjunto;
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        listEntidad = new Response();
                        listEntidad.code = reader.GetInt32(0);
                        listEntidad.message = reader.GetString(1);
                        listEntidad.data = reader.GetInt64(2);
                    }
                }
                reader.Close();
                connection.Close();
            }
            return listEntidad;
        }
        public Response DContratoCuotaRegistrar(ContratoCuota data)
        {
            Response listEntidad = null;
            using (SqlConnection connection = new SqlConnection(Cadena))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("p_api_lm_DContratoCuota_Registrar", connection);
                command.Parameters.Add("@iMContrato", SqlDbType.BigInt).Value = data.iMContrato;
                command.Parameters.Add("@iCuota", SqlDbType.Int).Value = data.iCuota;
                command.Parameters.Add("@tEvidencia", SqlDbType.VarChar).Value = data.tEvidencia;
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        listEntidad = new Response();
                        listEntidad.code = reader.GetInt32(0);
                        listEntidad.message = reader.GetString(1);
                        listEntidad.data = reader.GetInt64(2);
                    }
                }
                reader.Close();
                connection.Close();
            }
            return listEntidad;
        }
        public Response DContratoRegistrar(Contrato data)
        {
            Response listEntidad = null;
            using (SqlConnection connection = new SqlConnection(Cadena))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("p_api_lm_DContrato_Registrar", connection);
                command.Parameters.Add("@tEmpresaRuc", SqlDbType.VarChar).Value = data.tEmpresaRuc;
                command.Parameters.Add("@iMCotizacion", SqlDbType.BigInt).Value = data.iMCotizacion;
                command.Parameters.Add("@iMTipoPago", SqlDbType.Int).Value = data.iMTipoPago;
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        listEntidad = new Response();
                        listEntidad.code = reader.GetInt32(0);
                        listEntidad.message = reader.GetString(1);
                        listEntidad.data = reader.GetInt64(2);
                    }
                }
                reader.Close();
                connection.Close();
            }
            return listEntidad;
        }

        public Response DCotizacionRegistrar(Cotizacion data)
        {
            Response listEntidad = null;
            using (SqlConnection connection = new SqlConnection(Cadena))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("p_api_lm_DCotizacion_Registrar", connection);
                command.Parameters.Add("@tPlaca", SqlDbType.VarChar).Value = data.tPlaca;
                command.Parameters.Add("@iMClase", SqlDbType.BigInt).Value = data.iMClase;
                command.Parameters.Add("@iMUso", SqlDbType.BigInt).Value = data.iMUso;
                command.Parameters.Add("@iMCategoria", SqlDbType.BigInt).Value = data.iMCategoria;
                command.Parameters.Add("@iMMarca", SqlDbType.BigInt).Value = data.iMMarca;
                command.Parameters.Add("@iMModelo", SqlDbType.BigInt).Value = data.iMModelo;
                command.Parameters.Add("@iMVersion", SqlDbType.BigInt).Value = data.iMVersion;
                command.Parameters.Add("@tSerie", SqlDbType.VarChar).Value = data.tSerie;
                command.Parameters.Add("@iAsientos", SqlDbType.Int).Value = data.iAsientos;
                command.Parameters.Add("@iAnio", SqlDbType.Int).Value = data.iAnio;
                command.Parameters.Add("@iZona", SqlDbType.BigInt).Value = data.iZona;
                command.Parameters.Add("@tCodigo", SqlDbType.VarChar).Value = data.tCodigo;
                command.Parameters.Add("@iMCliente", SqlDbType.BigInt).Value = data.iMCliente;
                command.Parameters.Add("@fNacimiento", SqlDbType.Date).Value = data.fNacimiento;
                command.Parameters.Add("@tNacionalidad", SqlDbType.VarChar).Value = data.tNacionalidad;
                command.Parameters.Add("@tDireccion", SqlDbType.VarChar).Value = data.tDireccion;
                command.Parameters.Add("@tEmail", SqlDbType.VarChar).Value = data.tEmail;
                command.Parameters.Add("@iDepartamento", SqlDbType.Int).Value = data.iDepartamento;
                command.Parameters.Add("@iProvincia", SqlDbType.Int).Value = data.iProvincia;
                command.Parameters.Add("@iDistrito", SqlDbType.Int).Value = data.iDistrito;
                command.Parameters.Add("@tUbigeo", SqlDbType.VarChar).Value = data.tUbigeo;
                command.Parameters.Add("@iComprobante", SqlDbType.Int).Value = data.iComprobante;
                command.Parameters.Add("@tRuc", SqlDbType.VarChar).Value = data.tRuc;
                command.Parameters.Add("@tRucRazon", SqlDbType.VarChar).Value = data.tRucRazon;
                command.Parameters.Add("@tRucDireccion", SqlDbType.VarChar).Value = data.tRucDireccion;
                command.Parameters.Add("@tTipoCotizacion", SqlDbType.VarChar).Value = data.tTipoCotizacion;
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        listEntidad = new Response();
                        listEntidad.code = reader.GetInt32(0);
                        listEntidad.message = reader.GetString(1);
                        listEntidad.data = reader.GetInt64(2);
                    }
                }
                reader.Close();
                connection.Close();
            }
            return listEntidad;
        }

        public Response DContratoActualizar(Contrato data)
        {
            Response listEntidad = null;
            using (SqlConnection connection = new SqlConnection(Cadena))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("p_api_lm_DContrato_update", connection);
                command.Parameters.Add("@iMContrato", SqlDbType.BigInt).Value = data.iMContrato;
                command.Parameters.Add("@tPlaca", SqlDbType.VarChar).Value = data.tPlaca;
                command.Parameters.Add("@tMarca", SqlDbType.VarChar).Value = data.tMarca;
                command.Parameters.Add("@tModelo", SqlDbType.VarChar).Value = data.tModelo;
                command.Parameters.Add("@tSerie", SqlDbType.VarChar).Value = data.tSerie;
                command.Parameters.Add("@tVin", SqlDbType.VarChar).Value = data.tVin;
                command.Parameters.Add("@tMotor", SqlDbType.VarChar).Value = data.tMotor;
                command.Parameters.Add("@iAnio", SqlDbType.Int).Value = data.iAnio;


                command.Parameters.Add("@iMCliente", SqlDbType.BigInt).Value = data.iMCliente;
                command.Parameters.Add("@fNacimiento", SqlDbType.DateTime).Value = data.fNacimiento;
                command.Parameters.Add("@tNacionalidad", SqlDbType.VarChar).Value = data.tNacionalidad;
                command.Parameters.Add("@tDireccion", SqlDbType.VarChar).Value = data.tDireccion;
                command.Parameters.Add("@tEmail", SqlDbType.VarChar).Value = data.tEmail;
                command.Parameters.Add("@iDepartamento", SqlDbType.Int).Value = data.iDepartamento;
                command.Parameters.Add("@iProvincia", SqlDbType.Int).Value = data.iProvincia;
                command.Parameters.Add("@iDistrito", SqlDbType.Int).Value = data.iDistrito;
                command.Parameters.Add("@tUbigeo", SqlDbType.VarChar).Value = data.tUbigeo;

                command.Parameters.Add("@iComprobante", SqlDbType.Int).Value = data.iComprobante;
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        listEntidad = new Response();
                        listEntidad.code = reader.GetInt32(0);
                        listEntidad.message = reader.GetString(1);
                        listEntidad.data = reader.GetInt64(2);
                    }
                }
                reader.Close();
                connection.Close();
            }
            return listEntidad;
        }

        public List<SoatPrecio> DPrecioSoat_Listar(String tOrigen, int iPago)
        {
            List<SoatPrecio> listEntidad = null;
            using (SqlConnection connection = new SqlConnection(Cadena))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("p_api_lm_DPrecioSoat_Listar", connection);
                command.Parameters.Add("@tOrigen", SqlDbType.VarChar).Value = tOrigen;
                command.Parameters.Add("@iPago", SqlDbType.Int).Value = iPago;
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                if (reader.HasRows)
                {
                    SoatPrecio entidad = null;
                    listEntidad = new List<SoatPrecio>();
                    while (reader.Read())
                    {
                        entidad = new SoatPrecio();
                        entidad.iPrecio = reader.GetDecimal(0);

                        listEntidad.Add(entidad);
                    }
                }
                reader.Close();
                connection.Close();
            }
            return listEntidad;
        }
        public List<Contrato> DDatosPersonsalesContrato_Listar(Int64 iMContrato)
        {
            List<Contrato> listEntidad = null;
            using (SqlConnection connection = new SqlConnection(Cadena))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("p_api_lm_DDatosPersonsalesContrato_Listar", connection);
                command.Parameters.Add("@iMContrato", SqlDbType.BigInt).Value = iMContrato;
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                if (reader.HasRows)
                {
                    Contrato entidad = null;
                    listEntidad = new List<Contrato>();
                    while (reader.Read())
                    {
                        entidad = new Contrato();
                        entidad.tContrato = reader.GetString(0);
                        entidad.tPlaca = reader.GetString(1);
                        entidad.tMarca = reader.GetString(2);
                        entidad.tModelo = reader.GetString(3);
                        entidad.tSerie = reader.GetString(4);
                        entidad.tVin = reader.GetString(5);
                        entidad.tMotor = reader.GetString(6);
                        entidad.iAnio = reader.GetInt32(7);
                        entidad.iPrecioSoat = reader.GetDecimal(8);
                        entidad.tCotOrigen = reader.GetString(9);
                        entidad.iMTipoPago = reader.GetInt32(10);
                        entidad.iMCliente = reader.GetInt64(11);
                        entidad.tNacimiento = reader.GetString(12);
                        entidad.tNacionalidad = reader.GetString(13);
                        entidad.tDireccion = reader.GetString(14);
                        entidad.tEmail = reader.GetString(15);
                        entidad.iDepartamento = reader.GetInt32(16);
                        entidad.iProvincia = reader.GetInt32(17);
                        entidad.iDistrito = reader.GetInt32(18);
                        entidad.iComprobante = reader.GetInt32(19);
                        listEntidad.Add(entidad);
                    }
                }
                reader.Close();
                connection.Close();
            }
            return listEntidad;
        }

        public List<Clase> MClase_Listar()
        {
            List<Clase> listEntidad = null;
            using (SqlConnection connection = new SqlConnection(Cadena))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("p_api_lm_MClase_Listar", connection);
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                if (reader.HasRows)
                {
                    Clase entidad = null;
                    listEntidad = new List<Clase>();
                    while (reader.Read())
                    {
                        entidad = new Clase();
                        entidad.iMClase = reader.GetInt64(0);
                        entidad.tClase = reader.GetString(1);
                        listEntidad.Add(entidad);
                    }
                }
                reader.Close();
                connection.Close();
            }
            return listEntidad;
        }
        public List<Categoria> MCategoria_Listar()
        {
            List<Categoria> listEntidad = null;
            using (SqlConnection connection = new SqlConnection(Cadena))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("p_api_lm_MCategoria_Listar", connection);
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                if (reader.HasRows)
                {
                    Categoria entidad = null;
                    listEntidad = new List<Categoria>();
                    while (reader.Read())
                    {
                        entidad = new Categoria();
                        entidad.iMCategoria = reader.GetInt64(0);
                        entidad.tCategoria = reader.GetString(1);
                        listEntidad.Add(entidad);
                    }
                }
                reader.Close();
                connection.Close();
            }
            return listEntidad;
        }
        public List<Marca> MMarca_Listar()
        {
            List<Marca> listEntidad = null;
            using (SqlConnection connection = new SqlConnection(Cadena))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("p_api_lm_MMarca_Listar", connection);
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                if (reader.HasRows)
                {
                    Marca entidad = null;
                    listEntidad = new List<Marca>();
                    while (reader.Read())
                    {
                        entidad = new Marca();
                        entidad.iMMarca = reader.GetInt64(0);
                        entidad.tMarca = reader.GetString(1);
                        listEntidad.Add(entidad);
                    }
                }
                reader.Close();
                connection.Close();
            }
            return listEntidad;
        }

        public List<Modelo> MModelo_Listar(Int64 iMMarca)
        {
            List<Modelo> listEntidad = null;
            using (SqlConnection connection = new SqlConnection(Cadena))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("p_api_lm_MModelo_Listar", connection);
                command.Parameters.Add("@iMMarca", SqlDbType.BigInt).Value = iMMarca;
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                if (reader.HasRows)
                {
                    Modelo entidad = null;
                    listEntidad = new List<Modelo>();
                    while (reader.Read())
                    {
                        entidad = new Modelo();
                        entidad.iMModelo = reader.GetInt64(0);
                        entidad.tModelo = reader.GetString(1);
                        listEntidad.Add(entidad);
                    }
                }
                reader.Close();
                connection.Close();
            }
            return listEntidad;
        }
        public List<VersionModelo> MVersion_Listar(Int64 iMModelo)
        {
            List<VersionModelo> listEntidad = null;
            using (SqlConnection connection = new SqlConnection(Cadena))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("p_api_lm_MVersion_Listar", connection);
                command.Parameters.Add("@iMModelo", SqlDbType.BigInt).Value = iMModelo;
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                if (reader.HasRows)
                {
                    VersionModelo entidad = null;
                    listEntidad = new List<VersionModelo>();
                    while (reader.Read())
                    {
                        entidad = new VersionModelo();
                        entidad.iMVersion = reader.GetInt64(0);
                        entidad.tVersion = reader.GetString(1);
                        listEntidad.Add(entidad);
                    }
                }
                reader.Close();
                connection.Close();
            }
            return listEntidad;
        }

        public List<CotizacionCliente> DCotizacionCliente_Listar(Int64 iMCliente)
        {
            List<CotizacionCliente> listEntidad = null;
            using (SqlConnection connection = new SqlConnection(Cadena))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("p_api_lm_DCotizacion_Listar", connection);
                command.Parameters.Add("@iMCliente", SqlDbType.BigInt).Value = iMCliente;
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                if (reader.HasRows)
                {
                    CotizacionCliente entidad = null;
                    listEntidad = new List<CotizacionCliente>();
                    while (reader.Read())
                    {
                        entidad = new CotizacionCliente();
                        entidad.iMCotizacion = reader.GetInt64(0);
                        entidad.tPlaca = reader.GetString(1);
                        entidad.iEstado = reader.GetInt32(2);
                        entidad.tEstado = reader.GetString(3);
                        entidad.tCodigo = reader.GetString(4);
                        entidad.iPrecioContado = reader.GetDecimal(5);
                        entidad.iPrecioCredito = reader.GetDecimal(6);
                        entidad.iMVehiculo = reader.GetInt64(7);
                        entidad.tFechaMod = reader.GetString(8);
                        entidad.tMotivoRechazo = reader.GetString(9);
                        entidad.tUsuarioMod = reader.GetString(10);
                        listEntidad.Add(entidad);
                    }
                }
                reader.Close();
                connection.Close();
            }
            return listEntidad;
        }

        public List<DataCliente> DDataCliente_Listar(Int64 iMCliente, string tTipo, Int64 iD)
        {
            List<DataCliente> listEntidad = null;
            using (SqlConnection connection = new SqlConnection(Cadena))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("p_api_lm_DDataCliente_Listar", connection);
                command.Parameters.Add("@iMCliente", SqlDbType.BigInt).Value = iMCliente;
                command.Parameters.Add("@tTipo", SqlDbType.VarChar).Value = tTipo;
                command.Parameters.Add("@iD", SqlDbType.BigInt).Value = iD;
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                if (reader.HasRows)
                {
                    DataCliente entidad = null;
                    listEntidad = new List<DataCliente>();
                    while (reader.Read())
                    {
                        entidad = new DataCliente();
                        entidad.tCliente = reader.GetString(0);
                        entidad.tNacimiento = reader.GetString(1);
                        entidad.tNacionalidad = reader.GetString(2);
                        entidad.tDireccion = reader.GetString(3);
                        entidad.tCorreo = reader.GetString(4);
                        entidad.tDepartamento = reader.GetString(5);
                        entidad.tProvincia = reader.GetString(6);
                        entidad.tDistrito = reader.GetString(7);
                        entidad.tRuc = reader.GetString(8);
                        entidad.tRucRazon = reader.GetString(9);
                        entidad.tRucDireccion = reader.GetString(10);
                        listEntidad.Add(entidad);
                    }
                }
                reader.Close();
                connection.Close();
            }
            return listEntidad;
        }
        public List<DataVehiculo> DDataVehiculo_Listar(Int64 iMVehiculo, string tTipo)
        {
            List<DataVehiculo> listEntidad = null;
            using (SqlConnection connection = new SqlConnection(Cadena))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("p_api_lm_DDataVehiculo_Listar", connection);
                command.Parameters.Add("@iMVehiculo", SqlDbType.BigInt).Value = iMVehiculo;
                command.Parameters.Add("@tTipo", SqlDbType.VarChar).Value = tTipo;
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                if (reader.HasRows)
                {
                    DataVehiculo entidad = null;
                    listEntidad = new List<DataVehiculo>();
                    while (reader.Read())
                    {
                        entidad = new DataVehiculo();
                        entidad.tPlaca = reader.GetString(0);
                        entidad.tClase = reader.GetString(1);
                        entidad.tUso = reader.GetString(2);
                        entidad.tCategoria = reader.GetString(3);
                        entidad.tMarca = reader.GetString(4);
                        entidad.tModelo = reader.GetString(5);
                        entidad.tVersion = reader.GetString(6);
                        entidad.tSerie = reader.GetString(7);
                        entidad.tAsiento = reader.GetString(8);
                        entidad.tAnio = reader.GetString(9);
                        entidad.tZona = reader.GetString(10);
                        listEntidad.Add(entidad);
                    }
                }
                reader.Close();
                connection.Close();
            }
            return listEntidad;
        }
        public List<returnId> ActualizarCaracteristicas(string? marca, string? modelo, string? clase, string? uso)
        {
            List<returnId> listEntidad = null;
            using (SqlConnection connection = new SqlConnection(Cadena))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("p_api_lm_MActualizarCaracteristicas", connection);
                command.Parameters.Add("@marca", SqlDbType.VarChar).Value = marca;
                command.Parameters.Add("@modelo", SqlDbType.VarChar).Value = modelo;
                command.Parameters.Add("@clase", SqlDbType.VarChar).Value = clase;
                command.Parameters.Add("@uso", SqlDbType.VarChar).Value = uso;
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                if (reader.HasRows)
                {
                    returnId entidad = null;
                    listEntidad = new List<returnId>();
                    while (reader.Read())
                    {
                        entidad = new returnId();
                        entidad.iMMarca = reader.GetInt64(0);
                        entidad.iMModelo = reader.GetInt64(1);
                        entidad.iMClase = reader.GetInt64(2);
                        entidad.iMUso = reader.GetInt64(3);
                        listEntidad.Add(entidad);
                    }
                }
                reader.Close();
                connection.Close();
            }
            return listEntidad;
        }

        public List<Soat> DescargaSoat(Int64 iMContrato)
        {
            List<Soat> listEntidad = null;
            using (SqlConnection connection = new SqlConnection(Cadena))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("p_api_lm_MDescargaSoat", connection);
                command.Parameters.Add("@iMContrato", SqlDbType.BigInt).Value = iMContrato;
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                if (reader.HasRows)
                {
                    Soat entidad = null;
                    listEntidad = new List<Soat>();
                    while (reader.Read())
                    {
                        entidad = new Soat();
                        entidad.tSoatbase64 = reader.GetString(0);
                        listEntidad.Add(entidad);
                    }
                }
                reader.Close();
                connection.Close();
            }
            return listEntidad;
        }

        public List<Asesor> contactarAsesorCotizacion(Int64 iMUsuario, string tOrigen, Int64 iId)
        {
            List<Asesor> listEntidad = null;
            using (SqlConnection connection = new SqlConnection(Cadena))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("p_api_lm_MContactarAsesor", connection);
                command.Parameters.Add("@iMUsuario", SqlDbType.BigInt).Value = iMUsuario;
                command.Parameters.Add("@tOrigen", SqlDbType.VarChar).Value = tOrigen;
                command.Parameters.Add("@iId", SqlDbType.BigInt).Value = iId;
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                if (reader.HasRows)
                {
                    Asesor entidad = null;
                    listEntidad = new List<Asesor>();
                    while (reader.Read())
                    {
                        entidad = new Asesor();
                        entidad.tMensaje = reader.GetString(0);
                        listEntidad.Add(entidad);
                    }
                }
                reader.Close();
                connection.Close();
            }
            return listEntidad;
        }

        public Response DPagoExterno(PagoExterno data)
        {
            Response listEntidad = null;
            using (SqlConnection connection = new SqlConnection(Cadena))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("p_api_lm_DPagoExterno", connection);
                command.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = data.Telefono;
                command.Parameters.Add("@Monto", SqlDbType.Decimal).Value = data.Monto;
                command.Parameters.Add("@Fecha", SqlDbType.VarChar).Value = data.Fecha;
                command.Parameters.Add("@Hora", SqlDbType.VarChar).Value = data.Hora;
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        listEntidad = new Response();
                        listEntidad.code = reader.GetInt32(0);
                        listEntidad.message = reader.GetString(1);
                    }
                }
                reader.Close();
                connection.Close();
            }
            return listEntidad;
        }
        public List<SoatCliente> ContratoporId(Int64 iMContrato)
        {
            List<SoatCliente> listEntidad = null;
            using (SqlConnection connection = new SqlConnection(Cadena))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("p_api_lm_DContratoporId", connection);
                command.Parameters.Add("@iMContrato", SqlDbType.BigInt).Value = iMContrato;
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                if (reader.HasRows)
                {
                    SoatCliente entidad = null;
                    listEntidad = new List<SoatCliente>();
                    while (reader.Read())
                    {
                        entidad = new SoatCliente();
                        entidad.iMContrato = reader.GetInt64(0);
                        entidad.tPlaca = reader.GetString(1);
                        entidad.iPendiente = reader.GetDecimal(2);
                        entidad.iEstado = reader.GetInt32(3);
                        entidad.tEstado = reader.GetString(4);
                        entidad.iMVehiculo = reader.GetInt64(5);
                        entidad.iPrecioSoat = reader.GetDecimal(6);
                        entidad.iTipoPago = reader.GetInt32(7);
                        entidad.tPagoCuotas = reader.GetString(8);
                        entidad.tVencimiento = reader.GetString(9); 
                        listEntidad.Add(entidad);
                    }
                }
                reader.Close();
                connection.Close();
            }
            return listEntidad;
        }

        public List<CuentaPago> GetCuentaPago_Listar()
        {
            List<CuentaPago> listEntidad = null;
            using (SqlConnection connection = new SqlConnection(Cadena))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("p_api_lm_DCuentaPago_Listar", connection);
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                if (reader.HasRows)
                {
                    CuentaPago entidad = null;
                    listEntidad = new List<CuentaPago>();
                    while (reader.Read())
                    {
                        entidad = new CuentaPago();
                        entidad.idCuenta = reader.GetInt64(0);
                        entidad.tOrigen = reader.GetString(1);
                        entidad.tCuenta = reader.GetString(2);
                        entidad.tLogo = reader.GetString(3);
                        listEntidad.Add(entidad);
                    }
                }
                reader.Close();
                connection.Close();
            }
            return listEntidad;
        }

        public SoatPdf RegistrarPDFSoat(Int64? IDOperacion, string tRutaPdf)
        {
            SoatPdf entidad = null;
            using (SqlConnection connection = new SqlConnection(Cadena))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("p_api_lm_PdfSoat_Registrar", connection);
                command.Parameters.Add("@IDOperacion", SqlDbType.BigInt).Value = IDOperacion;
                command.Parameters.Add("@tRutaPdf", SqlDbType.NChar).Value = tRutaPdf;
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        entidad = new SoatPdf();
                        entidad.IDOportunidad = reader.GetInt64(0);
                        entidad.tRutaPdf = reader.GetString(1);
                    }
                }
                reader.Close();
                connection.Close();
            }
            return entidad;
        }


        public SoatCotizacion RegistrarCotizacionSoat(SoatCotizacion cotizacion)
        {
            SoatCotizacion entidad = null;
            using (SqlConnection connection = new SqlConnection(Cadena))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("p_api_lm_CotizacionSoat_Registrar", connection);
                command.Parameters.Add("@IDOportunidad", SqlDbType.BigInt).Value = cotizacion.IDOportunidad;
                command.Parameters.Add("@tTarifaTotal", SqlDbType.Decimal).Value = cotizacion.tarifaTotal;
                command.Parameters.Add("@tTarifaSemanal", SqlDbType.Decimal).Value = cotizacion.tarifaSemanal;
                command.Parameters.Add("@tInteres", SqlDbType.Decimal).Value = cotizacion.interes;
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        entidad = new SoatCotizacion();
                        entidad.IDOportunidad = reader.GetInt64(1);
                        entidad.tarifaSemanal = reader.GetDecimal(3);
                        entidad.tarifaTotal = reader.GetDecimal(4);
                        entidad.interes = reader.GetDecimal(5);
                    }
                }
                reader.Close();
                connection.Close();
            }
            return entidad;
        }
    }
}
