using System;
using System.ComponentModel.DataAnnotations;

namespace Contpaqi.Sql.ADD.OtherMetadata
{
    public class Expedientes
    {
        [Key]
        public Guid Guid_Relacionado { get; set; }

        public Guid? Guid_Pertenece { get; set; }

        [StringLength(100)]
        public string ApplicationType_Exp { get; set; }

        [StringLength(100)]
        public string Type_Exp { get; set; }

        [StringLength(255)]
        public string Comment_Exp { get; set; }

        public DateTime? TimeStamp_Exp { get; set; }
    }
}