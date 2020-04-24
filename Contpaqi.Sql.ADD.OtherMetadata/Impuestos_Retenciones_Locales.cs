using System;
using System.ComponentModel.DataAnnotations;

namespace Contpaqi.Sql.ADD.OtherMetadata
{
    public class Impuestos_Retenciones_Locales
    {
        public Guid GuidDocument { get; set; }

        [Key]
        [StringLength(60)]
        public string ImpDetalle { get; set; }

        [StringLength(100)]
        public string ImpLocalRetenido { get; set; }

        public decimal? TasadeRetencion { get; set; }

        public decimal? ImporteRetenido { get; set; }

        public virtual Impuestos_Locales Impuestos_Locales { get; set; }
    }
}