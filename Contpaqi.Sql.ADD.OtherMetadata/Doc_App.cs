using System;
using System.ComponentModel.DataAnnotations;

namespace Contpaqi.Sql.ADD.OtherMetadata
{
    public class Doc_App
    {
        [Key]
        public Guid GuidDocument { get; set; }

        public DateTime? Fecha { get; set; }

        [StringLength(100)]
        public string Tipo { get; set; }

        [StringLength(255)]
        public string Subtipo { get; set; }

        public int? Ejercicio { get; set; }

        public int? Periodo { get; set; }

        [StringLength(40)]
        public string Numero { get; set; }

        [StringLength(40)]
        public string SubTipoNumero { get; set; }

        [StringLength(36)]
        public string Cuenta { get; set; }

        [StringLength(40)]
        public string Folio { get; set; }

        public int? Responsable { get; set; }

        public virtual Documento Documento { get; set; }
    }
}