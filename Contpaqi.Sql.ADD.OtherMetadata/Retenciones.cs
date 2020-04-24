using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Contpaqi.Sql.ADD.OtherMetadata
{
    public class Retenciones
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Retenciones()
        {
            RetencionesXImp = new HashSet<RetencionesXImp>();
        }

        [Key]
        public Guid GuidDocument { get; set; }

        [StringLength(20)]
        public string Nacionalidad { get; set; }

        [StringLength(20)]
        public string NumRegIdTrib { get; set; }

        public int? MesIni { get; set; }

        public int? MesFin { get; set; }

        public int? Ejerc { get; set; }

        public decimal? MontoTotOperacion { get; set; }

        public decimal? MontoTotGrav { get; set; }

        public decimal? MontoTotExent { get; set; }

        public decimal? MontoTotRet { get; set; }

        [StringLength(20)]
        public string Version { get; set; }

        [StringLength(20)]
        public string Folio { get; set; }

        public string Sello { get; set; }

        [StringLength(20)]
        public string NumCert { get; set; }

        public DateTime? FechaExp { get; set; }

        [StringLength(20)]
        public string CveRetenc { get; set; }

        [StringLength(255)]
        public string DescRetenc { get; set; }

        [StringLength(15)]
        public string RFCEmisor { get; set; }

        [StringLength(300)]
        public string NomDenRazSocE { get; set; }

        [StringLength(20)]
        public string CURPE { get; set; }

        [StringLength(15)]
        public string RFCRecep { get; set; }

        [StringLength(300)]
        public string NomDenRazSocR { get; set; }

        [StringLength(20)]
        public string CURPR { get; set; }

        [StringLength(300)]
        public string NomDenRazSocRExt { get; set; }

        public Guid? UUID { get; set; }

        public virtual Documento Documento { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RetencionesXImp> RetencionesXImp { get; set; }
    }
}