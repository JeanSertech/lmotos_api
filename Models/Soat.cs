﻿using System.Collections.Generic;
using System;
using System.Runtime.CompilerServices;

namespace ApiLMotos.Models
{
    public class Zona
    {
        public Int64? iMZona { get; set; }
        public string? tZona { get; set; }
    }
    public class Uso
    {
        public Int64? iMUso { get; set; }
        public string? tUso { get; set; }
    }
    public class Clase
    {
        public Int64? iMClase { get; set; }
        public string? tClase { get; set; }
    }
    public class Categoria
    {
        public Int64? iMCategoria { get; set; }
        public string? tCategoria { get; set; }
    }
    public class Marca
    {
        public Int64? iMMarca { get; set; }
        public string? tMarca { get; set; }
    }
    public class Modelo
    {
        public Int64? iMModelo { get; set; }
        public string? tModelo { get; set; }
    }
    public class VersionModelo
    {
        public Int64? iMVersion { get; set; }
        public string? tVersion { get; set; }
    }
    public class SoatCliente
    {
        public Int64? iMContrato { get; set; }
        public string? tPlaca { get; set; }
        public decimal? iPendiente { get; set; }
        public int? iEstado { get; set; }
        public string? tEstado { get; set; }
        public Int64? iMVehiculo { get; set; }
        public decimal? iPrecioSoat { get; set; }
        public int? iTipoPago { get; set; }
        public string? tPagoCuotas { get; set; }
        public string? tVencimiento { get; set; }
        public Int64? iMCotizacion { get; set; }

    }
    public class CotizacionCliente
    {
        public Int64? iMCotizacion { get; set; }
        public string? tPlaca { get; set; }
        public int? iEstado { get; set; }
        public string? tEstado { get; set; }
        public string? tCodigo { get; set; }
        public decimal? iPrecioContado { get; set; }
        public decimal? iPrecioCredito { get; set; }
        public Int64? iMVehiculo { get; set; }
        public string? tFechaMod { get; set; }
        public string? tMotivoRechazo { get; set; }
        public string? tUsuarioMod { get; set; }
        public decimal? iPrecioTarifa { get; set; }
        public string? tMessage { get; set; }
    }
    public class SoatRequisitos
    {
        public string? tTipo { get; set; }
        public string? tTipoDetalle { get; set; }
        public int? lEstado { get; set; }
        public string? tEstado { get; set; }
        public string? tEVidencia { get; set; }
        public string? tMotivo { get; set; }
    }
    public class SoatCuotas
    {
        public string? tCuota { get; set; }
        public string? tCuotaDetalle { get; set; }
        public int? lEstado { get; set; }
        public int? iCuota { get; set; }
        public decimal? iPendiente { get; set; }
        public string? tEvidencia { get; set; }
    }

    public class SoatPrecio
    {
        public decimal? iPrecio { get; set; }
    }
    public class ClienteRegistrar
    {
        public string? iMTipoDoc { get; set; }
        public string? tNroDoc { get; set; }
        public string? tNombre { get; set; }
        public string? tTelefono { get; set; }
        public string? tCiudad { get; set; }
        public string? tCorreo { get; set; }
        public string? tPassword { get; set; }
        public string? tNacimiento { get; set; }
        public string? tUbigeo { get; set; }
        public string? tDepartamento { get; set; }
        public string? tProvincia { get; set; }
        public string? tDistrito { get; set; }
        public string? tDireccion { get; set; }
    }
    public class ContratoValidacion
    {
        public Int64? iMContrato { get; set; }
        public Int64? iMCliente { get; set; }
        public string? tCorreo { get; set; }
        public string? tTelefono { get; set; }
        public DateTime? fNacimiento { get; set; }
        public string? tNacionalidad { get; set; }
        public string? iMUbigeo { get; set; }
        public string? tDireccion { get; set; }
        public int? iComprobante { get; set; }
    }
    public class ContratoRequisito
    {
        public Int64? iMContrato { get; set; }
        public string? tTipo { get; set; }
        public string? tAdjunto { get; set; }
    }
    public class ContratoCuota
    {
        public Int64? iMContrato { get; set; }
        public int? iCuota { get; set; }
        public string? tEvidencia { get; set; }
    }
    public class ContratoCuotaNew
    {
        public Int64? iMContrato { get; set; }
        public int? iCuota { get; set; }
    }
    public class Contrato
    {
        public Int64? iMCotizacion { get; set; }
        public Int64? iMContrato { get; set; }
        public string? tContrato { get; set; }
        public string? tEmpresaRuc { get; set; }
        public string? tPlaca { get; set; }
        public string? tMarca { get; set; }
        public string? tModelo { get; set; }
        public string? tSerie { get; set; }
        public string? tVin { get; set; }
        public string? tMotor { get; set; }
        public int? iAnio { get; set; }
        public decimal? iPrecioSoat { get; set; }
        public string? tCotOrigen { get; set; }
        public int? iMTipoPago { get; set; }
        public Int64? iMCliente { get; set; }
        public string? tNacimiento { get; set; }
        public DateTime? fNacimiento { get; set; }
        public string? tNacionalidad { get; set; }
        public string? tDireccion { get; set; }
        public string? tEmail { get; set; }
        public int? iDepartamento { get; set; }
        public int? iProvincia { get; set; }
        public int? iDistrito { get; set; }
        public string? tUbigeo { get; set; }
        public int? iComprobante { get; set; }
    }

