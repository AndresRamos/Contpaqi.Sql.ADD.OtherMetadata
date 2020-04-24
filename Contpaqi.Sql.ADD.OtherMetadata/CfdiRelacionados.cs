using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.ADD.OtherMetadata
{
    public class CfdiRelacionados
    {
        [Key]
        [Column(Order = 0)]
        public Guid GuidDocument { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid UUID { get; set; }

        [StringLength(60)]
        public string TipoRelacion { get; set; }

        [StringLength(255)]
        public string TipoRelacionDesc { get; set; }

        public virtual Comprobante Comprobante { get; set; }
    }
}