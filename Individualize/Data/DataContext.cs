using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Individualize.Models;

namespace Individualize.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        public virtual DbSet<AbastecimentoAgua> AbastecimentoAgua { get; set; }
        public virtual DbSet<Acao> Acao { get; set; }
        public virtual DbSet<AgendamentoVistoria> AgendamentoVistoria { get; set; }
        public virtual DbSet<AgendamentoVistoriaTram> AgendamentoVistoriaTram { get; set; }
        public virtual DbSet<Alerta> Alerta { get; set; }
        public virtual DbSet<Bairro> Bairro { get; set; }
        public virtual DbSet<Cidade> Cidade { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Condominio> Condominio { get; set; }
        public virtual DbSet<CondominioAbastecimento> CondominioAbastecimento { get; set; }
        public virtual DbSet<CondominioPrecoAgua> CondominioPrecoAgua { get; set; }
        public virtual DbSet<CondominioPrecoGas> CondominioPrecoGas { get; set; }
        public virtual DbSet<CondominioTorres> CondominioTorres { get; set; }
        public virtual DbSet<Estado> Estado { get; set; }
        public virtual DbSet<Fornecedor> Fornecedor { get; set; }
        public virtual DbSet<Funcao> Funcao { get; set; }
        public virtual DbSet<Funcionario> Funcionario { get; set; }
        public virtual DbSet<LogAcesso> LogAcesso { get; set; }
        public virtual DbSet<Measurings> Measurings { get; set; }
        public virtual DbSet<Medicao> Medicao { get; set; }
        public virtual DbSet<MedicaoItem> MedicaoItem { get; set; }
        public virtual DbSet<MedicaoItemGasometro> MedicaoItemGasometro { get; set; }
        public virtual DbSet<MedicaoItemHidrometro> MedicaoItemHidrometro { get; set; }
        public virtual DbSet<MedicaoPrecoAgua> MedicaoPrecoAgua { get; set; }
        public virtual DbSet<MedicaoPrecoGas> MedicaoPrecoGas { get; set; }
        public virtual DbSet<Modulo> Modulo { get; set; }
        public virtual DbSet<Noticia> Noticia { get; set; }
        public virtual DbSet<Notificacao> Notificacao { get; set; }
        public virtual DbSet<Objeto> Objeto { get; set; }
        public virtual DbSet<ObjetoAcao> ObjetoAcao { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<ParSis> ParSis { get; set; }
        public virtual DbSet<Patrimonio> Patrimonio { get; set; }
        public virtual DbSet<Perfil> Perfil { get; set; }
        public virtual DbSet<PerfilMenu> PerfilMenu { get; set; }
        public virtual DbSet<PerfilObjeto> PerfilObjeto { get; set; }
        public virtual DbSet<PerfilObjetoAcoes> PerfilObjetoAcoes { get; set; }
        public virtual DbSet<PerfilUnidades> PerfilUnidades { get; set; }
        public virtual DbSet<Pessoa> Pessoa { get; set; }
        public virtual DbSet<PessoaDependente> PessoaDependente { get; set; }
        public virtual DbSet<QuestSocial> QuestSocial { get; set; }
        public virtual DbSet<QuestSocialAlternativa> QuestSocialAlternativa { get; set; }
        public virtual DbSet<QuestSocialCondominio> QuestSocialCondominio { get; set; }
        public virtual DbSet<QuestSocialPessoa> QuestSocialPessoa { get; set; }
        public virtual DbSet<Unidade> Unidade { get; set; }
        public virtual DbSet<UnidadeGasometro> UnidadeGasometro { get; set; }
        public virtual DbSet<UnidadeHidrometro> UnidadeHidrometro { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AbastecimentoAgua>(entity =>
            {
                entity.HasKey(e => new { e.CondominioId, e.AbastecimentoAguaId })
                    .HasName("PK__Abasteci__94184405C7123D22");

                entity.HasIndex(e => e.FornecedorId)
                    .HasName("IABASTECIMENTOAGUA1");

                entity.Property(e => e.AbastecimentoAguaData).HasColumnType("datetime");

                entity.Property(e => e.AbastecimentoAguaQtd).HasColumnType("smallmoney");

                entity.Property(e => e.AbastecimentoAguaValor).HasColumnType("money");

                entity.Property(e => e.FornecedorId).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Condominio)
                    .WithMany(p => p.AbastecimentoAgua)
                    .HasForeignKey(d => d.CondominioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IABASTECIMENTOAGUA2");

                entity.HasOne(d => d.Fornecedor)
                    .WithMany(p => p.AbastecimentoAgua)
                    .HasForeignKey(d => d.FornecedorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IABASTECIMENTOAGUA1");
            });

            modelBuilder.Entity<Acao>(entity =>
            {
                entity.Property(e => e.AcaoDsc)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AgendamentoVistoria>(entity =>
            {
                entity.HasKey(e => e.AgendamentoVistCod)
                    .HasName("PK__Agendame__5553F15D7884B149");

                entity.HasIndex(e => e.AlertaId)
                    .HasName("IAGENDAMENTOVISTORIA2");

                entity.HasIndex(e => e.UnidadeId)
                    .HasName("IAGENDAMENTOVISTORIA1");

                entity.Property(e => e.AgendamentoVistContatoTexto)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AgendamentoVistData).HasColumnType("datetime");

                entity.Property(e => e.AgendamentoVistDataResp).HasColumnType("datetime");

                entity.Property(e => e.AgendamentoVistObs)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AgendamentoVistProtocolo)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.AgendamentoVistResposta).IsUnicode(false);

                entity.Property(e => e.AgendamentoVistTitulo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Alerta)
                    .WithMany(p => p.AgendamentoVistoria)
                    .HasForeignKey(d => d.AlertaId)
                    .HasConstraintName("IAGENDAMENTOVISTORIA2");

                entity.HasOne(d => d.Unidade)
                    .WithMany(p => p.AgendamentoVistoria)
                    .HasForeignKey(d => d.UnidadeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IAGENDAMENTOVISTORIA1");
            });

            modelBuilder.Entity<AgendamentoVistoriaTram>(entity =>
            {
                entity.HasKey(e => e.AgendamentoVistTramCod)
                    .HasName("PK__Agendame__FB8CBCC88CF2B08F");

                entity.HasIndex(e => e.AgendamentoVistCod)
                    .HasName("IAGENDAMENTOVISTORIATRAM1");

                entity.Property(e => e.AgendamentoVistTramAcao)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.AgendamentoVistTramData).HasColumnType("datetime");

                entity.Property(e => e.AgendamentoVistTramTexto).IsUnicode(false);

                entity.Property(e => e.AgendamentoVistTramUsuario)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.AgendamentoVistCodNavigation)
                    .WithMany(p => p.AgendamentoVistoriaTram)
                    .HasForeignKey(d => d.AgendamentoVistCod)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IAGENDAMENTOVISTORIATRAM1");
            });

            modelBuilder.Entity<Alerta>(entity =>
            {
                entity.HasIndex(e => e.CondominioId)
                    .HasName("IALERTA1");

                entity.HasIndex(e => e.FuncionarioId)
                    .HasName("IALERTA2");

                entity.Property(e => e.AlertaDataOcorrencia).HasColumnType("datetime");

                entity.Property(e => e.AlertaDataResolucao).HasColumnType("datetime");

                entity.Property(e => e.AlertaObs)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.AlertaProvidenciaTomada)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AlertaSituacao)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AlertaTipo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FuncionarioId).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Condominio)
                    .WithMany(p => p.Alerta)
                    .HasForeignKey(d => d.CondominioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IALERTA1");

                entity.HasOne(d => d.Funcionario)
                    .WithMany(p => p.Alerta)
                    .HasForeignKey(d => d.FuncionarioId)
                    .HasConstraintName("IALERTA2");
            });

            modelBuilder.Entity<Bairro>(entity =>
            {
                entity.HasIndex(e => e.CidadeId)
                    .HasName("IBAIRRO1");

                entity.Property(e => e.BairroDsc)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Cidade)
                    .WithMany(p => p.Bairro)
                    .HasForeignKey(d => d.CidadeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IBAIRRO1");
            });

            modelBuilder.Entity<Cidade>(entity =>
            {
                entity.HasIndex(e => e.EstadoId)
                    .HasName("ICIDADE1");

                entity.Property(e => e.CidadeDsc)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Estado)
                    .WithMany(p => p.Cidade)
                    .HasForeignKey(d => d.EstadoId)
                    .HasConstraintName("ICIDADE1");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.Property(e => e.ClienteId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ClienteAltEm).HasColumnType("datetime");

                entity.Property(e => e.ClienteCpf)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClienteIncEm).HasColumnType("datetime");

                entity.HasOne(d => d.ClienteNavigation)
                    .WithOne(p => p.Cliente)
                    .HasForeignKey<Cliente>(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ICLIENTE");
            });

            modelBuilder.Entity<Condominio>(entity =>
            {
                entity.HasIndex(e => e.CondominioBairroId)
                    .HasName("ICONDOMINIO3");

                entity.HasIndex(e => e.CondominioFornecedorAguaId)
                    .HasName("ICONDOMINIO1");

                entity.HasIndex(e => e.CondominioFornecedorGasId)
                    .HasName("ICONDOMINIO2");

                entity.Property(e => e.CondominioAreaComumAgua).HasColumnType("decimal(15, 6)");

                entity.Property(e => e.CondominioAreaComumAguaTipo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CondominioAreaComumGas).HasColumnType("decimal(15, 6)");

                entity.Property(e => e.CondominioAreaComumGasTipo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CondominioBolMensagemAgua)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CondominioBolMensagemRodape)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CondominioDsc)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CondominioFornecedorAguaId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CondominioFornecedorGasId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CondominioIdExport)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PrecoDataFim).HasColumnType("datetime");

                entity.Property(e => e.PrecoDataIni).HasColumnType("datetime");

                entity.HasOne(d => d.CondominioBairro)
                    .WithMany(p => p.Condominio)
                    .HasForeignKey(d => d.CondominioBairroId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ICONDOMINIO3");

                entity.HasOne(d => d.CondominioFornecedorAgua)
                    .WithMany(p => p.CondominioCondominioFornecedorAgua)
                    .HasForeignKey(d => d.CondominioFornecedorAguaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ICONDOMINIO1");

                entity.HasOne(d => d.CondominioFornecedorGas)
                    .WithMany(p => p.CondominioCondominioFornecedorGas)
                    .HasForeignKey(d => d.CondominioFornecedorGasId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ICONDOMINIO2");
            });

            modelBuilder.Entity<CondominioAbastecimento>(entity =>
            {
                entity.HasKey(e => new { e.CondominioId, e.CondominioAbastecimentoId })
                    .HasName("PK__Condomin__4AE220F43D01079E");

                entity.HasIndex(e => e.FornecedorId)
                    .HasName("ICONDOMINIOABASTECIMENTO1");

                entity.Property(e => e.CondominioAbastecimentoData).HasColumnType("datetime");

                entity.Property(e => e.CondominioAbastecimentoQtd).HasColumnType("smallmoney");

                entity.Property(e => e.FornecedorId).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Condominio)
                    .WithMany(p => p.CondominioAbastecimento)
                    .HasForeignKey(d => d.CondominioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ICONDOMINIOABASTECIMENTO2");

                entity.HasOne(d => d.Fornecedor)
                    .WithMany(p => p.CondominioAbastecimento)
                    .HasForeignKey(d => d.FornecedorId)
                    .HasConstraintName("ICONDOMINIOABASTECIMENTO1");
            });

            modelBuilder.Entity<CondominioPrecoAgua>(entity =>
            {
                entity.HasKey(e => new { e.CondominioId, e.PrecoAguaId })
                    .HasName("PK__Condomin__48358A7890F59999");

                entity.HasIndex(e => new { e.CondominioId, e.PrecoAguaQtd })
                    .HasName("UCONDOMINIOPRECOAGUAQTD");

                entity.Property(e => e.PrecoAguaQtd).HasColumnType("smallmoney");

                entity.Property(e => e.PrecoAguaValor).HasColumnType("decimal(15, 6)");

                entity.HasOne(d => d.Condominio)
                    .WithMany(p => p.CondominioPrecoAgua)
                    .HasForeignKey(d => d.CondominioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ICONDOMINIOPRECOAGUA1");
            });

            modelBuilder.Entity<CondominioPrecoGas>(entity =>
            {
                entity.HasKey(e => new { e.CondominioId, e.PrecoGasId })
                    .HasName("PK__Condomin__A9346A4B143527C6");

                entity.HasIndex(e => new { e.CondominioId, e.PrecoGasQtd })
                    .HasName("UCONDOMINIOPRECOGASQTD");

                entity.Property(e => e.PrecoGasQtd).HasColumnType("smallmoney");

                entity.Property(e => e.PrecoGasValor).HasColumnType("decimal(15, 6)");

                entity.HasOne(d => d.Condominio)
                    .WithMany(p => p.CondominioPrecoGas)
                    .HasForeignKey(d => d.CondominioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ICONDOMINIOPRECOGAS1");
            });

            modelBuilder.Entity<CondominioTorres>(entity =>
            {
                entity.HasKey(e => new { e.CondominioId, e.CondominioTorresId })
                    .HasName("PK__Condomin__D0B2223EADEA75E1");

                entity.Property(e => e.CondominioTorresDsc)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CondominioTorresIdExport)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.Condominio)
                    .WithMany(p => p.CondominioTorres)
                    .HasForeignKey(d => d.CondominioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ICONDOMINIOTORRES1");
            });

            modelBuilder.Entity<Estado>(entity =>
            {
                entity.HasIndex(e => e.PaisId)
                    .HasName("IESTADO1");

                entity.Property(e => e.EstadoDsc)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoSigla)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.Pais)
                    .WithMany(p => p.Estado)
                    .HasForeignKey(d => d.PaisId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IESTADO1");
            });

            modelBuilder.Entity<Fornecedor>(entity =>
            {
                entity.Property(e => e.FornecedorId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FornecedorCnpj)
                    .HasColumnName("FornecedorCNPJ")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FornecedorTipo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.FornecedorNavigation)
                    .WithOne(p => p.Fornecedor)
                    .HasForeignKey<Fornecedor>(d => d.FornecedorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IFORNECEDOR");
            });

            modelBuilder.Entity<Funcao>(entity =>
            {
                entity.Property(e => e.FuncaoDsc)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Funcionario>(entity =>
            {
                entity.HasIndex(e => e.FuncaoId)
                    .HasName("IFUNCIONARIO2");

                entity.Property(e => e.FuncionarioId).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Funcao)
                    .WithMany(p => p.Funcionario)
                    .HasForeignKey(d => d.FuncaoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IFUNCIONARIO2");

                entity.HasOne(d => d.FuncionarioNavigation)
                    .WithOne(p => p.Funcionario)
                    .HasForeignKey<Funcionario>(d => d.FuncionarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IFUNCIONARIO");
            });

            modelBuilder.Entity<LogAcesso>(entity =>
            {
                entity.HasIndex(e => e.LogAcessoData)
                    .HasName("ULOGACESSODATA");

                entity.HasIndex(e => e.UsuarioId)
                    .HasName("ILOGACESSO1");

                entity.Property(e => e.LogAcessoData).HasColumnType("datetime");

                entity.Property(e => e.UsuarioId).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.LogAcesso)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ILOGACESSO1");
            });

            modelBuilder.Entity<Measurings>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK__measurin__357D4CF84611C6D9");

                entity.ToTable("measurings");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.Alarm)
                    .IsRequired()
                    .HasColumnName("alarm")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BatteryLifetime).HasColumnName("battery_lifetime");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Device)
                    .IsRequired()
                    .HasColumnName("device")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Measurer)
                    .IsRequired()
                    .HasColumnName("measurer")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Measuring).HasColumnName("measuring");

                entity.Property(e => e.MeasuringType).HasColumnName("measuring_type");

                entity.Property(e => e.Medium).HasColumnName("medium");
            });

            modelBuilder.Entity<Medicao>(entity =>
            {
                entity.HasIndex(e => e.FuncionarioId)
                    .HasName("IMEDICAO1");

                entity.HasIndex(e => e.MedicaoData)
                    .HasName("UMEDICAODATA");

                entity.HasIndex(e => new { e.CondominioId, e.CondominioAbastecimentoId })
                    .HasName("IMEDICAO3");

                entity.HasIndex(e => new { e.CondominioId, e.CondominioTorresId })
                    .HasName("IMEDICAO2");

                entity.Property(e => e.FuncionarioId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.MedicaoAreaComumGas).HasColumnType("smallmoney");

                entity.Property(e => e.MedicaoCondominioAreaComumAgua).HasColumnType("decimal(15, 6)");

                entity.Property(e => e.MedicaoCondominioAreaComumGas).HasColumnType("decimal(15, 6)");

                entity.Property(e => e.MedicaoData).HasColumnType("datetime");

                entity.Property(e => e.MedicaoDensidadeInformada).HasColumnType("decimal(11, 5)");

                entity.Property(e => e.MedicaoDensidadeTipo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MedicaoRegistroGeralAgua).HasColumnType("smallmoney");

                entity.Property(e => e.MedicaoStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MedicaoTotalAreaComumAgua).HasColumnType("decimal(15, 6)");

                entity.Property(e => e.MedicaoTotalAreaComumGas).HasColumnType("decimal(15, 6)");

                entity.Property(e => e.MedicaoVencimento).HasColumnType("datetime");

                entity.HasOne(d => d.Funcionario)
                    .WithMany(p => p.Medicao)
                    .HasForeignKey(d => d.FuncionarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IMEDICAO1");

                entity.HasOne(d => d.Condominio)
                    .WithMany(p => p.Medicao)
                    .HasForeignKey(d => new { d.CondominioId, d.CondominioAbastecimentoId })
                    .HasConstraintName("IMEDICAO3");

                entity.HasOne(d => d.CondominioNavigation)
                    .WithMany(p => p.Medicao)
                    .HasForeignKey(d => new { d.CondominioId, d.CondominioTorresId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IMEDICAO2");
            });

            modelBuilder.Entity<MedicaoItem>(entity =>
            {
                entity.HasKey(e => new { e.MedicaoId, e.UnidadeId })
                    .HasName("PK__MedicaoI__AAF4BB3D55007DB3");

                entity.HasIndex(e => e.ContaPgtoPor)
                    .HasName("IMEDICAOITEM");

                entity.HasIndex(e => e.UnidadeId)
                    .HasName("IMEDICAOMEDICAOITEM1");

                entity.Property(e => e.ContaDataOcorrencia).HasColumnType("datetime");

                entity.Property(e => e.ContaPgtoEm).HasColumnType("datetime");

                entity.Property(e => e.ContaPgtoPor).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ContaStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MedicaoItemMsgBoleto)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MedicaoItemObs)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MedicaoItemRetorno)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.MedicaoItemTotalAgua).HasColumnType("decimal(15, 6)");

                entity.Property(e => e.MedicaoItemTotalGas).HasColumnType("decimal(15, 6)");

                entity.HasOne(d => d.ContaPgtoPorNavigation)
                    .WithMany(p => p.MedicaoItem)
                    .HasForeignKey(d => d.ContaPgtoPor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IMEDICAOITEM");

                entity.HasOne(d => d.Medicao)
                    .WithMany(p => p.MedicaoItem)
                    .HasForeignKey(d => d.MedicaoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IMEDICAOMEDICAOITEM2");

                entity.HasOne(d => d.Unidade)
                    .WithMany(p => p.MedicaoItem)
                    .HasForeignKey(d => d.UnidadeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IMEDICAOMEDICAOITEM1");
            });

            modelBuilder.Entity<MedicaoItemGasometro>(entity =>
            {
                entity.HasKey(e => new { e.MedicaoId, e.UnidadeId, e.GasometroId })
                    .HasName("PK__MedicaoI__EA52B41D628AC2AB");

                entity.HasIndex(e => new { e.UnidadeId, e.GasometroId })
                    .HasName("IMEDICAOITEMGASOMETRO1");

                entity.Property(e => e.MedicaoItemGasGasometro).HasColumnType("smallmoney");

                entity.HasOne(d => d.MedicaoItem)
                    .WithMany(p => p.MedicaoItemGasometro)
                    .HasForeignKey(d => new { d.MedicaoId, d.UnidadeId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IMEDICAOITEMGASOMETRO2");

                entity.HasOne(d => d.UnidadeGasometro)
                    .WithMany(p => p.MedicaoItemGasometro)
                    .HasForeignKey(d => new { d.UnidadeId, d.GasometroId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IMEDICAOITEMGASOMETRO1");
            });

            modelBuilder.Entity<MedicaoItemHidrometro>(entity =>
            {
                entity.HasKey(e => new { e.MedicaoId, e.UnidadeId, e.HidrometroId })
                    .HasName("PK__MedicaoI__B17F7434E80B9AB9");

                entity.HasIndex(e => new { e.UnidadeId, e.HidrometroId })
                    .HasName("IMEDICAOITEMHIDROMETRO1");

                entity.Property(e => e.MedicaoItemAguaHidrometro).HasColumnType("smallmoney");

                entity.HasOne(d => d.MedicaoItem)
                    .WithMany(p => p.MedicaoItemHidrometro)
                    .HasForeignKey(d => new { d.MedicaoId, d.UnidadeId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IMEDICAOITEMHIDROMETRO2");

                entity.HasOne(d => d.UnidadeHidrometro)
                    .WithMany(p => p.MedicaoItemHidrometro)
                    .HasForeignKey(d => new { d.UnidadeId, d.HidrometroId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IMEDICAOITEMHIDROMETRO1");
            });

            modelBuilder.Entity<MedicaoPrecoAgua>(entity =>
            {
                entity.HasKey(e => new { e.MedicaoId, e.MedicaoPrecoAguaId })
                    .HasName("PK__MedicaoP__262D37E1C626B19B");

                entity.Property(e => e.MedicaoPrecoAguaQtd).HasColumnType("smallmoney");

                entity.Property(e => e.MedicaoPrecoAguaValor).HasColumnType("decimal(15, 6)");

                entity.HasOne(d => d.Medicao)
                    .WithMany(p => p.MedicaoPrecoAgua)
                    .HasForeignKey(d => d.MedicaoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IMEDICAOPRECOAGUA1");
            });

            modelBuilder.Entity<MedicaoPrecoGas>(entity =>
            {
                entity.HasKey(e => new { e.MedicaoId, e.MedicaoPrecoGasId })
                    .HasName("PK__MedicaoP__2CBFEC45C7B9A606");

                entity.Property(e => e.MedicaoPrecoGasQtd).HasColumnType("smallmoney");

                entity.Property(e => e.MedicaoPrecoGasValor).HasColumnType("decimal(15, 6)");

                entity.HasOne(d => d.Medicao)
                    .WithMany(p => p.MedicaoPrecoGas)
                    .HasForeignKey(d => d.MedicaoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IMEDICAOPRECOGAS1");
            });

            modelBuilder.Entity<Modulo>(entity =>
            {
                entity.Property(e => e.ModuloDsc)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModuloImg).IsRequired();

                entity.Property(e => e.ModuloImgNome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModuloImgTipo)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Noticia>(entity =>
            {
                entity.Property(e => e.NoticiaData).HasColumnType("datetime");

                entity.Property(e => e.NoticiaDsc)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NoticiaImgNome)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NoticiaImgTipo)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NoticiaResumo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NoticiaTexto).IsUnicode(false);
            });

            modelBuilder.Entity<Notificacao>(entity =>
            {
                entity.HasIndex(e => e.CondominioId)
                    .HasName("INOTIFICACAO1");

                entity.Property(e => e.NotificacaoAssunto)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NotificacaoCorpo)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.NotificacaoDataElaboracao).HasColumnType("datetime");

                entity.Property(e => e.NotificacaoDataProtocolo).HasColumnType("datetime");

                entity.HasOne(d => d.Condominio)
                    .WithMany(p => p.Notificacao)
                    .HasForeignKey(d => d.CondominioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("INOTIFICACAO1");
            });

            modelBuilder.Entity<Objeto>(entity =>
            {
                entity.HasIndex(e => e.ModuloId)
                    .HasName("IOBJETO1");

                entity.HasIndex(e => e.ObjetoNome)
                    .HasName("UOBJETONOME")
                    .IsUnique();

                entity.HasIndex(e => e.ObjetoPaiId)
                    .HasName("IOBJETO2");

                entity.Property(e => e.ObjetoDsc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ObjetoNome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Modulo)
                    .WithMany(p => p.Objeto)
                    .HasForeignKey(d => d.ModuloId)
                    .HasConstraintName("IOBJETO1");

                entity.HasOne(d => d.ObjetoPai)
                    .WithMany(p => p.InverseObjetoPai)
                    .HasForeignKey(d => d.ObjetoPaiId)
                    .HasConstraintName("IOBJETO2");
            });

            modelBuilder.Entity<ObjetoAcao>(entity =>
            {
                entity.HasKey(e => new { e.ObjetoId, e.AcaoId })
                    .HasName("PK__ObjetoAc__CC6242DB99CADCF0");

                entity.HasIndex(e => e.AcaoId)
                    .HasName("IOBJETOACAO1");

                entity.HasOne(d => d.Acao)
                    .WithMany(p => p.ObjetoAcao)
                    .HasForeignKey(d => d.AcaoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IOBJETOACAO1");

                entity.HasOne(d => d.Objeto)
                    .WithMany(p => p.ObjetoAcao)
                    .HasForeignKey(d => d.ObjetoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IOBJETOACAO2");
            });

            modelBuilder.Entity<Pais>(entity =>
            {
                entity.Property(e => e.PaisDsc)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ParSis>(entity =>
            {
                entity.Property(e => e.ParSisBoletoFraseGeral)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ParSisConsumoExageradoAgua).HasColumnType("smallmoney");

                entity.Property(e => e.ParSisConsumoExageradoGas).HasColumnType("smallmoney");

                entity.Property(e => e.ParSisConsumoInsignificanteAgu).HasColumnType("smallmoney");

                entity.Property(e => e.ParSisConsumoInsignificanteGas).HasColumnType("smallmoney");

                entity.Property(e => e.ParSisDataFim).HasColumnType("datetime");

                entity.Property(e => e.ParSisDataIni).HasColumnType("datetime");

                entity.Property(e => e.ParSisEmpCnpj)
                    .IsRequired()
                    .HasColumnName("ParSisEmpCNPJ")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ParSisEmpEmail)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ParSisEmpEnd1)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ParSisEmpEnd2)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ParSisEmpEnd3)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ParSisEmpFone).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.ParSisEmpNome)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ParSisEmpSite)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ParSisUsuarioTermoUtilizacao)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Patrimonio>(entity =>
            {
                entity.Property(e => e.PatrimonioDataAquisicao).HasColumnType("datetime");

                entity.Property(e => e.PatrimonioDsc)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PatrimonioEstadoConservacao)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PatrimonioUnidadeMedida)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PatrimonioValorUnitario).HasColumnType("money");
            });

            modelBuilder.Entity<Perfil>(entity =>
            {
                entity.Property(e => e.PerfilDsc)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PerfilTipoUnidades)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PerfilMenu>(entity =>
            {
                entity.HasKey(e => new { e.PerfilId, e.ModuloId })
                    .HasName("PK__PerfilMe__EE6CB0887BC695E5");

                entity.HasIndex(e => e.ModuloId)
                    .HasName("IPERFILMENU1");

                entity.Property(e => e.PerfilMenu1)
                    .IsRequired()
                    .HasColumnName("PerfilMenu")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.HasOne(d => d.Modulo)
                    .WithMany(p => p.PerfilMenu)
                    .HasForeignKey(d => d.ModuloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IPERFILMENU1");

                entity.HasOne(d => d.Perfil)
                    .WithMany(p => p.PerfilMenu)
                    .HasForeignKey(d => d.PerfilId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IPERFILMENU2");
            });

            modelBuilder.Entity<PerfilObjeto>(entity =>
            {
                entity.HasKey(e => new { e.PerfilId, e.ObjetoId })
                    .HasName("PK__PerfilOb__8CFB23DDC892729C");

                entity.HasIndex(e => e.ObjetoId)
                    .HasName("IPERFILOBJETO");

                entity.Property(e => e.PerfilAcessoDel).HasColumnName("PerfilAcessoDEL");

                entity.Property(e => e.PerfilAcessoImp).HasColumnName("PerfilAcessoIMP");

                entity.Property(e => e.PerfilAcessoIns).HasColumnName("PerfilAcessoINS");

                entity.Property(e => e.PerfilAcessoUpd).HasColumnName("PerfilAcessoUPD");

                entity.HasOne(d => d.Objeto)
                    .WithMany(p => p.PerfilObjeto)
                    .HasForeignKey(d => d.ObjetoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IPERFILOBJETO");

                entity.HasOne(d => d.Perfil)
                    .WithMany(p => p.PerfilObjeto)
                    .HasForeignKey(d => d.PerfilId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IPERFILPERFILOBJETO1");
            });

            modelBuilder.Entity<PerfilObjetoAcoes>(entity =>
            {
                entity.HasKey(e => new { e.PerfilId, e.ObjetoId, e.AcaoId })
                    .HasName("PK__PerfilOb__A0C67F2B1E7E8C16");

                entity.HasIndex(e => new { e.ObjetoId, e.AcaoId })
                    .HasName("IPERFILOBJETOACOES1");

                entity.HasOne(d => d.ObjetoAcao)
                    .WithMany(p => p.PerfilObjetoAcoes)
                    .HasForeignKey(d => new { d.ObjetoId, d.AcaoId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IPERFILOBJETOACOES1");

                entity.HasOne(d => d.PerfilObjeto)
                    .WithMany(p => p.PerfilObjetoAcoes)
                    .HasForeignKey(d => new { d.PerfilId, d.ObjetoId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IPERFILOBJETOACOES2");
            });

            modelBuilder.Entity<PerfilUnidades>(entity =>
            {
                entity.HasKey(e => new { e.PerfilId, e.UnidadeId })
                    .HasName("PK__PerfilUn__8AEE09BDFDDBA307");

                entity.HasIndex(e => e.UnidadeId)
                    .HasName("IPERFILPERFILUNIDADES1");

                entity.HasOne(d => d.Perfil)
                    .WithMany(p => p.PerfilUnidades)
                    .HasForeignKey(d => d.PerfilId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IPERFILPERFILUNIDADES2");

                entity.HasOne(d => d.Unidade)
                    .WithMany(p => p.PerfilUnidades)
                    .HasForeignKey(d => d.UnidadeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IPERFILPERFILUNIDADES1");
            });

            modelBuilder.Entity<Pessoa>(entity =>
            {
                entity.HasIndex(e => e.BairroId)
                    .HasName("IPESSOA1");

                entity.Property(e => e.PessoaId)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PessoaAltEm).HasColumnType("datetime");

                entity.Property(e => e.PessoaEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PessoaEnderecoNum)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PessoaEnderecoRua)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PessoaFoneCel).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.PessoaFoneCom).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.PessoaFoneRes).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.PessoaIncEm).HasColumnType("datetime");

                entity.Property(e => e.PessoaNome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PessoaSexo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.Bairro)
                    .WithMany(p => p.Pessoa)
                    .HasForeignKey(d => d.BairroId)
                    .HasConstraintName("IPESSOA1");
            });

            modelBuilder.Entity<PessoaDependente>(entity =>
            {
                entity.HasKey(e => new { e.PessoaId, e.DependenteId })
                    .HasName("PK__PessoaDe__7B4883DB22461C35");

                entity.Property(e => e.PessoaId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DependenteSexo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.Pessoa)
                    .WithMany(p => p.PessoaDependente)
                    .HasForeignKey(d => d.PessoaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IPESSOADEPENDENTE1");
            });

            modelBuilder.Entity<QuestSocial>(entity =>
            {
                entity.Property(e => e.QuestSocialDsc)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.QuestSocialOutrosDsc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.QuestSocialQtdUnidade)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.QuestSocialTipoResposta)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<QuestSocialAlternativa>(entity =>
            {
                entity.HasKey(e => new { e.QuestSocialId, e.QuestSocialAlternativaId })
                    .HasName("PK__QuestSoc__BB53C7B76F626EB8");

                entity.Property(e => e.QuestSocialAlternativaDsc)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.QuestSocial)
                    .WithMany(p => p.QuestSocialAlternativa)
                    .HasForeignKey(d => d.QuestSocialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IQUESTSOCIALQUESTSOCIALALTERN1");
            });

            modelBuilder.Entity<QuestSocialCondominio>(entity =>
            {
                entity.HasKey(e => new { e.CondominioId, e.QuestSocialId })
                    .HasName("PK__QuestSoc__840477BDEBE185D1");

                entity.HasIndex(e => e.QuestSocialId)
                    .HasName("IQUESTSOCIALCONDOMINIO1");

                entity.HasOne(d => d.Condominio)
                    .WithMany(p => p.QuestSocialCondominio)
                    .HasForeignKey(d => d.CondominioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IQUESTSOCIALCONDOMINIO2");

                entity.HasOne(d => d.QuestSocial)
                    .WithMany(p => p.QuestSocialCondominio)
                    .HasForeignKey(d => d.QuestSocialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IQUESTSOCIALCONDOMINIO1");
            });

            modelBuilder.Entity<QuestSocialPessoa>(entity =>
            {
                entity.HasKey(e => new { e.PessoaId, e.QuestSocialId })
                    .HasName("PK__QuestSoc__0CEBDC19FF04A72D");

                entity.HasIndex(e => new { e.QuestSocialId, e.QuestSocialAlternativaId })
                    .HasName("IQUESTSOCIALPESSOA1");

                entity.Property(e => e.PessoaId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.QuestSocialPessoaData).HasColumnType("datetime");

                entity.Property(e => e.QuestSocialPessoaRespostaDsc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Pessoa)
                    .WithMany(p => p.QuestSocialPessoa)
                    .HasForeignKey(d => d.PessoaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IQUESTSOCIALPESSOA2");

                entity.HasOne(d => d.QuestSocial)
                    .WithMany(p => p.QuestSocialPessoa)
                    .HasForeignKey(d => d.QuestSocialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("GX_001H006V");

                entity.HasOne(d => d.QuestSocialNavigation)
                    .WithMany(p => p.QuestSocialPessoa)
                    .HasForeignKey(d => new { d.QuestSocialId, d.QuestSocialAlternativaId })
                    .HasConstraintName("IQUESTSOCIALPESSOA1");
            });

            modelBuilder.Entity<Unidade>(entity =>
            {
                entity.HasIndex(e => e.ClienteId)
                    .HasName("IUNIDADE4");

                entity.HasIndex(e => new { e.CondominioId, e.CondominioTorresId })
                    .HasName("IUNIDADE1");

                entity.Property(e => e.ClienteId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.UnidadeDsc)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UnidadeIdExport)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.Unidade)
                    .HasForeignKey(d => d.ClienteId)
                    .HasConstraintName("IUNIDADE4");

                entity.HasOne(d => d.Condominio)
                    .WithMany(p => p.Unidade)
                    .HasForeignKey(d => new { d.CondominioId, d.CondominioTorresId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IUNIDADE1");
            });

            modelBuilder.Entity<UnidadeGasometro>(entity =>
            {
                entity.HasKey(e => new { e.UnidadeId, e.GasometroId })
                    .HasName("PK__UnidadeG__6485D9BDD13B1A71");

                entity.Property(e => e.GasometroDevice)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GasometroMeasurer)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GasometroStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GasometroValorInicial).HasColumnType("smallmoney");

                entity.HasOne(d => d.Unidade)
                    .WithMany(p => p.UnidadeGasometro)
                    .HasForeignKey(d => d.UnidadeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IUNIDADEGASOMETRO2");
            });

            modelBuilder.Entity<UnidadeHidrometro>(entity =>
            {
                entity.HasKey(e => new { e.UnidadeId, e.HidrometroId })
                    .HasName("PK__UnidadeH__D659DB28A62077AA");

                entity.Property(e => e.HidrometroDevice)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HidrometroMeasurer)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HidrometroStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HidrometroValorInicial).HasColumnType("smallmoney");

                entity.HasOne(d => d.Unidade)
                    .WithMany(p => p.UnidadeHidrometro)
                    .HasForeignKey(d => d.UnidadeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IUNIDADEHIDROMETRO1");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasIndex(e => e.PerfilId)
                    .HasName("IUSUARIO2");

                entity.HasIndex(e => e.UsuarioLogin)
                    .HasName("UUSUARIOLOGIN")
                    .IsUnique();

                entity.Property(e => e.UsuarioId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.UsuarioAltEm).HasColumnType("datetime");

                entity.Property(e => e.UsuarioChave)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCodAtivacao)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioIncEm).HasColumnType("datetime");

                entity.Property(e => e.UsuarioLogin)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioSenha)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.HasOne(d => d.Perfil)
                    .WithMany(p => p.Usuario)
                    .HasForeignKey(d => d.PerfilId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IUSUARIO2");

                entity.HasOne(d => d.UsuarioNavigation)
                    .WithOne(p => p.Usuario)
                    .HasForeignKey<Usuario>(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IUSUARIO");
            });

            
        }


    }
}
