using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Contpaqi.Sql.ADD.OtherMetadata
{
    public class Impuestos_Pagos
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Impuestos_Pagos()
        {
            Impuestos_Retencion_Pago = new HashSet<Impuestos_Retencion_Pago>();
            Impuestos_Traslado_Pago = new HashSet<Impuestos_Traslado_Pago>();
        }

        public Guid GuidDocument { get; set; }

        [Required]
        [StringLength(60)]
        public string IdPago { get; set; }

        public decimal? TotalImpuestosRetenidos { get; set; }

        public decimal? TotalImpuestosTrasladados { get; set; }

        [Key]
        [StringLength(60)]
        public string IdImpuesto { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Impuestos_Retencion_Pago> Impuestos_Retencion_Pago { get; set; }

        public virtual Pagos Pagos { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Impuestos_Traslado_Pago> Impuestos_Traslado_Pago { get; set; }
    }
}