using System;
using System.ComponentModel.DataAnnotations;

namespace Contpaqi.Sql.ADD.OtherMetadata
{
    public class DocumentStatus
    {
        [Key]
        public Guid GuidDocument { get; set; }

        [StringLength(100)]
        public string IdError { get; set; }

        public string ErrorDescription { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? LlastmodifiedDate { get; set; }

        public int? Status { get; set; }
    }
}