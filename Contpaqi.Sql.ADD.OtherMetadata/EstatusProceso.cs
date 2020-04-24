using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.ADD.OtherMetadata
{
    [Table("EstatusProceso")]
    public class EstatusProceso
    {
        [Key]
        public Guid GuidDocument { get; set; }

        public long? IdAccion { get; set; }

        public DateTime? Timestamp { get; set; }

        [StringLength(255)]
        public string Comentario { get; set; }

        public virtual Documento Documento { get; set; }
    }
}