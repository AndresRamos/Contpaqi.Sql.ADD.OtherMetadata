using System;
using System.ComponentModel.DataAnnotations;

namespace Contpaqi.Sql.ADD.OtherMetadata
{
    public class ImpuestosTotalizados
    {
        [Key]
        public Guid GuidDocument { get; set; }

        public decimal? ImporteTotalIVATraslado { get; set; }

        public decimal? ImporteTotalISRRetenido { get; set; }

        public decimal? ImporteTotalIEPSTraslado { get; set; }

        public decimal? ImporteTotalIVARetenido { get; set; }

        public decimal? TotalImpuestosTrasladados { get; set; }

        public decimal? TotalImpuestosRetenidos { get; set; }

        public decimal? ISRTrasladado { get; set; }

        public decimal? IEPSRetenido { get; set; }

        public virtual Comprobante Comprobante { get; set; }
    }
}