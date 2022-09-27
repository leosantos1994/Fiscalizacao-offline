using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace Fiscalizacao.Repository
{
    [DbConfigurationType(typeof(SQLiteConfiguration))]
    public class AppDBContext : DbContext
    {
        //public AppDBContext() :
        //    base(new SQLiteConnection()
        //    {
        //        ConnectionString = new SQLiteConnectionStringBuilder() { DataSource = "C:\\Databases\\SQLiteWithEF.db", ForeignKeys = true }.ConnectionString
        //    }, true)
        //{ }

        public AppDBContext() : base("mydb10")
        {

        }

        public DbSet<Models.PessoaModel> Pessoa { get; set; }
        public DbSet<Models.FinanceiroModel> Financeiro { get; set; }
        public DbSet<Models.ProtocoloModel> Protocolo { get; set; }
        public DbSet<Models.ProcessoModel> ProcessoTedAdm { get; set; }
        public DbSet<Models.ProcessoFiscalizacaoModel> ProcessoFiscalizacao { get; set; }
        //public DbSet<Models.ProcessoModel> ProcessoJuridico { get; set; }
        public DbSet<Models.ProcessoTramiteModel> TramiteTedAdm { get; set; }
        public DbSet<Models.ProcessoTramiteFiscalizacaoModel> TramiteFiscalizacao { get; set; }
        public DbSet<Models.VinculoProfissionalModel> VinculoProfissional { get; set; }
        public DbSet<Models.OutrosContatosModel> OutroContato { get; set; }
        public DbSet<Models.HistoricoOcorrenciaModel> Ocorrencia { get; set; }
        public DbSet<Models.HistoricoInscricaoModel> Inscricao { get; set; }
        public DbSet<Models.FormacaoAcademicaModel> Formacao { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            FinanceiroConfiguration(modelBuilder);

            OutrosContatosConfiguration(modelBuilder);

            ProcessoConfiguration(modelBuilder);

            ProcessoFiscalizacaoConfiguration(modelBuilder);

            ProcessoTramite(modelBuilder);

            ProcessoTramiteFiscalizacao(modelBuilder);

            ProtocoloConfiguration(modelBuilder);

            VinculoProfissionalConfiguration(modelBuilder);

            HistoricoOcorrenciaConfiguration(modelBuilder);

            InscricaoConfiguration(modelBuilder);

            FormacaoConfiguration(modelBuilder);

            RenameTablesOnCreation(modelBuilder);

            modelBuilder.Properties<DateTime>().Configure(c => c.HasColumnType("datetime2"));
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }

        private void ProcessoTramiteFiscalizacao(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.ProcessoTramiteFiscalizacaoModel>()
                                .HasRequired<Models.ProcessoFiscalizacaoModel>(p => p.Processo)
                                .WithMany(p => p.ProcessoTramite)
                                .HasForeignKey<int>(s => s.ProcessoId)
                                .WillCascadeOnDelete(false);
        }


        private void ProcessoTramite(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.ProcessoTramiteModel>()
                                .HasRequired<Models.ProcessoModel>(p => p.Processo)
                                .WithMany(p => p.ProcessoTramite)
                                .HasForeignKey<int>(s => s.ProcessoId)
                                .WillCascadeOnDelete(false);
        }

        private void ProcessoFiscalizacaoConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.ProcessoFiscalizacaoModel>()
                                .HasOptional<Models.PessoaModel>(p => p.Representado)
                                .WithMany(p => p.ProcessoRepresentadoFiscalizacao)
                                .HasForeignKey<int?>(s => s.RepresentadoId)
                                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Models.ProcessoFiscalizacaoModel>()
                            .HasOptional<Models.PessoaModel>(p => p.Representante)
                            .WithMany(p => p.ProcessoRepresentanteFiscalizacao)
                            .HasForeignKey<int?>(s => s.RepresentanteId)
                            .WillCascadeOnDelete(false);
        }

        private void ProcessoConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.ProcessoModel>()
                                .HasRequired(p => p.Representado)
                                .WithMany()
                                .HasForeignKey(s => s.RepresentadoId)
                                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Models.ProcessoModel>()
                            .HasOptional(p => p.Representante)
                            .WithMany()
                            .HasForeignKey(s => s.RepresentanteId)
                            .WillCascadeOnDelete(false);
        }

        private void FormacaoConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.FormacaoAcademicaModel>()
                                .HasRequired<Models.PessoaModel>(p => p.Pessoa)
                                .WithMany(p => p.Formacao)
                                .HasForeignKey<int>(s => s.PessoaId)
                                .WillCascadeOnDelete(false);
        }

        private void InscricaoConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.HistoricoInscricaoModel>()
                                .HasRequired<Models.PessoaModel>(p => p.Pessoa)
                                .WithMany(p => p.Inscricao)
                                .HasForeignKey<int>(s => s.PessoaId)
                                .WillCascadeOnDelete(false);
        }

        private void HistoricoOcorrenciaConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.HistoricoOcorrenciaModel>()
                    .HasRequired<Models.PessoaModel>(p => p.Pessoa)
                    .WithMany(p => p.Ocorrencia)
                    .HasForeignKey<int>(s => s.PessoaId)
                    .WillCascadeOnDelete(false);
        }

        private void VinculoProfissionalConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.VinculoProfissionalModel>()
                    .HasOptional<Models.PessoaModel>(p => p.Pessoa)
                    .WithMany(p => p.VinculoProfissional)
                    .HasForeignKey<int?>(s => s.PessoaId)
                    .WillCascadeOnDelete(false);

            modelBuilder.Entity<Models.VinculoProfissionalModel>()
                    .HasOptional<Models.PessoaModel>(p => p.PessoaJuridica)
                    .WithMany(p => p.VinculoProfissionalPJ)
                    .HasForeignKey<int?>(s => s.PessoaJuridicaId)
                    .WillCascadeOnDelete(false);
        }

        private void ProtocoloConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.ProtocoloModel>()
                    .HasRequired<Models.PessoaModel>(p => p.Pessoa)
                    .WithMany(p => p.Protocolo)
                    .HasForeignKey<int>(s => s.PessoaId)
                    .WillCascadeOnDelete(false);

            modelBuilder.Entity<Models.ProtocoloModel>()
                    .HasOptional<Models.PessoaModel>(p => p.PessoaJuridica)
                    .WithMany(p => p.ProtocoloPJ)
                    .HasForeignKey<int?>(s => s.PessoaJuridicaId)
                    .WillCascadeOnDelete(false);
        }

        private void OutrosContatosConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.OutrosContatosModel>()
                    .HasRequired<Models.PessoaModel>(p => p.Pessoa)
                    .WithMany(p => p.OutrosContatos)
                    .HasForeignKey<int>(s => s.PessoaId)
                    .WillCascadeOnDelete(false);
        }

        private void FinanceiroConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.FinanceiroModel>()
                                .HasRequired<Models.PessoaModel>(p => p.Pessoa)
                                .WithMany(p => p.Financeiro)
                                .HasForeignKey<int>(s => s.PessoaId)
                                .WillCascadeOnDelete(false);
        }

        private void RenameTablesOnCreation(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.PessoaModel>()
                       .ToTable("Pessoas");
            modelBuilder.Entity<Models.FinanceiroModel>()
                        .ToTable("Financeiros");
            modelBuilder.Entity<Models.ProtocoloModel>()
                        .ToTable("Protocolos");
            modelBuilder.Entity<Models.ProcessoModel>()
                        .ToTable("Processos");
            modelBuilder.Entity<Models.VinculoProfissionalModel>()
                        .ToTable("VinculosPofissionais");
            modelBuilder.Entity<Models.OutrosContatosModel>()
                        .ToTable("OutrosContatos");
            modelBuilder.Entity<Models.HistoricoOcorrenciaModel>()
                        .ToTable("Ocorrencias");
            modelBuilder.Entity<Models.HistoricoInscricaoModel>()
                        .ToTable("Inscricoes");
            modelBuilder.Entity<Models.ProcessoFiscalizacaoModel>()
                        .ToTable("ProcessoFIS");
            modelBuilder.Entity<Models.FormacaoAcademicaModel>()
                       .ToTable("Formacao");
            modelBuilder.Entity<Models.ProcessoTramiteModel>()
                       .ToTable("Tramite");
            modelBuilder.Entity<Models.ProcessoTramiteFiscalizacaoModel>()
                        .ToTable("TramiteFIS");
        }
    }
}
