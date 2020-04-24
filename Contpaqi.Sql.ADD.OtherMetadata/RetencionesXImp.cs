using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.ADD.OtherMetadata
{
    [Table("RetencionesXImp")]
    public class RetencionesXImp
    {
        public Guid GuidDocument { get; set; }

        [Key]
        [StringLength(60)]
        public string IdImpuestoRet { get; set; }

        public decimal? BaseRet { get; set; }

        [StringLength(10)]
        public string Impuesto { get; set; }

        [StringLength(255)]
        public string ImpuestoDesc { get; set; }

        public decimal? montoRet { get; set; }

        [StringLength(60)]
        public string TipoPagoRet { get; set; }

        public virtual Retenciones Retenciones { get; set; }
    }
}