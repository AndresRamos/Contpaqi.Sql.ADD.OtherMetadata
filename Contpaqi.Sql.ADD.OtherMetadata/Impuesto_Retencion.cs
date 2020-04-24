using System;
using System.ComponentModel.DataAnnotations;

namespace Contpaqi.Sql.ADD.OtherMetadata
{
    public class Impuesto_Retencion
    {
        [Key]
        public Guid GuidDocument { get; set; }

        [StringLength(5)]
        public string Impuesto { get; set; }

        [StringLength(255)]
        public string ImpuestoDesc { get; set; }

        public decimal? Importe { get; set; }

        public virtual Comprobante Comprobante { get; set; }
    }
}