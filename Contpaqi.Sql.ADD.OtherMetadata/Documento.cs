using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.ADD.OtherMetadata
{
    [Table("Documento")]
    public class Documento
    {
        [Key]
        public Guid GuidDocument { get; set; }

        [StringLength(255)]
        public string Path { get; set; }

        [StringLength(255)]
        public string Hash { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        [StringLength(50)]
        public string MetadataEstatusApp { get; set; }

        [StringLength(100)]
        public string UserResponsibleApp { get; set; }

        public string ReferenceApp { get; set; }

        public string NotesApp { get; set; }

        public DateTime? TimeStamp { get; set; }

        [StringLength(100)]
        public string ProcessApp { get; set; }

        [StringLength(50)]
        public string NoPaymentStatusapp { get; set; }

        [StringLength(200)]
        public string ClaveDescripcion { get; set; }

        [StringLength(255)]
        public string SourceFile { get; set; }

        [StringLength(100)]
        public string Type_Otro { get; set; }

        [StringLength(100)]
        public string Type_Ext { get; set; }

        public int? IdTipoDocumento { get; set; }

        public DateTime? StartPeriodDate { get; set; }

        public DateTime? EndPeriodDate { get; set; }

        public long? Period { get; set; }

        public int? Year { get; set; }

        public decimal? TotalPayRoll { get; set; }

        [StringLength(100)]
        public string SalaryType { get; set; }

        public DateTime? EmisionDate { get; set; }

        [StringLength(100)]
        public string Type { get; set; }

        public byte? IsAsoContabilidad { get; set; }

        public byte? IsAsoComercial { get; set; }

        public byte? IsAsoBancos { get; set; }

        [StringLength(20)]
        public string ValidationStatus { get; set; }

        public DateTime? CancelDate { get; set; }

        [StringLength(255)]
        public string CancelStatus { get; set; }

        public virtual cat_TipoDocumento cat_TipoDocumento { get; set; }

        public virtual Comprobante Comprobante { get; set; }

        public virtual Declaraciones Declaraciones { get; set; }

        public virtual Doc_App Doc_App { get; set; }

        public virtual EstatusProceso EstatusProceso { get; set; }

        public virtual Retenciones Retenciones { get; set; }
    }
}