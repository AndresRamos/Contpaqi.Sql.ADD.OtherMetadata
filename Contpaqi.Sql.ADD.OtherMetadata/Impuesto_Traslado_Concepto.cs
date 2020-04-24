using System.ComponentModel.DataAnnotations;

namespace Contpaqi.Sql.ADD.OtherMetadata
{
    public class Impuesto_Traslado_Concepto
    {
        [Key]
        [StringLength(60)]
        public string IdConcepto { get; set; }

        public decimal? Base { get; set; }

        [StringLength(5)]
        public string Impuesto { get; set; }

        [StringLength(255)]
        public string ImpuestoDesc { get; set; }

        [StringLength(20)]
        public string TipoFactor { get; set; }

        [StringLength(8)]
        public string TasaOCuota { get; set; }

        public decimal? Importe { get; set; }

        public virtual Conceptos Conceptos { get; set; }
    }
}