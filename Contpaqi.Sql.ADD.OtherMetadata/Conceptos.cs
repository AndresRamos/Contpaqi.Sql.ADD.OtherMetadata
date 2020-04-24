using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Contpaqi.Sql.ADD.OtherMetadata
{
    public class Conceptos
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Conceptos()
        {
            Partes = new HashSet<Partes>();
        }

        public Guid GuidDocument { get; set; }

        [Key]
        [StringLength(60)]
        public string IdConcepto { get; set; }

        [StringLength(25)]
        public string CveProdSer { get; set; }

        [StringLength(255)]
        public string CveProdSerDesc { get; set; }

        [StringLength(255)]
        public string NoIdentificacion { get; set; }

        public decimal? Cantidad { get; set; }

        [StringLength(20)]
        public string ClaveUnidad { get; set; }

        [StringLength(255)]
        public string ClaveUnidadDesc { get; set; }

        [StringLength(255)]
        public string Unidad { get; set; }

        [StringLength(1000)]
        public string Descripcion { get; set; }

        public decimal? ValorUnitario { get; set; }

        public decimal? Importe { get; set; }

        public decimal? Descuento { get; set; }

        public virtual Comprobante Comprobante { get; set; }

        public virtual Impuesto_Retencion_Concepto Impuesto_Retencion_Concepto { get; set; }

        public virtual Impuesto_Traslado_Concepto Impuesto_Traslado_Concepto { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Partes> Partes { get; set; }
    }
}