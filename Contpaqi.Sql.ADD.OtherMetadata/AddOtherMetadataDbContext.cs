using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;

namespace Contpaqi.Sql.ADD.OtherMetadata
{
    public class AddOtherMetadataDbContext : DbContext
    {
        protected AddOtherMetadataDbContext()
        {
        }

        protected AddOtherMetadataDbContext(DbCompiledModel model) : base(model)
        {
        }

        public AddOtherMetadataDbContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }

        public AddOtherMetadataDbContext(string nameOrConnectionString, DbCompiledModel model) : base(nameOrConnectionString, model)
        {
        }

        public AddOtherMetadataDbContext(DbConnection existingConnection, bool contextOwnsConnection) : base(existingConnection, contextOwnsConnection)
        {
        }

        public AddOtherMetadataDbContext(DbConnection existingConnection, DbCompiledModel model, bool contextOwnsConnection) : base(existingConnection, model, contextOwnsConnection)
        {
        }

        public AddOtherMetadataDbContext(ObjectContext objectContext, bool dbContextOwnsObjectContext) : base(objectContext, dbContextOwnsObjectContext)
        {
        }

        public virtual DbSet<cat_TipoDocumento> cat_TipoDocumento { get; set; }
        public virtual DbSet<Certificates> Certificates { get; set; }
        public virtual DbSet<Comprobante> Comprobante { get; set; }
        public virtual DbSet<Conceptos> Conceptos { get; set; }
        public virtual DbSet<Declaraciones> Declaraciones { get; set; }
        public virtual DbSet<Doc_App> Doc_App { get; set; }
        public virtual DbSet<Documento> Documento { get; set; }
        public virtual DbSet<EntidadSCNF> EntidadSCNF { get; set; }
        public virtual DbSet<Impuestos_Locales> Impuestos_Locales { get; set; }
        public virtual DbSet<Impuestos_Pagos> Impuestos_Pagos { get; set; }
        public virtual DbSet<Impuestos_Retenciones_Locales> Impuestos_Retenciones_Locales { get; set; }
        public virtual DbSet<Impuestos_Traslados_Locales> Impuestos_Traslados_Locales { get; set; }
        public virtual DbSet<ImpuestosTotalizados> ImpuestosTotalizados { get; set; }
        public virtual DbSet<Nomina> Nomina { get; set; }
        public virtual DbSet<Nomina_Detalle> Nomina_Detalle { get; set; }
        public virtual DbSet<Nomina_HorasExtras> Nomina_HorasExtras { get; set; }
        public virtual DbSet<Nomina_Incapacidad> Nomina_Incapacidad { get; set; }
        public virtual DbSet<Nomina_Subcontratacion> Nomina_Subcontratacion { get; set; }
        public virtual DbSet<Pagos> Pagos { get; set; }
        public virtual DbSet<Partes> Partes { get; set; }
        public virtual DbSet<Retenciones> Retenciones { get; set; }
        public virtual DbSet<RetencionesXImp> RetencionesXImp { get; set; }
        public virtual DbSet<TimbreTemp> TimbreTemp { get; set; }
        public virtual DbSet<CfdiRelacionados> CfdiRelacionados { get; set; }
        public virtual DbSet<Diccionario> Diccionario { get; set; }
        public virtual DbSet<DocumentRef> DocumentRef { get; set; }
        public virtual DbSet<DocumentRefPivot> DocumentRefPivot { get; set; }
        public virtual DbSet<DocumentStatus> DocumentStatus { get; set; }
        public virtual DbSet<EstatusProceso> EstatusProceso { get; set; }
        public virtual DbSet<Expedientes> Expedientes { get; set; }
        public virtual DbSet<Impuesto_Retencion> Impuesto_Retencion { get; set; }
        public virtual DbSet<Impuesto_Retencion_Concepto> Impuesto_Retencion_Concepto { get; set; }
        public virtual DbSet<Impuesto_Traslado> Impuesto_Traslado { get; set; }
        public virtual DbSet<Impuesto_Traslado_Concepto> Impuesto_Traslado_Concepto { get; set; }
        public virtual DbSet<Impuestos_Retencion_Pago> Impuestos_Retencion_Pago { get; set; }
        public virtual DbSet<Impuestos_Traslado_Pago> Impuestos_Traslado_Pago { get; set; }
        public virtual DbSet<MigradorLog> MigradorLog { get; set; }
        public virtual DbSet<Pagos_Doc_Rel> Pagos_Doc_Rel { get; set; }
        public virtual DbSet<XMLControl> XMLControl { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<cat_TipoDocumento>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Certificates>()
                .Property(e => e.NumeroSerie)
                .IsUnicode(false);

            modelBuilder.Entity<Certificates>()
                .Property(e => e.ActualCSDStatus)
                .IsUnicode(false);

            modelBuilder.Entity<Comprobante>()
                .Property(e => e.RFCEmisor)
                .IsUnicode(false);

            modelBuilder.Entity<Comprobante>()
                .Property(e => e.NombreEmisor)
                .IsUnicode(false);

            modelBuilder.Entity<Comprobante>()
                .Property(e => e.RegimenEmisor)
                .IsUnicode(false);

            modelBuilder.Entity<Comprobante>()
                .Property(e => e.RegimenEmisorDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Comprobante>()
                .Property(e => e.CURPEmisor)
                .IsUnicode(false);

            modelBuilder.Entity<Comprobante>()
                .Property(e => e.RFCReceptor)
                .IsUnicode(false);

            modelBuilder.Entity<Comprobante>()
                .Property(e => e.NombreReceptor)
                .IsUnicode(false);

            modelBuilder.Entity<Comprobante>()
                .Property(e => e.RegimenReceptor)
                .IsUnicode(false);

            modelBuilder.Entity<Comprobante>()
                .Property(e => e.TotImpRetenidos)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Comprobante>()
                .Property(e => e.TotImpTraslado)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Comprobante>()
                .Property(e => e.Version)
                .IsUnicode(false);

            modelBuilder.Entity<Comprobante>()
                .Property(e => e.Serie)
                .IsUnicode(false);

            modelBuilder.Entity<Comprobante>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<Comprobante>()
                .Property(e => e.FormaPago)
                .IsUnicode(false);

            modelBuilder.Entity<Comprobante>()
                .Property(e => e.FormaPagoDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Comprobante>()
                .Property(e => e.CondicionesPago)
                .IsUnicode(false);

            modelBuilder.Entity<Comprobante>()
                .Property(e => e.Subtotal)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Comprobante>()
                .Property(e => e.Descuento)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Comprobante>()
                .Property(e => e.TipoCambio)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Comprobante>()
                .Property(e => e.Moneda)
                .IsUnicode(false);

            modelBuilder.Entity<Comprobante>()
                .Property(e => e.MonedaDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Comprobante>()
                .Property(e => e.Total)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Comprobante>()
                .Property(e => e.TipoComprobante)
                .IsUnicode(false);

            modelBuilder.Entity<Comprobante>()
                .Property(e => e.MetodoPago)
                .IsUnicode(false);

            modelBuilder.Entity<Comprobante>()
                .Property(e => e.MetodoPagoDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Comprobante>()
                .Property(e => e.LugarExp)
                .IsUnicode(false);

            modelBuilder.Entity<Comprobante>()
                .Property(e => e.LugarExpDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Comprobante>()
                .Property(e => e.NumeroCertificado)
                .IsUnicode(false);

            modelBuilder.Entity<Comprobante>()
                .Property(e => e.Confirmacion)
                .IsUnicode(false);

            modelBuilder.Entity<Comprobante>()
                .Property(e => e.TipoDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<Comprobante>()
                .Property(e => e.ResidenciaFiscal)
                .IsUnicode(false);

            modelBuilder.Entity<Comprobante>()
                .Property(e => e.ResidenciaFiscalDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Comprobante>()
                .Property(e => e.NumRegIdTrib)
                .IsUnicode(false);

            modelBuilder.Entity<Comprobante>()
                .Property(e => e.UsoCFDI)
                .IsUnicode(false);

            modelBuilder.Entity<Comprobante>()
                .Property(e => e.UsoCFDI_Desc)
                .IsUnicode(false);

            modelBuilder.Entity<Comprobante>()
                .Property(e => e.TipoComprobanteDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Comprobante>()
                .Property(e => e.NumCta)
                .IsUnicode(false);

            modelBuilder.Entity<Comprobante>()
                .HasMany(e => e.CfdiRelacionados)
                .WithRequired(e => e.Comprobante)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Comprobante>()
                .HasMany(e => e.Conceptos)
                .WithRequired(e => e.Comprobante)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Comprobante>()
                .HasOptional(e => e.Impuesto_Retencion)
                .WithRequired(e => e.Comprobante);

            modelBuilder.Entity<Comprobante>()
                .HasOptional(e => e.Impuesto_Traslado)
                .WithRequired(e => e.Comprobante);

            modelBuilder.Entity<Comprobante>()
                .HasOptional(e => e.Impuestos_Locales)
                .WithRequired(e => e.Comprobante);

            modelBuilder.Entity<Comprobante>()
                .HasOptional(e => e.ImpuestosTotalizados)
                .WithRequired(e => e.Comprobante);

            modelBuilder.Entity<Comprobante>()
                .HasOptional(e => e.Nomina)
                .WithRequired(e => e.Comprobante);

            modelBuilder.Entity<Comprobante>()
                .HasMany(e => e.Pagos)
                .WithRequired(e => e.Comprobante)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Conceptos>()
                .Property(e => e.IdConcepto)
                .IsUnicode(false);

            modelBuilder.Entity<Conceptos>()
                .Property(e => e.CveProdSer)
                .IsUnicode(false);

            modelBuilder.Entity<Conceptos>()
                .Property(e => e.CveProdSerDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Conceptos>()
                .Property(e => e.NoIdentificacion)
                .IsUnicode(false);

            modelBuilder.Entity<Conceptos>()
                .Property(e => e.Cantidad)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Conceptos>()
                .Property(e => e.ClaveUnidad)
                .IsUnicode(false);

            modelBuilder.Entity<Conceptos>()
                .Property(e => e.ClaveUnidadDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Conceptos>()
                .Property(e => e.Unidad)
                .IsUnicode(false);

            modelBuilder.Entity<Conceptos>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Conceptos>()
                .Property(e => e.ValorUnitario)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Conceptos>()
                .Property(e => e.Importe)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Conceptos>()
                .Property(e => e.Descuento)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Conceptos>()
                .HasOptional(e => e.Impuesto_Retencion_Concepto)
                .WithRequired(e => e.Conceptos);

            modelBuilder.Entity<Conceptos>()
                .HasOptional(e => e.Impuesto_Traslado_Concepto)
                .WithRequired(e => e.Conceptos);

            modelBuilder.Entity<Conceptos>()
                .HasMany(e => e.Partes)
                .WithRequired(e => e.Conceptos)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Declaraciones>()
                .Property(e => e.OperationNum)
                .IsUnicode(false);

            modelBuilder.Entity<Declaraciones>()
                .Property(e => e.PeriodDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Declaraciones>()
                .Property(e => e.FileName)
                .IsUnicode(false);

            modelBuilder.Entity<Declaraciones>()
                .Property(e => e.ValidationStatus)
                .IsUnicode(false);

            modelBuilder.Entity<Declaraciones>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<Declaraciones>()
                .Property(e => e.TipoEnvio)
                .IsUnicode(false);

            modelBuilder.Entity<Declaraciones>()
                .Property(e => e.TipoSolicitud)
                .IsUnicode(false);

            modelBuilder.Entity<Declaraciones>()
                .Property(e => e.NumOrden)
                .IsUnicode(false);

            modelBuilder.Entity<Declaraciones>()
                .Property(e => e.NumTramite)
                .IsUnicode(false);

            modelBuilder.Entity<Doc_App>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<Doc_App>()
                .Property(e => e.Subtipo)
                .IsUnicode(false);

            modelBuilder.Entity<Doc_App>()
                .Property(e => e.Cuenta)
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.Path)
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.Hash)
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.MetadataEstatusApp)
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.UserResponsibleApp)
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.ProcessApp)
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.NoPaymentStatusapp)
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.ClaveDescripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.SourceFile)
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.Type_Otro)
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.Type_Ext)
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.TotalPayRoll)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Documento>()
                .Property(e => e.SalaryType)
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.ValidationStatus)
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.CancelStatus)
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .HasOptional(e => e.Comprobante)
                .WithRequired(e => e.Documento);

