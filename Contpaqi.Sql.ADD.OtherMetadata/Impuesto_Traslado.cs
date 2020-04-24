using System;
using System.ComponentModel.DataAnnotations;

namespace Contpaqi.Sql.ADD.OtherMetadata
{
    public class Impuesto_Traslado
    {
        [Key]
        public Guid GuidDocument { get; set; }

        [StringLength(5)]
        public string Impuesto { get; set; }

        [StringLength(255)]
        public string ImpuestoDesc { get; set; }

        [StringLength(20)]
        public string TipoFactor { get; set; }

        [StringLength(8)]
        public string TasaOCuota { get; set; }

        public decimal? Importe { get; set; }

        public virtual Comprobante Comprobante { get; set; }
    }
}