using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Contpaqi.Sql.ADD.OtherMetadata
{
    [Table("Comprobante")]
    public class Comprobante
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Comprobante()
        {
            CfdiRelacionados = new HashSet<CfdiRelacionados>();
            Conceptos = new HashSet<Conceptos>();
            Pagos = new HashSet<Pagos>();
        }

        [Key]
        public Guid GuidDocument { get; set; }

        [StringLength(13)]
        public string RFCEmisor { get; set; }

        [StringLength(255)]
        public string NombreEmisor { get; set; }

        [StringLength(254)]
        public string RegimenEmisor { get; set; }

        [StringLength(255)]
        public string RegimenEmisorDesc { get; set; }

        [StringLength(20)]
        public string CURPEmisor { get; set; }

        [StringLength(13)]
        public string RFCReceptor { get; set; }

        [StringLength(255)]
        public string NombreReceptor { get; set; }

        [StringLength(254)]
        public string RegimenReceptor { get; set; }

        public decimal? TotImpRetenidos { get; set; }

        public decimal? TotImpTraslado { get; set; }

        [StringLength(5)]
        public string Version { get; set; }

        [StringLength(25)]
        public string Serie { get; set; }

        [StringLength(40)]
        public string Folio { get; set; }

        public DateTime? Fecha { get; set; }

        public byte? FechaMes { get; set; }

        public short? FechaAnio { get; set; }

        [StringLength(255)]
        public string FormaPago { get; set; }

        [StringLength(255)]
        public string FormaPagoDesc { get; set; }

        [StringLength(1000)]
        public string CondicionesPago { get; set; }

        public decimal? Subtotal { get; set; }

        public decimal? Descuento { get; set; }

        public decimal? TipoCambio { get; set; }

        [StringLength(50)]
        public string Moneda { get; set; }

        [StringLength(255)]
        public string MonedaDesc { get; set; }

        public decimal? Total { get; set; }

        [StringLength(20)]
        public string TipoComprobante { get; set; }

        [StringLength(50)]
        public string MetodoPago { get; set; }

        [StringLength(255)]
        public string MetodoPagoDesc { get; set; }

        public string LugarExp { get; set; }

        public string LugarExpDesc { get; set; }

        public Guid? UUID { get; set; }

        public DateTime? FechaTimbrado { get; set; }

        public int? FechaTimbradoMes { get; set; }

        public int? FechaTimbradoAnio { get; set; }

        [StringLength(60)]
        public string NumeroCertificado { get; set; }

        [StringLength(255)]
        public string Confirmacion { get; set; }

        [StringLength(100)]
        public string TipoDocumento { get; set; }

        [StringLength(255)]
        public string ResidenciaFiscal { get; set; }

        [StringLength(255)]
        public string ResidenciaFiscalDesc { get; set; }

        [StringLength(40)]
        public string NumRegIdTrib { get; set; }

        [StringLength(10)]
        public string UsoCFDI { get; set; }

        [StringLength(255)]
        public string UsoCFDI_Desc { get; set; }

        [StringLength(255)]
        public string TipoComprobanteDesc { get; set; }

        [StringLength(40)]
        public string NumCta { get; set; }

        public virtual Documento Documento { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CfdiRelacionados> CfdiRelacionados { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Conceptos> Conceptos { get; set; }

        public virtual Impuesto_Retencion Impuesto_Retencion { get; set; }

        public virtual Impuesto_Traslado Impuesto_Traslado { get; set; }

        public virtual Impuestos_Locales Impuestos_Locales { get; set; }

        public virtual ImpuestosTotalizados ImpuestosTotalizados { get; set; }

        public virtual Nomina Nomina { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pagos> Pagos { get; set; }
    }
}