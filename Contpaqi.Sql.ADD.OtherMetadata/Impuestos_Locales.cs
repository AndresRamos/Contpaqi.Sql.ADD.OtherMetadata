using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Contpaqi.Sql.ADD.OtherMetadata
{
    public class Impuestos_Locales
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Impuestos_Locales()
        {
            Impuestos_Retenciones_Locales = new HashSet<Impuestos_Retenciones_Locales>();
            Impuestos_Traslados_Locales = new HashSet<Impuestos_Traslados_Locales>();
        }

        [Key]
        public Guid GuidDocument { get; set; }

        public decimal? Version { get; set; }

        public decimal? TotalRetenciones { get; set; }

        public decimal? TotalTraslados { get; set; }

        public virtual Comprobante Comprobante { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Impuestos_Retenciones_Locales> Impuestos_Retenciones_Locales { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Impuestos_Traslados_Locales> Impuestos_Traslados_Locales { get; set; }
    }
}