            modelBuilder.Entity<Documento>()
                .HasOptional(e => e.Declaraciones)
                .WithRequired(e => e.Documento);

            modelBuilder.Entity<Documento>()
                .HasOptional(e => e.Doc_App)
                .WithRequired(e => e.Documento);

            modelBuilder.Entity<Documento>()
                .HasOptional(e => e.EstatusProceso)
                .WithRequired(e => e.Documento);

            modelBuilder.Entity<Documento>()
                .HasOptional(e => e.Retenciones)
                .WithRequired(e => e.Documento);

            modelBuilder.Entity<EntidadSCNF>()
                .Property(e => e.IdEntidadSCNF)
                .IsUnicode(false);

            modelBuilder.Entity<EntidadSCNF>()
                .Property(e => e.OrigenRecurso)
                .IsUnicode(false);

            modelBuilder.Entity<EntidadSCNF>()
                .Property(e => e.OrigenRecursoDesc)
                .IsUnicode(false);

            modelBuilder.Entity<EntidadSCNF>()
                .Property(e => e.MontoRecursoPropio)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Impuestos_Locales>()
                .Property(e => e.Version)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Impuestos_Locales>()
                .Property(e => e.TotalRetenciones)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Impuestos_Locales>()
                .Property(e => e.TotalTraslados)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Impuestos_Locales>()
                .HasMany(e => e.Impuestos_Retenciones_Locales)
                .WithRequired(e => e.Impuestos_Locales)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Impuestos_Locales>()
                .HasMany(e => e.Impuestos_Traslados_Locales)
                .WithRequired(e => e.Impuestos_Locales)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Impuestos_Pagos>()
                .Property(e => e.IdPago)
                .IsUnicode(false);

