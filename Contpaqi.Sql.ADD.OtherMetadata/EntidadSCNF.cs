using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.ADD.OtherMetadata
{
    [Table("EntidadSCNF")]
    public class EntidadSCNF
    {
        public Guid GuidDocument { get; set; }

        [Key]
        [StringLength(60)]
        public string IdEntidadSCNF { get; set; }

        [StringLength(10)]
        public string OrigenRecurso { get; set; }

        [StringLength(255)]
        public string OrigenRecursoDesc { get; set; }

        public decimal? MontoRecursoPropio { get; set; }

        public virtual Nomina Nomina { get; set; }
    }
}