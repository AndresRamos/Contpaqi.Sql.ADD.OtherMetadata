using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.ADD.OtherMetadata
{
    [Table("Diccionario")]
    public class Diccionario
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [StringLength(255)]
        public string Label { get; set; }

        [StringLength(255)]
        public string Field { get; set; }

        [StringLength(255)]
        public string Table { get; set; }
    }
}