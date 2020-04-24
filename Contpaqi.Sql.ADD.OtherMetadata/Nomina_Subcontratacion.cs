using System;
using System.ComponentModel.DataAnnotations;

namespace Contpaqi.Sql.ADD.OtherMetadata
{
    public class Nomina_Subcontratacion
    {
        public Guid GuidDocument { get; set; }

        [Key]
        [StringLength(60)]
        public string IdSub { get; set; }

        [StringLength(13)]
        public string RFCLabora { get; set; }

        public decimal? PorcTiempo { get; set; }

        public virtual Nomina Nomina { get; set; }
    }
}