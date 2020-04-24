using System;
using System.ComponentModel.DataAnnotations;

namespace Contpaqi.Sql.ADD.OtherMetadata
{
    public class Nomina_HorasExtras
    {
        public Guid GuidDocument { get; set; }

        [StringLength(60)]
        public string IdDetalle { get; set; }

        [Key]
        [StringLength(60)]
        public string IdHoraExtra { get; set; }

        public decimal? Dias { get; set; }

        [StringLength(20)]
        public string TiposHoras { get; set; }

        [StringLength(255)]
        public string TiposHoras_Desc { get; set; }

        public decimal? HorasExtra { get; set; }

        public decimal? Importe { get; set; }

        public virtual Nomina Nomina { get; set; }
    }
}