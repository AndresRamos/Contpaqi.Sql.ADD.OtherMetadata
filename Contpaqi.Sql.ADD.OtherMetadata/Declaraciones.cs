using System;
using System.ComponentModel.DataAnnotations;

namespace Contpaqi.Sql.ADD.OtherMetadata
{
    public class Declaraciones
    {
        [Key]
        public Guid GuidDocument { get; set; }

        public int? Mes { get; set; }

        public int? Anio { get; set; }

        public DateTime? EmisionDateDeclaracion { get; set; }

        [StringLength(20)]
        public string OperationNum { get; set; }

        public Guid? PdfAcknowledgementGuid { get; set; }

        public Guid? XmlAcknowledgementGuid { get; set; }

        [StringLength(255)]
        public string PeriodDesc { get; set; }

        [StringLength(255)]
        public string FileName { get; set; }

        [StringLength(100)]
        public string ValidationStatus { get; set; }

        [StringLength(18)]
        public string RFC { get; set; }

        [StringLength(50)]
        public string TipoEnvio { get; set; }

        [StringLength(50)]
        public string TipoSolicitud { get; set; }

        [StringLength(50)]
        public string NumOrden { get; set; }

        [StringLength(20)]
        public string NumTramite { get; set; }

        public virtual Documento Documento { get; set; }
    }
}