using System;
using System.ComponentModel.DataAnnotations;

namespace Contpaqi.Sql.ADD.OtherMetadata
{
    public class Certificates
    {
        [Key]
        public Guid GuidDocument { get; set; }

        public string LlavePublica { get; set; }

        public string LlavePrivada { get; set; }

        [StringLength(40)]
        public string NumeroSerie { get; set; }

        public DateTime? FechaInicial { get; set; }

        public DateTime? FechaFinal { get; set; }

        public string SubjectName { get; set; }

        public string IssuerName { get; set; }

        [StringLength(20)]
        public string ActualCSDStatus { get; set; }

        public bool? IsTesting { get; set; }
    }
}