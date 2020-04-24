using System;
using System.ComponentModel.DataAnnotations;

namespace Contpaqi.Sql.ADD.OtherMetadata
{
    public class Nomina_Detalle
    {
        public Guid GuidDocument { get; set; }

        [StringLength(5)]
        public string TipoNominaDetalle { get; set; }

        [Key]
        [StringLength(60)]
        public string IdDetalle { get; set; }

        [StringLength(10)]
        public string TipoDetalle { get; set; }

        [StringLength(255)]
        public string TipoDetalleDesc { get; set; }

        [StringLength(250)]
        public string Clave { get; set; }

        [StringLength(250)]
        public string Concepto { get; set; }

        public decimal? ImporteGravado { get; set; }

        public decimal? ImporteExento { get; set; }

        public decimal? Importe { get; set; }

        public virtual Nomina Nomina { get; set; }
    }
}