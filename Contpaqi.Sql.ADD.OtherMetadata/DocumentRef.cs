using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.ADD.OtherMetadata
{
    [Table("DocumentRef")]
    public class DocumentRef
    {
        [Key]
        public Guid GuidDocument { get; set; }

        public Guid? Guid { get; set; }

        [StringLength(5)]
        public string AggregationType { get; set; }

        [StringLength(40)]
        public string ApplicationType { get; set; }

        [StringLength(255)]
        public string Comment { get; set; }
    }
}