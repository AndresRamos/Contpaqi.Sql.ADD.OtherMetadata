using System;
using System.ComponentModel.DataAnnotations;

namespace Contpaqi.Sql.ADD.OtherMetadata
{
    public class Impuestos_Traslados_Locales
    {
        public Guid GuidDocument { get; set; }

        [Key]
        [StringLength(60)]
        public string ImpDetalle { get; set; }

        [StringLength(100)]
        public string ImpLocalTrasladado { get; set; }

        public decimal? TasadeTraslado { get; set; }

        public decimal? ImporteTraslado { get; set; }

        public virtual Impuestos_Locales Impuestos_Locales { get; set; }
    }
}