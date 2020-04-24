using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.ADD.OtherMetadata
{
    [Table("XMLControl")]
    public class XMLControl
    {
        [Key]
        public Guid GuidProcess { get; set; }

        public long? TotalDocs { get; set; }
    }
}