using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Contpaqi.Sql.ADD.OtherMetadata
{
    public class Pagos
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pagos()
        {
            Impuestos_Pagos = new HashSet<Impuestos_Pagos>();
            Pagos_Doc_Rel = new HashSet<Pagos_Doc_Rel>();
        }

        public Guid GuidDocument { get; set; }

        [Key]
        [StringLength(60)]
        public string IdPago { get; set; }

        [StringLength(5)]
        public string Version { get; set; }

        public DateTime? FechaPago { get; set; }

        public int? FechaPagoMes { get; set; }

        public int? FechaPagoAnio { get; set; }

        [StringLength(10)]
        public string FormaDePagoP { get; set; }

        [StringLength(255)]
        public string FormaDePagoPDesc { get; set; }

        [StringLength(10)]
        public string MonedaP { get; set; }

        [StringLength(255)]
        public string MonedaPDesc { get; set; }

        public decimal? TipoCambioP { get; set; }

        public decimal? Monto { get; set; }

        [StringLength(100)]
        public string NumOperacion { get; set; }

        [StringLength(15)]
        public string RfcEmisorCtaOrd { get; set; }

        [StringLength(300)]
        public string NomBancoOrdExt { get; set; }

        [StringLength(50)]
        public string CtaOrdenante { get; set; }

        [StringLength(15)]
        public string RfcEmisorCtaBen { get; set; }

        [StringLength(50)]
        public string CtaBeneficiario { get; set; }

        [StringLength(10)]
        public string TipoCadPago { get; set; }

        [StringLength(255)]
        public string TipoCadPagoDesc { get; set; }

        public string CertPago { get; set; }

        public string CadPago { get; set; }

        public string SelloPago { get; set; }

        public virtual Comprobante Comprobante { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Impuestos_Pagos> Impuestos_Pagos { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pagos_Doc_Rel> Pagos_Doc_Rel { get; set; }
    }
}