using ApiLMotos.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLMotos.DbHandle
{
    public class MaestroDb : GeneralDb
    {
        public List<MDepartamento> MDepartamento_Listar()
        {
            List<MDepartamento> listEntidad = null;
            using (SqlConnection connection = new SqlConnection(Cadena))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("wsp_Departamento_Listar", connection);
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                if (reader.HasRows)
                {
                    MDepartamento entidad = null;
                    listEntidad = new List<MDepartamento>();
                    while (reader.Read())
                    {
                        entidad = new MDepartamento();
                        entidad.iDepartamento = reader.GetInt32(0);
                        entidad.tDepartamento = reader.GetString(1);
                        listEntidad.Add(entidad);
                    }
                }

                reader.Close();
                connection.Close();
            }
            return listEntidad;
        }
        public List<MMProvincia> MProvincia_Listar(int iDepartamentoUbigeo)
        {
            List<MMProvincia> listEntidad = null;
            using (SqlConnection connection = new SqlConnection(Cadena))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("wsp_Provincia_Listar", connection);
                command.Parameters.Add("@iDepartamentoUbigeo", SqlDbType.Int).Value = iDepartamentoUbigeo;
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                if (reader.HasRows)
                {
                    MMProvincia entidad = null;
                    listEntidad = new List<MMProvincia>();
                    while (reader.Read())
                    {
                        entidad = new MMProvincia();
                        entidad.iMProvincia = reader.GetInt32(0);
                        entidad.tMProvincia = reader.GetString(1);
                        listEntidad.Add(entidad);
                    }
                }

                reader.Close();
                connection.Close();
            }
            return listEntidad;
        }
        public List<MDistrito> MDistrito_Listar(int iDepartamentoUbigeo, int iProvinciaUbigeo)
        {
            List<MDistrito> listEntidad = null;
            using (SqlConnection connection = new SqlConnection(Cadena))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("wsp_Distrito_Listar", connection);
                command.Parameters.Add("@iDepartamentoUbigeo", SqlDbType.Int).Value = iDepartamentoUbigeo;
                command.Parameters.Add("@iProvinciaUbigeo", SqlDbType.Int).Value = iProvinciaUbigeo;
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                if (reader.HasRows)
                {
                    MDistrito entidad = null;
                    listEntidad = new List<MDistrito>();
                    while (reader.Read())
                    {
                        entidad = new MDistrito();
                        entidad.iDistrito = reader.GetInt32(0);
                        entidad.tDistrito = reader.GetString(1);
                        listEntidad.Add(entidad);
                    }
                }

                reader.Close();
                connection.Close();
            }
            return listEntidad;
        }
        public List<MTipoDocumentoIdentidad> MTipoDocumentoIdentidad_Listar()
        {
            List<MTipoDocumentoIdentidad> listEntidad = null;
            using (SqlConnection connection = new SqlConnection(Cadena))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("p_gf_MTipoDocumentoIdentidad_Listar", connection);
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                if (reader.HasRows)
                {
                    MTipoDocumentoIdentidad entidad = null;
                    listEntidad = new List<MTipoDocumentoIdentidad>();
                    while (reader.Read())
                    {
                        entidad = new MTipoDocumentoIdentidad();
                        entidad.iMTipoDocumentoIdentidad = reader.GetString(0);
                        entidad.tDescripcion = reader.GetString(1);
                        listEntidad.Add(entidad);
                    }
                }

                reader.Close();
                connection.Close();
            }
            return listEntidad;
        }
        public List<MCliente> MCliente_Buscar_Por_NroDoc(string tNroDocumento, string Empresa)
        {
            List<MCliente> listEntidad = null;
            using (SqlConnection connection = new SqlConnection(Cadena))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("p_api_MCliente_Buscar_Por_NroDoc", connection);
                command.Parameters.Add("@tNroDocumento", SqlDbType.VarChar).Value = tNroDocumento;
                command.Parameters.Add("@tRucEmpresa", SqlDbType.VarChar).Value = Empresa;
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                if (reader.HasRows)
                {
                    MCliente entidad = null;
                    listEntidad = new List<MCliente>();
                    while (reader.Read())
                    {
                        entidad = new MCliente();
                        entidad.iMCliente = reader.GetInt64(0);
                        entidad.tNroDocumento = reader.GetString(1);
                        entidad.tNombre = reader.GetString(2);
                        entidad.tDireccion = reader.GetString(3);
                        entidad.tCorreo = reader.GetString(4);
                        entidad.iMTipoDocumentoIdentidad = reader.GetString(5);
                        entidad.tTelefonoPrincipal = reader.GetString(6);
                        listEntidad.Add(entidad);
                    }
                }

                reader.Close();
                connection.Close();
            }
            return listEntidad;
        }
    }
}
