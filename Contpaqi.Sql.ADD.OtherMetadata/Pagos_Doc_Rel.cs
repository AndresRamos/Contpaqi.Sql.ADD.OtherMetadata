using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.ADD.OtherMetadata
{
    public class Pagos_Doc_Rel
    {
        [Key]
        [Column(Order = 0)]
        public Guid GuidDocument { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(60)]
        public string IdPago { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(36)]
        public string IdDocumento { get; set; }

        [StringLength(25)]
        public string Serie { get; set; }

        [StringLength(40)]
        public string Folio { get; set; }

        [StringLength(10)]
        public string MonedaDR { get; set; }

        [StringLength(255)]
        public string MonedaDRDesc { get; set; }

        public decimal? TipoCambioDR { get; set; }

        [StringLength(10)]
        public string MetodoDePagoDR { get; set; }

        [StringLength(255)]
        public string MetodoDePagoDRDesc { get; set; }

        public int? NumParcialidad { get; set; }

        public decimal? ImpSaldoAnt { get; set; }

        public decimal? ImpPagado { get; set; }

        public decimal? ImpSaldoInsoluto { get; set; }

        public virtual Pagos Pagos { get; set; }
    }
}