    public class Cotizacion
    {
        public string? tPlaca { get; set; }
        public Int64? iMClase { get; set; }
        public Int64? iMUso { get; set; }
        public Int64? iMCategoria { get; set; }
        public Int64? iMMarca { get; set; }
        public Int64? iMModelo { get; set; }
        public Int64? iMVersion { get; set; }
        public string? tSerie { get; set; }
        public int? iAsientos { get; set; }
        public int? iAnio { get; set; }
        public Int64? iZona { get; set; }
        public string? tCodigo { get; set; }
        public int? iTipoPago { get; set; }
        public Int64? iMCliente { get; set; }
        public DateTime? fNacimiento { get; set; }
        public string? tNacionalidad { get; set; }
        public string? tDireccion { get; set; }
        public string? tEmail { get; set; }
        public int? iDepartamento { get; set; }
        public int? iProvincia { get; set; }
        public int? iDistrito { get; set; }
        public string? tUbigeo { get; set; }
        public int? iComprobante { get; set; }
        public string? tTipoCotizacion { get; set; }
        public string? tRuc { get; set; }
        public string? tRucRazon { get; set; }
        public string? tRucDireccion { get; set; }
        public string? tCiudad { get; set; }
        public string? tipoCotizacion { get; set; }
    }

    public class Vehiculo
    {
        public Int64? iMVehiculo { get; set; }
        public string? tPlaca { get; set; }
        public string? tMarca { get; set; }
        public string? tSerie { get; set; }
        public string? tVin { get; set; }
        public string? tMotor { get; set; }
        public string? tColor { get; set; }
        public Int32? iAnio { get; set; }
        public string? tModelo { get; set; }
    }
    public class DataCliente
    {
        public string? tCliente { get; set; }
        public string? tNacimiento { get; set; }
        public string? tNacionalidad { get; set; }
        public string? tDireccion { get; set; }
        public string? tCorreo { get; set; }
        public string? tDepartamento { get; set; }
        public string? tProvincia { get; set; }
        public string? tDistrito { get; set; }
        public string? tRuc { get; set; }
        public string? tRucRazon { get; set; }
        public string? tRucDireccion { get; set; }
    }

    public class DataVehiculo
    {
        public string? tPlaca { get; set; }
        public string? tClase { get; set; }
        public string? tUso { get; set; }
        public string? tCategoria { get; set; }
        public string? tMarca { get; set; }
        public string? tModelo { get; set; }
        public string? tVersion { get; set; }
        public string? tSerie { get; set; }
        public string? tAsiento { get; set; }
        public string? tAnio { get; set; }
        public string? tZona { get; set; }
    }
    public class returnId
    {
        public Int64? iMMarca { get; set; }
        public Int64? iMModelo { get; set; }
        public Int64? iMClase { get; set; }
        public Int64? iMUso { get; set; }
    }
    public class Soat
    {
        public string? tSoatbase64 { get; set; }
    }

    public class Asesor
    {
        public string? tNombre { get; set; }
        public string? tTelefono { get; set; }
        public string? tCorreo { get; set; }
        public string? tMensaje { get; set; }
    }

    public class PagoExterno
    {
        public string? Telefono { get; set; }
        public decimal? Monto { get; set; }
        public string? Fecha { get; set; }
        public string? Hora { get; set; }
    }

    public class CuentaPago
    {
        public Int64? idCuenta { get; set; }
        public string? tOrigen { get; set; }
        public string? tCuenta { get; set; }
        public string? tLogo { get; set; }
    }
    public class SoatPdf
    {
        public Int64 IDOportunidad { get; set; }
        public string tRutaPdf { get; set;}
    }

    public class SoatCotizacion
    {
        public Int64 IDOportunidad { get; set; }
        public decimal tarifaSemanal { get; set; }
        public decimal tarifaTotal { get; set; }
        public decimal interes { get; set; }
        public Int64 code { get; set; }

        public string message { get; set; }

    }
}
