using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.ADD.OtherMetadata
{
    public class Impuestos_Retencion_Pago
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(60)]
        public string IdImpuesto { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid GuidDocument { get; set; }

        [StringLength(5)]
        public string Impuesto { get; set; }

        [StringLength(255)]
        public string ImpuestoDesc { get; set; }

        public decimal? Importe { get; set; }

        public virtual Impuestos_Pagos Impuestos_Pagos { get; set; }
    }
}