using System;
using System.ComponentModel.DataAnnotations;

namespace Contpaqi.Sql.ADD.OtherMetadata
{
    public class Nomina_Incapacidad
    {
        public Guid GuidDocument { get; set; }

        [Key]
        [StringLength(60)]
        public string IdIncapacidad { get; set; }

        public decimal? Dias { get; set; }

        [StringLength(10)]
        public string TipoIncapacidad { get; set; }

        [StringLength(255)]
        public string TipoIncapacidad_Desc { get; set; }

        public decimal? Importe { get; set; }

        public virtual Nomina Nomina { get; set; }
    }
}