using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Contpaqi.Sql.ADD.OtherMetadata
{
    [Table("Nomina")]
    public class Nomina
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Nomina()
        {
            EntidadSCNF = new HashSet<EntidadSCNF>();
            Nomina_Detalle = new HashSet<Nomina_Detalle>();
            Nomina_HorasExtras = new HashSet<Nomina_HorasExtras>();
            Nomina_Incapacidad = new HashSet<Nomina_Incapacidad>();
            Nomina_Subcontratacion = new HashSet<Nomina_Subcontratacion>();
        }

        [Key]
        public Guid GuidDocument { get; set; }

        [StringLength(5)]
        public string Version { get; set; }

        [StringLength(10)]
        public string TipoNomina { get; set; }

        [StringLength(255)]
        public string TipoNominaDesc { get; set; }

        public DateTime? FechaPago { get; set; }

        public byte? FechaPagoMes { get; set; }

        public short? FechaPagoAnio { get; set; }

        public DateTime? FechaInicialPago { get; set; }

        public DateTime? FechaFinalPago { get; set; }

        public decimal? NumDiasPagados { get; set; }

        public decimal? TotalPercepciones { get; set; }

        public decimal? TotalDeducciones { get; set; }

        public decimal? TotalOtrosPagos { get; set; }

        [StringLength(20)]
        public string RegistroPatronal { get; set; }

        [StringLength(15)]
        public string NumSeguridadSocialRec { get; set; }

        public DateTime? FechaInicioRelLaboral { get; set; }

        [StringLength(10)]
        public string Antiguedad { get; set; }

        [StringLength(255)]
        public string TipoContrato { get; set; }

        [StringLength(255)]
        public string TipoContratoDesc { get; set; }

        [StringLength(2)]
        public string Sindicalizado { get; set; }

        [StringLength(25)]
        public string TipoJornada { get; set; }

        [StringLength(255)]
        public string TipoJornadaDesc { get; set; }

        [StringLength(10)]
        public string TipoRegimen { get; set; }

        [StringLength(255)]
        public string TipoRegimenDesc { get; set; }

        [StringLength(15)]
        public string NumEmpleadoRec { get; set; }

        [StringLength(100)]
        public string DepartamentoRec { get; set; }

        [StringLength(100)]
        public string PuestoRec { get; set; }

        [StringLength(10)]
        public string RiesgoPuesto { get; set; }

        [StringLength(255)]
        public string RiesgoPuestoDesc { get; set; }

        [StringLength(100)]
        public string PeriodicidadPago { get; set; }

        [StringLength(255)]
        public string PeriodicidadPagoDesc { get; set; }

        [StringLength(10)]
        public string Banco { get; set; }

        [StringLength(255)]
        public string BancoDesc { get; set; }

        public decimal? SalarioBaseCotApor { get; set; }

        public decimal? SalarioDiarioIntegrado { get; set; }

        [StringLength(10)]
        public string ClaveEntFed { get; set; }

        [StringLength(255)]
        public string ClaveEntFedDesc { get; set; }

        public decimal? TotalSueldos { get; set; }

        public decimal? TotalSeparacionIndemnizacion { get; set; }

        public decimal? TotalGravadoPercepcion { get; set; }

        public decimal? TotalExentoPercepcion { get; set; }

        public decimal? TotalGravadoDeduccion { get; set; }

        public decimal? TotalExentoDeduccion { get; set; }

        public decimal? TotalPagado { get; set; }

        public byte? NumAnosServicio { get; set; }

        public decimal? UltimoSueldoMesOrd { get; set; }

        public decimal? IngresoAcumulable { get; set; }

        public decimal? IngresoNoAcumulable { get; set; }

        public decimal? TotalOtrasDeducciones { get; set; }

        public decimal? TotalImpuestosRetenidos { get; set; }

        public decimal? SaldoAFavor { get; set; }

        public int? Ano { get; set; }

        public decimal? RemanenteSalFav { get; set; }

        public decimal? SubsidioCausado { get; set; }

        [StringLength(40)]
        public string CuentaBancaria { get; set; }

        [StringLength(20)]
        public string CURPReceptor { get; set; }

        public virtual Comprobante Comprobante { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EntidadSCNF> EntidadSCNF { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Nomina_Detalle> Nomina_Detalle { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Nomina_HorasExtras> Nomina_HorasExtras { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Nomina_Incapacidad> Nomina_Incapacidad { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Nomina_Subcontratacion> Nomina_Subcontratacion { get; set; }
    }
}