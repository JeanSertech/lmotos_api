﻿using ApiLMotos.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLMotos.DbHandle
{
    public class SeguridadDb : GeneralDb
    {
        public UsuarioApi UsuarioApi_Validar(string tUsuario, string tPassword)
        {
            UsuarioApi entidad = null;
            using (SqlConnection connection = new SqlConnection(Cadena))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("p_api_rest_UsuarioApi_Token", connection);
                command.Parameters.Add("@tUsuario", SqlDbType.VarChar).Value = tUsuario;
                command.Parameters.Add("@tPassword", SqlDbType.VarChar).Value = tPassword;
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        entidad = new UsuarioApi();
                        entidad.iUsuarioApi = reader.GetInt64(0);
                        entidad.tMessage = reader.GetString(1);
                        entidad.iEstado = reader.GetInt32(2);
                        entidad.tVersionAndroid = reader.GetString(3);
                        entidad.tVersionIOS = reader.GetString(4);
                        entidad.accountSid = reader.GetString(5);
                        entidad.authToken = reader.GetString(6);
                        entidad.twilioNumber = reader.GetString(7);
                    }
                }
                reader.Close();
                connection.Close();
            }
            return entidad;
        }
        public Usuario Usuario_IniciarSession(string tUsuario, string tPassword)
        {
            Usuario entidad = null;
            using (SqlConnection connection = new SqlConnection(Cadena))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("p_api_lm_MUsuario_IniciarSession", connection);
                command.Parameters.Add("@tUsuario", SqlDbType.VarChar).Value = tUsuario;
                command.Parameters.Add("@tPassword", SqlDbType.VarChar).Value = tPassword;
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        entidad = new Usuario();
                        entidad.iMCliente = reader.GetInt64(0);
                        entidad.tNombre = reader.GetString(1);
                        entidad.tNroDocumento = reader.GetString(2);
                        entidad.tTelefonoPrincipal = reader.GetString(3);
                        entidad.iMTipoDocumentoIdentidad = reader.GetString(4);
                        entidad.tTipoDocumentoIdentidad = reader.GetString(5);
                        entidad.tCiudad = reader.GetString(6);
                        entidad.tCorreo = reader.GetString(7);
                        entidad.fFechaNacimiento = reader.GetString(8);
                        entidad.tDireccion = reader.GetString(9);
                        entidad.tNacionalidad = reader.GetString(10);
                        entidad.iDepartamento = reader.GetInt32(11);
                        entidad.iProvincia = reader.GetInt32(12);
                        entidad.iDistrito = reader.GetInt32(13);
                        
                    }
                }
                reader.Close();
                connection.Close();
            }
            return entidad;
        }

        public Response DCliente_Registrar(ClienteRegistrar data,string clave)
        {
            Response listEntidad = null;
            using (SqlConnection connection = new SqlConnection(Cadena))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("p_api_lm_DCliente_Registrar_v2", connection);
                command.Parameters.Add("@iMTipoDoc", SqlDbType.VarChar).Value = data.iMTipoDoc;
                command.Parameters.Add("@tNroDoc", SqlDbType.VarChar).Value = data.tNroDoc;
                command.Parameters.Add("@tNombre", SqlDbType.VarChar).Value = data.tNombre;
                command.Parameters.Add("@tTelefono", SqlDbType.VarChar).Value = data.tTelefono;
                command.Parameters.Add("@tCiudad", SqlDbType.VarChar).Value = data.tCiudad;
                command.Parameters.Add("@tCorreo", SqlDbType.VarChar).Value = data.tCorreo;
                command.Parameters.Add("@tPassword", SqlDbType.VarChar).Value = clave;
                command.Parameters.Add("@tNacimiento", SqlDbType.VarChar).Value = data.tNacimiento;
                command.Parameters.Add("@tUbigeo", SqlDbType.VarChar).Value = data.tUbigeo;
                command.Parameters.Add("@tDepartamento", SqlDbType.VarChar).Value = data.tDepartamento;
                command.Parameters.Add("@tProvincia", SqlDbType.VarChar).Value = data.tProvincia;
                command.Parameters.Add("@tDistrito", SqlDbType.VarChar).Value = data.tDistrito;
                command.Parameters.Add("@tDireccion", SqlDbType.VarChar).Value = data.tDireccion;
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

        public Response DTelefonoRecuperar(ClienteRegistrar data, string clave)
        {
            Response listEntidad = null;
            using (SqlConnection connection = new SqlConnection(Cadena))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("p_api_lm_DTelefonoRecuperar", connection);
                command.Parameters.Add("@tTelefono", SqlDbType.VarChar).Value = data.tTelefono;
                command.Parameters.Add("@tPassword", SqlDbType.VarChar).Value = clave;
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
    }
}
