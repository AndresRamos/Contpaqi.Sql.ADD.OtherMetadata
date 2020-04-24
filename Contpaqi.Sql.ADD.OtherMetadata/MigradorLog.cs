using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.ADD.OtherMetadata
{
    [Table("MigradorLog")]
    public class MigradorLog
    {
        [Key]
        public long IdLog { get; set; }

        public Guid? GuidDocument { get; set; }

        public string ErrorMessage { get; set; }

        public string FileName { get; set; }

        [StringLength(50)]
        public string Origen { get; set; }
    }
}