            modelBuilder.Entity<Impuestos_Pagos>()
                .Property(e => e.TotalImpuestosRetenidos)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Impuestos_Pagos>()
                .Property(e => e.TotalImpuestosTrasladados)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Impuestos_Pagos>()
                .Property(e => e.IdImpuesto)
                .IsUnicode(false);

            modelBuilder.Entity<Impuestos_Pagos>()
                .HasMany(e => e.Impuestos_Retencion_Pago)
                .WithRequired(e => e.Impuestos_Pagos)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Impuestos_Pagos>()
                .HasMany(e => e.Impuestos_Traslado_Pago)
                .WithRequired(e => e.Impuestos_Pagos)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Impuestos_Retenciones_Locales>()
                .Property(e => e.ImpDetalle)
                .IsUnicode(false);

            modelBuilder.Entity<Impuestos_Retenciones_Locales>()
                .Property(e => e.ImpLocalRetenido)
                .IsUnicode(false);

            modelBuilder.Entity<Impuestos_Retenciones_Locales>()
                .Property(e => e.TasadeRetencion)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Impuestos_Retenciones_Locales>()
                .Property(e => e.ImporteRetenido)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Impuestos_Traslados_Locales>()
                .Property(e => e.ImpDetalle)
                .IsUnicode(false);

