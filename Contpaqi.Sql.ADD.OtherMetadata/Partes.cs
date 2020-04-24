using System.ComponentModel.DataAnnotations;

namespace Contpaqi.Sql.ADD.OtherMetadata
{
    public class Partes
    {
        [Required]
        [StringLength(60)]
        public string IdConcepto { get; set; }

        [Key]
        [StringLength(60)]
        public string IdParte { get; set; }

        [StringLength(25)]
        public string CveProdSer { get; set; }

        [StringLength(255)]
        public string CveProdSerDesc { get; set; }

        [StringLength(100)]
        public string NoIdentificacion { get; set; }

        public decimal? Cantidad { get; set; }

        [StringLength(20)]
        public string Unidad { get; set; }

        [StringLength(1000)]
        public string Descripcion { get; set; }

        public decimal? ValorUnitario { get; set; }

        public decimal? Importe { get; set; }

        public virtual Conceptos Conceptos { get; set; }
    }
}