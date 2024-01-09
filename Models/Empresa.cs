﻿using System;

namespace ApiLMotos.Models
{
    public class Empresa
    {
        public string Ruc { get; set; }
        public string NombreEmpresa { get; set; }
        public string Comercial { get; set; }
        public string Direccion { get; set; }
        public string Distrito { get; set; }
        public string Provincia { get; set; }
        public string Region { get; set; }
        public string Telefono { get; set; }
        public string Resolucion { get; set; }
        public string Web { get; set; }
        public string Email { get; set; }
        public string Codigo { get; set; }
        public string Perfil { get; set; }
        public string Logo { get; set; }
        public string Banner { get; set; }
        public Decimal Detraccion { get; set; }
        public string DetraccionText { get; set; }
        public string Zona { get; set; }
        public int Status { get; set; }
        public bool INC_IGV { get; set; }
        public bool ExoneraIgv { get; set; }
        public bool lVistaPrevia { get; set; }
        public bool Remision { get; set; }
        public bool lv_PrecioUnitario { get; set; }
        public bool lv_PrecioValor { get; set; }
        public bool lv_PrecioVenta { get; set; }
        public bool Requerimiento { get; set; }
        public bool lv_IGV { get; set; }
        public bool lv_Descuento { get; set; }
        public int Comprobante { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string LogoExterno { get; set; }
        public int iLimite { get; set; }
        public int Alerta { get; set; }
        public int UbigeoDistrito { get; set; }
        public int UbigeoProvincia { get; set; }
        public int UbigeoDepartamento { get; set; }
        public bool lenv_Correo_Auto { get; set; }
        public bool lv_PlacaVehiculo { get; set; }
        public bool lpFormula { get; set; }
        public bool lvdObservacion { get; set; }
        public bool lvdRedondeo { get; set; }
        public bool lvtIGV { get; set; }
        public bool lvpTotal { get; set; }
        public bool lPago { get; set; }
        public bool lImpresionAuto { get; set; }
        public bool lFactura_btn { get; set; }
        public decimal nIGV { get; set; }
        public decimal nIGVUNI { get; set; }
        public bool lAlmacen { get; set; }
        public bool lSucursal { get; set; }
        public bool S_BuenContribuyente { get; set; }
        public bool lVehiculo { get; set; }
        public bool lSegundaLinea { get; set; }
        public bool lEliminaComprobante { get; set; }
        public bool lDescuento { get; set; }
        public bool lVentaMayor { get; set; }
        public bool lTransporte { get; set; }
        public bool lAnticipo { get; set; }
        public bool lAgenteDetraccion { get; set; }
        public bool lVistaPreviaCotizacion { get; set; }
        public bool lHotel { get; set; }
        public bool lSeguimientoCotizacion { get; set; }
        public bool lRedondeo { get; set; }
        public bool lMoneda { get; set; }
        public bool lPeso_Cotizacion { get; set; }
        public bool lCotizacion { get; set; }
        public string tVersion { get; set; }
        public bool lVendedorDesbloqueado { get; set; }
        public bool lv_DescuentoPorcentaje { get; set; }
        public bool lEmbarcacionPesquera { get; set; }
        public bool lLiquidacion { get; set; }
        public bool lTicket { get; set; }
        public bool lNaval { get; set; }
        public bool lv_DescuentoUnidad { get; set; }
        public string tEmpUsuario { get; set; }
        public string tEmpClave { get; set; }
        public bool lVPVenta { get; set; }
        public bool lVPCompra { get; set; }
        public bool lCalculoInverso { get; set; }
        public bool lPasajero { get; set; }
        public bool lv_ObsServicio { get; set; }
        public int nDiasEmision { get; set; }
        public string fFechaActual { get; set; }
        public bool lv_GuiaTransporte { get; set; }
        public bool Oblig_PlacaVehiculo { get; set; }
        public bool lv_PrecioEditable { get; set; }
        public bool lRegularizarAlmacen { get; set; }
        public bool lProductoSunat { get; set; }
        public bool lIncluyePercepcion { get; set; }
        public bool lVendedorComp { get; set; }
        public bool lAlmacenNegativo { get; set; }
        public bool lVerStock { get; set; }
        public bool lCodigoBarra { get; set; }
        public bool lLote { get; set; }
        public bool lCotizacionMovimiento { get; set; }
        public bool lCaja { get; set; }
        public bool lOrdenVenta { get; set; }
        public bool lCajaOrdenVenta { get; set; }
        public bool lCobroAntes { get; set; }
        public bool lMargenGanancia { get; set; }
        public decimal nPorcentajeMargen { get; set; }
        public bool lProductoBuscar_Auto { get; set; }
        public bool lPdfTxt { get; set; }
        public bool lOrdenServicio { get; set; }
        public bool lFactorGanancia { get; set; }
        public decimal nFactorPorcentaje { get; set; }
        public bool lConversionMoneda { get; set; }
        public bool lVentasPromocion { get; set; }
        public int iVentasPromocionCantidad { get; set; }
        public int iPrecioCompraDecimales { get; set; }
        public decimal nPorcentajeRC { get; set; }
        public bool lSelectProducto { get; set; }
        public bool lProductoEquivalencia { get; set; }
        public bool lContratoVehiculo { get; set; }
        public bool lBuscarClienteCodigo { get; set; }
        public bool lAddCodBarraAuto { get; set; }
        public bool lZona { get; set; }
        // CR ================================================
        public bool lDrogueria { get; set; }
        // CR ================================================
        public bool lVerPrecioVentaSoles { get; set; }
        public bool lImpresionMasivo { get; set; }
        public bool lVerButtonPDFCDP { get; set; }
        public bool lCursorCantidadDetalle { get; set; }
        public bool INC_IGV_Compra { get; set; }
        public bool INC_IGV_Producto { get; set; }
        public bool lConVentaBtnCorreo { get; set; }
        public bool lFechaEntregaCoti { get; set; }
        public bool lNumAutogeneradoCotizacion { get; set; }
        public bool lCotizacionPrincipal { get; set; }
        public bool lDistribuidor { get; set; }
        public bool lGuiaRemisionManual { get; set; }
        public bool lvd_TipoAfectacion { get; set; }
        public bool ldv_CodigoProducto { get; set; }
        public bool lEsElectronica { get; set; }
        public bool lFechaVencimiento { get; set; }
        public bool lPrecioAplicarUpdate { get; set; }
        public bool lMostrarSinStock { get; set; }
        public bool lVentaAlmacen { get; set; }
        public bool lCodigoClienteProducto { get; set; }
        public bool lMarca { get; set; }
        public bool lCaracteristicasAdicionales { get; set; }
        public bool lColor { get; set; }
        public bool lEncomiendaTransporte { get; set; }
        public bool lBoletoControlTransporte { get; set; }
        public bool lCompraDetalle { get; set; }
        public bool lCompraNotaIngreso { get; set; }
        public bool ldv_CantCaja { get; set; }
        public bool lPdfAdicional { get; set; }
        public bool lImpresionRapidaComanda { get; set; }
        public bool lAplicaCuota { get; set; }
        public bool lResAvanceSucursal { get; set; }
        public int? iRestauranteVista { get; set; }
        public string tRutaLogo { get; set; }
        public string tRutaBanner { get; set; }
        public string tRutaLogoExt { get; set; }
        public bool lvdObservacionAlmacen { get; set; }
        public bool lPrepagoRestaurante { get; set; }
        public bool lBarraLibreRestaurante { get; set; }
        public bool lFechaVencimientoProducto { get; set; }
        public bool lFechaNotaVentaPeriodo { get; set; }
        public bool lGuiaRemitenteButton { get; set; }
        public bool lGuiaRemitenteVistaPrevia { get; set; }
        public bool lExportacionOtros { get; set; }
        public bool lDocumentoRelacionadoCompras { get; set; }
        public bool lProductoImagePath { get; set; }
        public bool lIgnorarCajaOrdenVenta { get; set; }
        public bool lMonedaUSDProducto { get; set; }
        public bool lMonedaUSDIngreso { get; set; }
        public bool lUncheckPagado { get; set; }
        public bool lCalcularDetraccion { get; set; }
        public bool lCalcularRetencionIgv { get; set; }
    }
}