            modelBuilder.Entity<Impuestos_Traslados_Locales>()
                .Property(e => e.ImpLocalTrasladado)
                .IsUnicode(false);

            modelBuilder.Entity<Impuestos_Traslados_Locales>()
                .Property(e => e.TasadeTraslado)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Impuestos_Traslados_Locales>()
                .Property(e => e.ImporteTraslado)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Nomina>()
                .Property(e => e.Version)
                .IsUnicode(false);

            modelBuilder.Entity<Nomina>()
                .Property(e => e.TipoNomina)
                .IsUnicode(false);

            modelBuilder.Entity<Nomina>()
                .Property(e => e.TipoNominaDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Nomina>()
                .Property(e => e.NumDiasPagados)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Nomina>()
                .Property(e => e.TotalPercepciones)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Nomina>()
                .Property(e => e.TotalDeducciones)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Nomina>()
                .Property(e => e.TotalOtrosPagos)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Nomina>()
                .Property(e => e.RegistroPatronal)
                .IsUnicode(false);

            modelBuilder.Entity<Nomina>()
                .Property(e => e.NumSeguridadSocialRec)
                .IsUnicode(false);

            modelBuilder.Entity<Nomina>()
                .Property(e => e.Antiguedad)
                .IsUnicode(false);

            modelBuilder.Entity<Nomina>()
                .Property(e => e.TipoContrato)
                .IsUnicode(false);

            modelBuilder.Entity<Nomina>()
                .Property(e => e.TipoContratoDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Nomina>()
                .Property(e => e.Sindicalizado)
                .IsUnicode(false);

            modelBuilder.Entity<Nomina>()
                .Property(e => e.TipoJornada)
                .IsUnicode(false);

            modelBuilder.Entity<Nomina>()
                .Property(e => e.TipoJornadaDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Nomina>()
                .Property(e => e.TipoRegimen)
                .IsUnicode(false);

            modelBuilder.Entity<Nomina>()
                .Property(e => e.TipoRegimenDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Nomina>()
                .Property(e => e.NumEmpleadoRec)
                .IsUnicode(false);

            modelBuilder.Entity<Nomina>()
                .Property(e => e.DepartamentoRec)
                .IsUnicode(false);

            modelBuilder.Entity<Nomina>()
                .Property(e => e.PuestoRec)
                .IsUnicode(false);

            modelBuilder.Entity<Nomina>()
                .Property(e => e.RiesgoPuesto)
                .IsUnicode(false);

            modelBuilder.Entity<Nomina>()
                .Property(e => e.RiesgoPuestoDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Nomina>()
                .Property(e => e.PeriodicidadPago)
                .IsUnicode(false);

            modelBuilder.Entity<Nomina>()
                .Property(e => e.PeriodicidadPagoDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Nomina>()
                .Property(e => e.Banco)
                .IsUnicode(false);

            modelBuilder.Entity<Nomina>()
                .Property(e => e.BancoDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Nomina>()
                .Property(e => e.SalarioBaseCotApor)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Nomina>()
                .Property(e => e.SalarioDiarioIntegrado)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Nomina>()
                .Property(e => e.ClaveEntFed)
                .IsUnicode(false);

            modelBuilder.Entity<Nomina>()
                .Property(e => e.ClaveEntFedDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Nomina>()
                .Property(e => e.TotalSueldos)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Nomina>()
                .Property(e => e.TotalSeparacionIndemnizacion)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Nomina>()
                .Property(e => e.TotalGravadoPercepcion)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Nomina>()
                .Property(e => e.TotalExentoPercepcion)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Nomina>()
                .Property(e => e.TotalGravadoDeduccion)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Nomina>()
                .Property(e => e.TotalExentoDeduccion)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Nomina>()
                .Property(e => e.TotalPagado)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Nomina>()
                .Property(e => e.UltimoSueldoMesOrd)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Nomina>()
                .Property(e => e.IngresoAcumulable)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Nomina>()
                .Property(e => e.IngresoNoAcumulable)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Nomina>()
                .Property(e => e.TotalOtrasDeducciones)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Nomina>()
                .Property(e => e.TotalImpuestosRetenidos)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Nomina>()
                .Property(e => e.SaldoAFavor)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Nomina>()
                .Property(e => e.RemanenteSalFav)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Nomina>()
                .Property(e => e.SubsidioCausado)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Nomina>()
                .Property(e => e.CuentaBancaria)
                .IsUnicode(false);

            modelBuilder.Entity<Nomina>()
                .Property(e => e.CURPReceptor)
                .IsUnicode(false);

            modelBuilder.Entity<Nomina>()
                .HasMany(e => e.EntidadSCNF)
                .WithRequired(e => e.Nomina)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Nomina>()
                .HasMany(e => e.Nomina_Detalle)
                .WithRequired(e => e.Nomina)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Nomina>()
                .HasMany(e => e.Nomina_HorasExtras)
                .WithRequired(e => e.Nomina)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Nomina>()
                .HasMany(e => e.Nomina_Incapacidad)
                .WithRequired(e => e.Nomina)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Nomina>()
                .HasMany(e => e.Nomina_Subcontratacion)
                .WithRequired(e => e.Nomina)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Nomina_Detalle>()
                .Property(e => e.TipoNominaDetalle)
                .IsUnicode(false);

            modelBuilder.Entity<Nomina_Detalle>()
                .Property(e => e.IdDetalle)
                .IsUnicode(false);

            modelBuilder.Entity<Nomina_Detalle>()
                .Property(e => e.TipoDetalle)
                .IsUnicode(false);

            modelBuilder.Entity<Nomina_Detalle>()
                .Property(e => e.TipoDetalleDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Nomina_Detalle>()
                .Property(e => e.Clave)
                .IsUnicode(false);

            modelBuilder.Entity<Nomina_Detalle>()
                .Property(e => e.Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<Nomina_Detalle>()
                .Property(e => e.ImporteGravado)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Nomina_Detalle>()
                .Property(e => e.ImporteExento)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Nomina_Detalle>()
                .Property(e => e.Importe)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Nomina_HorasExtras>()
                .Property(e => e.IdDetalle)
                .IsUnicode(false);

            modelBuilder.Entity<Nomina_HorasExtras>()
                .Property(e => e.IdHoraExtra)
                .IsUnicode(false);

            modelBuilder.Entity<Nomina_HorasExtras>()
                .Property(e => e.Dias)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Nomina_HorasExtras>()
                .Property(e => e.TiposHoras)
                .IsUnicode(false);

            modelBuilder.Entity<Nomina_HorasExtras>()
                .Property(e => e.TiposHoras_Desc)
                .IsUnicode(false);

            modelBuilder.Entity<Nomina_HorasExtras>()
                .Property(e => e.HorasExtra)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Nomina_HorasExtras>()
                .Property(e => e.Importe)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Nomina_Incapacidad>()
                .Property(e => e.IdIncapacidad)
                .IsUnicode(false);

            modelBuilder.Entity<Nomina_Incapacidad>()
                .Property(e => e.Dias)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Nomina_Incapacidad>()
                .Property(e => e.TipoIncapacidad)
                .IsUnicode(false);

            modelBuilder.Entity<Nomina_Incapacidad>()
                .Property(e => e.TipoIncapacidad_Desc)
                .IsUnicode(false);

            modelBuilder.Entity<Nomina_Incapacidad>()
                .Property(e => e.Importe)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Nomina_Subcontratacion>()
                .Property(e => e.IdSub)
                .IsUnicode(false);

            modelBuilder.Entity<Nomina_Subcontratacion>()
                .Property(e => e.RFCLabora)
                .IsUnicode(false);

            modelBuilder.Entity<Nomina_Subcontratacion>()
                .Property(e => e.PorcTiempo)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Pagos>()
                .Property(e => e.IdPago)
                .IsUnicode(false);

            modelBuilder.Entity<Pagos>()
                .Property(e => e.Version)
                .IsUnicode(false);

            modelBuilder.Entity<Pagos>()
                .Property(e => e.FormaDePagoP)
                .IsUnicode(false);

            modelBuilder.Entity<Pagos>()
                .Property(e => e.FormaDePagoPDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Pagos>()
                .Property(e => e.MonedaP)
                .IsUnicode(false);

            modelBuilder.Entity<Pagos>()
                .Property(e => e.MonedaPDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Pagos>()
                .Property(e => e.TipoCambioP)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Pagos>()
                .Property(e => e.Monto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Pagos>()
                .Property(e => e.NumOperacion)
                .IsUnicode(false);

            modelBuilder.Entity<Pagos>()
                .Property(e => e.RfcEmisorCtaOrd)
                .IsUnicode(false);

            modelBuilder.Entity<Pagos>()
                .Property(e => e.NomBancoOrdExt)
                .IsUnicode(false);

            modelBuilder.Entity<Pagos>()
                .Property(e => e.CtaOrdenante)
                .IsUnicode(false);

            modelBuilder.Entity<Pagos>()
                .Property(e => e.RfcEmisorCtaBen)
                .IsUnicode(false);

            modelBuilder.Entity<Pagos>()
                .Property(e => e.CtaBeneficiario)
                .IsUnicode(false);

            modelBuilder.Entity<Pagos>()
                .Property(e => e.TipoCadPago)
                .IsUnicode(false);

            modelBuilder.Entity<Pagos>()
                .Property(e => e.TipoCadPagoDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Pagos>()
                .HasMany(e => e.Impuestos_Pagos)
                .WithRequired(e => e.Pagos)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pagos>()
                .HasMany(e => e.Pagos_Doc_Rel)
                .WithRequired(e => e.Pagos)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Partes>()
                .Property(e => e.IdConcepto)
                .IsUnicode(false);

            modelBuilder.Entity<Partes>()
                .Property(e => e.IdParte)
                .IsUnicode(false);

            modelBuilder.Entity<Partes>()
                .Property(e => e.CveProdSer)
                .IsUnicode(false);

            modelBuilder.Entity<Partes>()
                .Property(e => e.CveProdSerDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Partes>()
                .Property(e => e.NoIdentificacion)
                .IsUnicode(false);

            modelBuilder.Entity<Partes>()
                .Property(e => e.Cantidad)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Partes>()
                .Property(e => e.Unidad)
                .IsUnicode(false);

            modelBuilder.Entity<Partes>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Partes>()
                .Property(e => e.ValorUnitario)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Partes>()
                .Property(e => e.Importe)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Retenciones>()
                .Property(e => e.Nacionalidad)
                .IsUnicode(false);

            modelBuilder.Entity<Retenciones>()
                .Property(e => e.NumRegIdTrib)
                .IsUnicode(false);

            modelBuilder.Entity<Retenciones>()
                .Property(e => e.MontoTotOperacion)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Retenciones>()
                .Property(e => e.MontoTotGrav)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Retenciones>()
                .Property(e => e.MontoTotExent)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Retenciones>()
                .Property(e => e.MontoTotRet)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Retenciones>()
                .Property(e => e.Version)
                .IsUnicode(false);

            modelBuilder.Entity<Retenciones>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<Retenciones>()
                .Property(e => e.NumCert)
                .IsUnicode(false);

            modelBuilder.Entity<Retenciones>()
                .Property(e => e.CveRetenc)
                .IsUnicode(false);

            modelBuilder.Entity<Retenciones>()
                .Property(e => e.DescRetenc)
                .IsUnicode(false);

            modelBuilder.Entity<Retenciones>()
                .Property(e => e.RFCEmisor)
                .IsUnicode(false);

            modelBuilder.Entity<Retenciones>()
                .Property(e => e.NomDenRazSocE)
                .IsUnicode(false);

            modelBuilder.Entity<Retenciones>()
                .Property(e => e.CURPE)
                .IsUnicode(false);

            modelBuilder.Entity<Retenciones>()
                .Property(e => e.RFCRecep)
                .IsUnicode(false);

            modelBuilder.Entity<Retenciones>()
                .Property(e => e.NomDenRazSocR)
                .IsUnicode(false);

            modelBuilder.Entity<Retenciones>()
                .Property(e => e.CURPR)
                .IsUnicode(false);

            modelBuilder.Entity<Retenciones>()
                .Property(e => e.NomDenRazSocRExt)
                .IsUnicode(false);

            modelBuilder.Entity<Retenciones>()
                .HasMany(e => e.RetencionesXImp)
                .WithRequired(e => e.Retenciones)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RetencionesXImp>()
                .Property(e => e.IdImpuestoRet)
                .IsUnicode(false);

            modelBuilder.Entity<RetencionesXImp>()
                .Property(e => e.BaseRet)
                .HasPrecision(18, 6);

            modelBuilder.Entity<RetencionesXImp>()
                .Property(e => e.Impuesto)
                .IsUnicode(false);

            modelBuilder.Entity<RetencionesXImp>()
                .Property(e => e.ImpuestoDesc)
                .IsUnicode(false);

            modelBuilder.Entity<RetencionesXImp>()
                .Property(e => e.montoRet)
                .HasPrecision(18, 6);

            modelBuilder.Entity<RetencionesXImp>()
                .Property(e => e.TipoPagoRet)
                .IsUnicode(false);

            modelBuilder.Entity<CfdiRelacionados>()
                .Property(e => e.TipoRelacion)
                .IsUnicode(false);

            modelBuilder.Entity<CfdiRelacionados>()
                .Property(e => e.TipoRelacionDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Diccionario>()
                .Property(e => e.Label)
                .IsUnicode(false);

            modelBuilder.Entity<Diccionario>()
                .Property(e => e.Field)
                .IsUnicode(false);

            modelBuilder.Entity<Diccionario>()
                .Property(e => e.Table)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentRef>()
                .Property(e => e.AggregationType)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentRef>()
                .Property(e => e.ApplicationType)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentRef>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentRefPivot>()
                .Property(e => e.AggregationType)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentRefPivot>()
                .Property(e => e.ApplicationType)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentRefPivot>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentStatus>()
                .Property(e => e.IdError)
                .IsUnicode(false);

            modelBuilder.Entity<EstatusProceso>()
                .Property(e => e.Comentario)
                .IsUnicode(false);

            modelBuilder.Entity<Expedientes>()
                .Property(e => e.ApplicationType_Exp)
                .IsUnicode(false);

            modelBuilder.Entity<Expedientes>()
                .Property(e => e.Type_Exp)
                .IsUnicode(false);

            modelBuilder.Entity<Expedientes>()
                .Property(e => e.Comment_Exp)
                .IsUnicode(false);

            modelBuilder.Entity<Impuesto_Retencion>()
                .Property(e => e.Impuesto)
                .IsUnicode(false);

            modelBuilder.Entity<Impuesto_Retencion>()
                .Property(e => e.ImpuestoDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Impuesto_Retencion>()
                .Property(e => e.Importe)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Impuesto_Retencion_Concepto>()
                .Property(e => e.IdConcepto)
                .IsUnicode(false);

            modelBuilder.Entity<Impuesto_Retencion_Concepto>()
                .Property(e => e.Base)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Impuesto_Retencion_Concepto>()
                .Property(e => e.Impuesto)
                .IsUnicode(false);

            modelBuilder.Entity<Impuesto_Retencion_Concepto>()
                .Property(e => e.ImpuestoDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Impuesto_Retencion_Concepto>()
                .Property(e => e.TipoFactor)
                .IsUnicode(false);

            modelBuilder.Entity<Impuesto_Retencion_Concepto>()
                .Property(e => e.TasaOCuota)
                .IsUnicode(false);

            modelBuilder.Entity<Impuesto_Retencion_Concepto>()
                .Property(e => e.Importe)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Impuesto_Traslado>()
                .Property(e => e.Impuesto)
                .IsUnicode(false);

            modelBuilder.Entity<Impuesto_Traslado>()
                .Property(e => e.ImpuestoDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Impuesto_Traslado>()
                .Property(e => e.TipoFactor)
                .IsUnicode(false);

            modelBuilder.Entity<Impuesto_Traslado>()
                .Property(e => e.TasaOCuota)
                .IsUnicode(false);

            modelBuilder.Entity<Impuesto_Traslado>()
                .Property(e => e.Importe)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Impuesto_Traslado_Concepto>()
                .Property(e => e.IdConcepto)
                .IsUnicode(false);

            modelBuilder.Entity<Impuesto_Traslado_Concepto>()
                .Property(e => e.Base)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Impuesto_Traslado_Concepto>()
                .Property(e => e.Impuesto)
                .IsUnicode(false);

            modelBuilder.Entity<Impuesto_Traslado_Concepto>()
                .Property(e => e.ImpuestoDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Impuesto_Traslado_Concepto>()
                .Property(e => e.TipoFactor)
                .IsUnicode(false);

            modelBuilder.Entity<Impuesto_Traslado_Concepto>()
                .Property(e => e.TasaOCuota)
                .IsUnicode(false);

            modelBuilder.Entity<Impuesto_Traslado_Concepto>()
                .Property(e => e.Importe)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Impuestos_Retencion_Pago>()
                .Property(e => e.IdImpuesto)
                .IsUnicode(false);

            modelBuilder.Entity<Impuestos_Retencion_Pago>()
                .Property(e => e.Impuesto)
                .IsUnicode(false);

            modelBuilder.Entity<Impuestos_Retencion_Pago>()
                .Property(e => e.ImpuestoDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Impuestos_Retencion_Pago>()
                .Property(e => e.Importe)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Impuestos_Traslado_Pago>()
                .Property(e => e.IdImpuesto)
                .IsUnicode(false);

            modelBuilder.Entity<Impuestos_Traslado_Pago>()
                .Property(e => e.Impuesto)
                .IsUnicode(false);

            modelBuilder.Entity<Impuestos_Traslado_Pago>()
                .Property(e => e.ImpuestoDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Impuestos_Traslado_Pago>()
                .Property(e => e.TipoFactor)
                .IsUnicode(false);

            modelBuilder.Entity<Impuestos_Traslado_Pago>()
                .Property(e => e.TasaOCuota)
                .IsUnicode(false);

            modelBuilder.Entity<Impuestos_Traslado_Pago>()
                .Property(e => e.Importe)
                .HasPrecision(18, 6);

            modelBuilder.Entity<MigradorLog>()
                .Property(e => e.ErrorMessage)
                .IsUnicode(false);

            modelBuilder.Entity<MigradorLog>()
                .Property(e => e.FileName)
                .IsUnicode(false);

            modelBuilder.Entity<MigradorLog>()
                .Property(e => e.Origen)
                .IsUnicode(false);

            modelBuilder.Entity<Pagos_Doc_Rel>()
                .Property(e => e.IdPago)
                .IsUnicode(false);

            modelBuilder.Entity<Pagos_Doc_Rel>()
                .Property(e => e.IdDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<Pagos_Doc_Rel>()
                .Property(e => e.Serie)
                .IsUnicode(false);

            modelBuilder.Entity<Pagos_Doc_Rel>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<Pagos_Doc_Rel>()
                .Property(e => e.MonedaDR)
                .IsUnicode(false);

            modelBuilder.Entity<Pagos_Doc_Rel>()
                .Property(e => e.MonedaDRDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Pagos_Doc_Rel>()
                .Property(e => e.TipoCambioDR)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Pagos_Doc_Rel>()
                .Property(e => e.MetodoDePagoDR)
                .IsUnicode(false);

            modelBuilder.Entity<Pagos_Doc_Rel>()
                .Property(e => e.MetodoDePagoDRDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Pagos_Doc_Rel>()
                .Property(e => e.ImpSaldoAnt)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Pagos_Doc_Rel>()
                .Property(e => e.ImpPagado)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Pagos_Doc_Rel>()
                .Property(e => e.ImpSaldoInsoluto)
                .HasPrecision(18, 6);
        }
    }
}