using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IndividualizeWebAPI.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Acao",
                columns: table => new
                {
                    AcaoId = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcaoDsc = table.Column<string>(unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acao", x => x.AcaoId);
                });

            migrationBuilder.CreateTable(
                name: "Funcao",
                columns: table => new
                {
                    FuncaoId = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FuncaoDsc = table.Column<string>(unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcao", x => x.FuncaoId);
                });

            migrationBuilder.CreateTable(
                name: "measurings",
                columns: table => new
                {
                    code = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    device = table.Column<string>(unicode: false, fixedLength: true, maxLength: 20, nullable: false),
                    measurer = table.Column<string>(unicode: false, fixedLength: true, maxLength: 20, nullable: false),
                    date = table.Column<DateTime>(type: "datetime", nullable: false),
                    medium = table.Column<short>(nullable: false),
                    measuring = table.Column<int>(nullable: false),
                    measuring_type = table.Column<short>(nullable: false),
                    battery_lifetime = table.Column<short>(nullable: false),
                    alarm = table.Column<string>(unicode: false, fixedLength: true, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__measurin__357D4CF84611C6D9", x => x.code);
                });

            migrationBuilder.CreateTable(
                name: "Modulo",
                columns: table => new
                {
                    ModuloId = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModuloDsc = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    ModuloImg = table.Column<byte[]>(nullable: false),
                    ModuloImgTipo = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    ModuloImgNome = table.Column<string>(unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modulo", x => x.ModuloId);
                });

            migrationBuilder.CreateTable(
                name: "Noticia",
                columns: table => new
                {
                    NoticiaId = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoticiaDsc = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    NoticiaResumo = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    NoticiaTexto = table.Column<string>(unicode: false, nullable: true),
                    NoticiaImg = table.Column<byte[]>(nullable: true),
                    NoticiaData = table.Column<DateTime>(type: "datetime", nullable: false),
                    NoticiaImgNome = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    NoticiaImgTipo = table.Column<string>(unicode: false, fixedLength: true, maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Noticia", x => x.NoticiaId);
                });

            migrationBuilder.CreateTable(
                name: "Pais",
                columns: table => new
                {
                    PaisId = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaisDsc = table.Column<string>(unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pais", x => x.PaisId);
                });

            migrationBuilder.CreateTable(
                name: "ParSis",
                columns: table => new
                {
                    ParSisId = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParSisDataIni = table.Column<DateTime>(type: "datetime", nullable: false),
                    ParSisDataFim = table.Column<DateTime>(type: "datetime", nullable: true),
                    ParSisConsumoInsignificanteAgu = table.Column<decimal>(type: "smallmoney", nullable: false),
                    ParSisConsumoInsignificanteGas = table.Column<decimal>(type: "smallmoney", nullable: false),
                    ParSisConsumoExageradoAgua = table.Column<decimal>(type: "smallmoney", nullable: false),
                    ParSisConsumoExageradoGas = table.Column<decimal>(type: "smallmoney", nullable: false),
                    ParSisBoletoFraseGeral = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    ParSisBoletoQtdHistoricoGrafic = table.Column<short>(nullable: false),
                    ParSisBoletoQtdDiasVencimento = table.Column<short>(nullable: false),
                    ParSisUsuarioDefSenhaSize = table.Column<short>(nullable: false),
                    ParSisUsuarioDefSenhaTipoStr = table.Column<short>(nullable: false),
                    ParSisUsuarioDefSenhaTipoCap = table.Column<short>(nullable: false),
                    ParSisUsuarioTermoUtilizacao = table.Column<string>(unicode: false, nullable: false),
                    ParSisEmpFone = table.Column<decimal>(type: "decimal(10, 0)", nullable: true),
                    ParSisEmpEnd1 = table.Column<string>(unicode: false, maxLength: 80, nullable: true),
                    ParSisEmpEnd2 = table.Column<string>(unicode: false, maxLength: 80, nullable: true),
                    ParSisEmpEnd3 = table.Column<string>(unicode: false, maxLength: 80, nullable: true),
                    ParSisEmpEmail = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    ParSisEmpSite = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    ParSisEmpNome = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    ParSisEmpCNPJ = table.Column<string>(unicode: false, fixedLength: true, maxLength: 14, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParSis", x => x.ParSisId);
                });

            migrationBuilder.CreateTable(
                name: "Patrimonio",
                columns: table => new
                {
                    PatrimonioId = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatrimonioNum = table.Column<short>(nullable: false),
                    PatrimonioDsc = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    PatrimonioDataAquisicao = table.Column<DateTime>(type: "datetime", nullable: false),
                    PatrimonioEstadoConservacao = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    PatrimonioQtd = table.Column<short>(nullable: false),
                    PatrimonioUnidadeMedida = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    PatrimonioValorUnitario = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patrimonio", x => x.PatrimonioId);
                });

            migrationBuilder.CreateTable(
                name: "Perfil",
                columns: table => new
                {
                    PerfilId = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PerfilDsc = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    PerfilTipoUnidades = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perfil", x => x.PerfilId);
                });

            migrationBuilder.CreateTable(
                name: "QuestSocial",
                columns: table => new
                {
                    QuestSocialId = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestSocialDsc = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    QuestSocialTipoResposta = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    QuestSocialUltAlternativaId = table.Column<short>(nullable: false),
                    QuestSocialOutrosFlag = table.Column<bool>(nullable: false),
                    QuestSocialOutrosDsc = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    QuestSocialQtdUnidade = table.Column<string>(unicode: false, maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestSocial", x => x.QuestSocialId);
                });

            migrationBuilder.CreateTable(
                name: "Objeto",
                columns: table => new
                {
                    ObjetoId = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ObjetoNome = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    ObjetoDsc = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    ObjetoPaiId = table.Column<short>(nullable: true),
                    ModuloId = table.Column<short>(nullable: true),
                    ObjetoMenuLink = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Objeto", x => x.ObjetoId);
                    table.ForeignKey(
                        name: "IOBJETO1",
                        column: x => x.ModuloId,
                        principalTable: "Modulo",
                        principalColumn: "ModuloId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "IOBJETO2",
                        column: x => x.ObjetoPaiId,
                        principalTable: "Objeto",
                        principalColumn: "ObjetoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Estado",
                columns: table => new
                {
                    EstadoId = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstadoDsc = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    PaisId = table.Column<short>(nullable: false),
                    EstadoSigla = table.Column<string>(unicode: false, fixedLength: true, maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estado", x => x.EstadoId);
                    table.ForeignKey(
                        name: "IESTADO1",
                        column: x => x.PaisId,
                        principalTable: "Pais",
                        principalColumn: "PaisId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PerfilMenu",
                columns: table => new
                {
                    PerfilId = table.Column<short>(nullable: false),
                    ModuloId = table.Column<short>(nullable: false),
                    PerfilMenu = table.Column<string>(unicode: false, maxLength: 4000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PerfilMe__EE6CB0887BC695E5", x => new { x.PerfilId, x.ModuloId });
                    table.ForeignKey(
                        name: "IPERFILMENU1",
                        column: x => x.ModuloId,
                        principalTable: "Modulo",
                        principalColumn: "ModuloId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "IPERFILMENU2",
                        column: x => x.PerfilId,
                        principalTable: "Perfil",
                        principalColumn: "PerfilId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QuestSocialAlternativa",
                columns: table => new
                {
                    QuestSocialId = table.Column<short>(nullable: false),
                    QuestSocialAlternativaId = table.Column<short>(nullable: false),
                    QuestSocialAlternativaDsc = table.Column<string>(unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__QuestSoc__BB53C7B76F626EB8", x => new { x.QuestSocialId, x.QuestSocialAlternativaId });
                    table.ForeignKey(
                        name: "IQUESTSOCIALQUESTSOCIALALTERN1",
                        column: x => x.QuestSocialId,
                        principalTable: "QuestSocial",
                        principalColumn: "QuestSocialId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ObjetoAcao",
                columns: table => new
                {
                    ObjetoId = table.Column<short>(nullable: false),
                    AcaoId = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ObjetoAc__CC6242DB99CADCF0", x => new { x.ObjetoId, x.AcaoId });
                    table.ForeignKey(
                        name: "IOBJETOACAO1",
                        column: x => x.AcaoId,
                        principalTable: "Acao",
                        principalColumn: "AcaoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "IOBJETOACAO2",
                        column: x => x.ObjetoId,
                        principalTable: "Objeto",
                        principalColumn: "ObjetoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PerfilObjeto",
                columns: table => new
                {
                    PerfilId = table.Column<short>(nullable: false),
                    ObjetoId = table.Column<short>(nullable: false),
                    PerfilAcessoINS = table.Column<bool>(nullable: false),
                    PerfilAcessoUPD = table.Column<bool>(nullable: false),
                    PerfilAcessoDEL = table.Column<bool>(nullable: false),
                    PerfilAcessoIMP = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PerfilOb__8CFB23DDC892729C", x => new { x.PerfilId, x.ObjetoId });
                    table.ForeignKey(
                        name: "IPERFILOBJETO",
                        column: x => x.ObjetoId,
                        principalTable: "Objeto",
                        principalColumn: "ObjetoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "IPERFILPERFILOBJETO1",
                        column: x => x.PerfilId,
                        principalTable: "Perfil",
                        principalColumn: "PerfilId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cidade",
                columns: table => new
                {
                    CidadeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CidadeDsc = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    EstadoId = table.Column<short>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidade", x => x.CidadeId);
                    table.ForeignKey(
                        name: "ICIDADE1",
                        column: x => x.EstadoId,
                        principalTable: "Estado",
                        principalColumn: "EstadoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PerfilObjetoAcoes",
                columns: table => new
                {
                    PerfilId = table.Column<short>(nullable: false),
                    ObjetoId = table.Column<short>(nullable: false),
                    AcaoId = table.Column<short>(nullable: false),
                    PerfilAcessoAcao = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PerfilOb__A0C67F2B1E7E8C16", x => new { x.PerfilId, x.ObjetoId, x.AcaoId });
                    table.ForeignKey(
                        name: "IPERFILOBJETOACOES1",
                        columns: x => new { x.ObjetoId, x.AcaoId },
                        principalTable: "ObjetoAcao",
                        principalColumns: new[] { "ObjetoId", "AcaoId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "IPERFILOBJETOACOES2",
                        columns: x => new { x.PerfilId, x.ObjetoId },
                        principalTable: "PerfilObjeto",
                        principalColumns: new[] { "PerfilId", "ObjetoId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Bairro",
                columns: table => new
                {
                    BairroId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BairroDsc = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    CidadeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bairro", x => x.BairroId);
                    table.ForeignKey(
                        name: "IBAIRRO1",
                        column: x => x.CidadeId,
                        principalTable: "Cidade",
                        principalColumn: "CidadeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pessoa",
                columns: table => new
                {
                    PessoaId = table.Column<decimal>(type: "decimal(18, 0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PessoaNome = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    PessoaEnderecoRua = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    PessoaEnderecoNum = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    PessoaEnderecoCep = table.Column<int>(nullable: true),
                    PessoaFoneRes = table.Column<decimal>(type: "decimal(10, 0)", nullable: true),
                    PessoaFoneCel = table.Column<decimal>(type: "decimal(10, 0)", nullable: true),
                    BairroId = table.Column<int>(nullable: true),
                    PessoaFoneCom = table.Column<decimal>(type: "decimal(10, 0)", nullable: true),
                    PessoaEmail = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    PessoaSexo = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    UltimoDependenteId = table.Column<short>(nullable: true),
                    PessoaIncEm = table.Column<DateTime>(type: "datetime", nullable: false),
                    PessoaIncPor = table.Column<short>(nullable: false),
                    PessoaAltEm = table.Column<DateTime>(type: "datetime", nullable: true),
                    PessoaAltPor = table.Column<short>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoa", x => x.PessoaId);
                    table.ForeignKey(
                        name: "IPESSOA1",
                        column: x => x.BairroId,
                        principalTable: "Bairro",
                        principalColumn: "BairroId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    ClienteId = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    ClienteCpf = table.Column<string>(unicode: false, fixedLength: true, maxLength: 11, nullable: true),
                    ClienteIncEm = table.Column<DateTime>(type: "datetime", nullable: false),
                    ClienteIncPor = table.Column<short>(nullable: false),
                    ClienteAltEm = table.Column<DateTime>(type: "datetime", nullable: true),
                    ClienteAltPor = table.Column<short>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.ClienteId);
                    table.ForeignKey(
                        name: "ICLIENTE",
                        column: x => x.ClienteId,
                        principalTable: "Pessoa",
                        principalColumn: "PessoaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Fornecedor",
                columns: table => new
                {
                    FornecedorId = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    FornecedorCNPJ = table.Column<string>(unicode: false, fixedLength: true, maxLength: 14, nullable: true),
                    FornecedorTipo = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedor", x => x.FornecedorId);
                    table.ForeignKey(
                        name: "IFORNECEDOR",
                        column: x => x.FornecedorId,
                        principalTable: "Pessoa",
                        principalColumn: "PessoaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Funcionario",
                columns: table => new
                {
                    FuncionarioId = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    FuncaoId = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionario", x => x.FuncionarioId);
                    table.ForeignKey(
                        name: "IFUNCIONARIO2",
                        column: x => x.FuncaoId,
                        principalTable: "Funcao",
                        principalColumn: "FuncaoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "IFUNCIONARIO",
                        column: x => x.FuncionarioId,
                        principalTable: "Pessoa",
                        principalColumn: "PessoaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PessoaDependente",
                columns: table => new
                {
                    PessoaId = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    DependenteId = table.Column<short>(nullable: false),
                    DependenteSexo = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    DependenteIdade = table.Column<short>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PessoaDe__7B4883DB22461C35", x => new { x.PessoaId, x.DependenteId });
                    table.ForeignKey(
                        name: "IPESSOADEPENDENTE1",
                        column: x => x.PessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "PessoaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QuestSocialPessoa",
                columns: table => new
                {
                    PessoaId = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    QuestSocialId = table.Column<short>(nullable: false),
                    QuestSocialPessoaRespostaDsc = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    QuestSocialAlternativaId = table.Column<short>(nullable: true),
                    QuestSocialPessoaData = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__QuestSoc__0CEBDC19FF04A72D", x => new { x.PessoaId, x.QuestSocialId });
                    table.ForeignKey(
                        name: "IQUESTSOCIALPESSOA2",
                        column: x => x.PessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "PessoaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "GX_001H006V",
                        column: x => x.QuestSocialId,
                        principalTable: "QuestSocial",
                        principalColumn: "QuestSocialId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "IQUESTSOCIALPESSOA1",
                        columns: x => new { x.QuestSocialId, x.QuestSocialAlternativaId },
                        principalTable: "QuestSocialAlternativa",
                        principalColumns: new[] { "QuestSocialId", "QuestSocialAlternativaId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    UsuarioId = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    UsuarioLogin = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    UsuarioSenha = table.Column<string>(unicode: false, maxLength: 64, nullable: false),
                    UsuarioChave = table.Column<string>(unicode: false, maxLength: 64, nullable: false),
                    PerfilId = table.Column<short>(nullable: false),
                    UsuarioCodAtivacao = table.Column<string>(unicode: false, fixedLength: true, maxLength: 10, nullable: false),
                    UsuarioSituacao = table.Column<short>(nullable: false),
                    UsuarioIncEm = table.Column<DateTime>(type: "datetime", nullable: false),
                    UsuarioIncPor = table.Column<short>(nullable: false),
                    UsuarioAltEm = table.Column<DateTime>(type: "datetime", nullable: true),
                    UsuarioAltPor = table.Column<short>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuarioId);
                    table.ForeignKey(
                        name: "IUSUARIO2",
                        column: x => x.PerfilId,
                        principalTable: "Perfil",
                        principalColumn: "PerfilId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "IUSUARIO",
                        column: x => x.UsuarioId,
                        principalTable: "Pessoa",
                        principalColumn: "PessoaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Condominio",
                columns: table => new
                {
                    CondominioId = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CondominioDsc = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    CondominioUltimaTorreId = table.Column<short>(nullable: false),
                    CondominioBairroId = table.Column<int>(nullable: false),
                    PrecoUltimoGasId = table.Column<short>(nullable: false),
                    PrecoUltimoAguaId = table.Column<short>(nullable: false),
                    PrecoTaxaMinimaGas = table.Column<bool>(nullable: false),
                    PrecoTaxaMinimaAgua = table.Column<bool>(nullable: false),
                    PrecoDataFim = table.Column<DateTime>(type: "datetime", nullable: false),
                    PrecoDataIni = table.Column<DateTime>(type: "datetime", nullable: false),
                    CondominioFornecedorGasId = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    CondominioFornecedorAguaId = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    CondominioUltimaAbstId = table.Column<short>(nullable: false),
                    CondominioAreaComumAgua = table.Column<decimal>(type: "decimal(15, 6)", nullable: true),
                    CondominioAreaComumGas = table.Column<decimal>(type: "decimal(15, 6)", nullable: true),
                    CondominioTaxaEsgoto = table.Column<short>(nullable: false),
                    CondominioAreaComumAguaTipo = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    CondominioAreaComumGasTipo = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    CondominioBolMensagemRodape = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    CondominioBolMensagemAgua = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    CondominioIdExport = table.Column<string>(unicode: false, fixedLength: true, maxLength: 4, nullable: true),
                    CondominioUltimaAbstAguaId = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Condominio", x => x.CondominioId);
                    table.ForeignKey(
                        name: "ICONDOMINIO3",
                        column: x => x.CondominioBairroId,
                        principalTable: "Bairro",
                        principalColumn: "BairroId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "ICONDOMINIO1",
                        column: x => x.CondominioFornecedorAguaId,
                        principalTable: "Fornecedor",
                        principalColumn: "FornecedorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "ICONDOMINIO2",
                        column: x => x.CondominioFornecedorGasId,
                        principalTable: "Fornecedor",
                        principalColumn: "FornecedorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LogAcesso",
                columns: table => new
                {
                    LogAcessoId = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    LogAcessoData = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogAcesso", x => x.LogAcessoId);
                    table.ForeignKey(
                        name: "ILOGACESSO1",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AbastecimentoAgua",
                columns: table => new
                {
                    CondominioId = table.Column<short>(nullable: false),
                    AbastecimentoAguaId = table.Column<short>(nullable: false),
                    AbastecimentoAguaData = table.Column<DateTime>(type: "datetime", nullable: false),
                    AbastecimentoAguaQtd = table.Column<decimal>(type: "smallmoney", nullable: false),
                    AbastecimentoAguaValor = table.Column<decimal>(type: "money", nullable: false),
                    FornecedorId = table.Column<decimal>(type: "decimal(18, 0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Abasteci__94184405C7123D22", x => new { x.CondominioId, x.AbastecimentoAguaId });
                    table.ForeignKey(
                        name: "IABASTECIMENTOAGUA2",
                        column: x => x.CondominioId,
                        principalTable: "Condominio",
                        principalColumn: "CondominioId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "IABASTECIMENTOAGUA1",
                        column: x => x.FornecedorId,
                        principalTable: "Fornecedor",
                        principalColumn: "FornecedorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Alerta",
                columns: table => new
                {
                    AlertaId = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlertaTipo = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    AlertaDataOcorrencia = table.Column<DateTime>(type: "datetime", nullable: false),
                    AlertaSituacao = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    AlertaObs = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    AlertaDataResolucao = table.Column<DateTime>(type: "datetime", nullable: true),
                    AlertaProvidenciaTomada = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    FuncionarioId = table.Column<decimal>(type: "decimal(18, 0)", nullable: true),
                    CondominioId = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alerta", x => x.AlertaId);
                    table.ForeignKey(
                        name: "IALERTA1",
                        column: x => x.CondominioId,
                        principalTable: "Condominio",
                        principalColumn: "CondominioId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "IALERTA2",
                        column: x => x.FuncionarioId,
                        principalTable: "Funcionario",
                        principalColumn: "FuncionarioId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CondominioAbastecimento",
                columns: table => new
                {
                    CondominioId = table.Column<short>(nullable: false),
                    CondominioAbastecimentoId = table.Column<short>(nullable: false),
                    CondominioAbastecimentoData = table.Column<DateTime>(type: "datetime", nullable: false),
                    CondominioAbastecimentoQtd = table.Column<decimal>(type: "smallmoney", nullable: false),
                    FornecedorId = table.Column<decimal>(type: "decimal(18, 0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Condomin__4AE220F43D01079E", x => new { x.CondominioId, x.CondominioAbastecimentoId });
                    table.ForeignKey(
                        name: "ICONDOMINIOABASTECIMENTO2",
                        column: x => x.CondominioId,
                        principalTable: "Condominio",
                        principalColumn: "CondominioId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "ICONDOMINIOABASTECIMENTO1",
                        column: x => x.FornecedorId,
                        principalTable: "Fornecedor",
                        principalColumn: "FornecedorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CondominioPrecoAgua",
                columns: table => new
                {
                    CondominioId = table.Column<short>(nullable: false),
                    PrecoAguaId = table.Column<short>(nullable: false),
                    PrecoAguaQtd = table.Column<decimal>(type: "smallmoney", nullable: false),
                    PrecoAguaValor = table.Column<decimal>(type: "decimal(15, 6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Condomin__48358A7890F59999", x => new { x.CondominioId, x.PrecoAguaId });
                    table.ForeignKey(
                        name: "ICONDOMINIOPRECOAGUA1",
                        column: x => x.CondominioId,
                        principalTable: "Condominio",
                        principalColumn: "CondominioId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CondominioPrecoGas",
                columns: table => new
                {
                    CondominioId = table.Column<short>(nullable: false),
                    PrecoGasId = table.Column<short>(nullable: false),
                    PrecoGasQtd = table.Column<decimal>(type: "smallmoney", nullable: false),
                    PrecoGasValor = table.Column<decimal>(type: "decimal(15, 6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Condomin__A9346A4B143527C6", x => new { x.CondominioId, x.PrecoGasId });
                    table.ForeignKey(
                        name: "ICONDOMINIOPRECOGAS1",
                        column: x => x.CondominioId,
                        principalTable: "Condominio",
                        principalColumn: "CondominioId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CondominioTorres",
                columns: table => new
                {
                    CondominioId = table.Column<short>(nullable: false),
                    CondominioTorresId = table.Column<short>(nullable: false),
                    CondominioTorresDsc = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    CondominioTorresIdExport = table.Column<string>(unicode: false, fixedLength: true, maxLength: 4, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Condomin__D0B2223EADEA75E1", x => new { x.CondominioId, x.CondominioTorresId });
                    table.ForeignKey(
                        name: "ICONDOMINIOTORRES1",
                        column: x => x.CondominioId,
                        principalTable: "Condominio",
                        principalColumn: "CondominioId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Notificacao",
                columns: table => new
                {
                    NotificacaoId = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NotificacaoAssunto = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    NotificacaoDataElaboracao = table.Column<DateTime>(type: "datetime", nullable: false),
                    NotificacaoDataProtocolo = table.Column<DateTime>(type: "datetime", nullable: true),
                    NotificacaoCorpo = table.Column<string>(unicode: false, maxLength: 4000, nullable: true),
                    CondominioId = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notificacao", x => x.NotificacaoId);
                    table.ForeignKey(
                        name: "INOTIFICACAO1",
                        column: x => x.CondominioId,
                        principalTable: "Condominio",
                        principalColumn: "CondominioId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QuestSocialCondominio",
                columns: table => new
                {
                    CondominioId = table.Column<short>(nullable: false),
                    QuestSocialId = table.Column<short>(nullable: false),
                    QuestSocialCondominioOrdem = table.Column<short>(nullable: false),
                    QuestSocialCondominioObr = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__QuestSoc__840477BDEBE185D1", x => new { x.CondominioId, x.QuestSocialId });
                    table.ForeignKey(
                        name: "IQUESTSOCIALCONDOMINIO2",
                        column: x => x.CondominioId,
                        principalTable: "Condominio",
                        principalColumn: "CondominioId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "IQUESTSOCIALCONDOMINIO1",
                        column: x => x.QuestSocialId,
                        principalTable: "QuestSocial",
                        principalColumn: "QuestSocialId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Medicao",
                columns: table => new
                {
                    MedicaoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicaoData = table.Column<DateTime>(type: "datetime", nullable: false),
                    CondominioId = table.Column<short>(nullable: false),
                    CondominioTorresId = table.Column<short>(nullable: false),
                    FuncionarioId = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    MedicaoStatus = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    MedicaoPrecoTaxaMinimaAgua = table.Column<bool>(nullable: false),
                    MedicaoPrecoTaxaMinimaGas = table.Column<bool>(nullable: false),
                    MedicaoRegistroGeralAgua = table.Column<decimal>(type: "smallmoney", nullable: false),
                    MedicaoAreaComumGas = table.Column<decimal>(type: "smallmoney", nullable: false),
                    MedicaoTotalAreaComumAgua = table.Column<decimal>(type: "decimal(15, 6)", nullable: false),
                    MedicaoTotalAreaComumGas = table.Column<decimal>(type: "decimal(15, 6)", nullable: false),
                    MedicaoCondominioAreaComumAgua = table.Column<decimal>(type: "decimal(15, 6)", nullable: false),
                    MedicaoCondominioAreaComumGas = table.Column<decimal>(type: "decimal(15, 6)", nullable: false),
                    MedicaoTaxaEsgotoPerc = table.Column<short>(nullable: false),
                    MedicaoVencimento = table.Column<DateTime>(type: "datetime", nullable: false),
                    MedicaoDensidadeTipo = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    MedicaoDensidadeInformada = table.Column<decimal>(type: "decimal(11, 5)", nullable: false),
                    CondominioAbastecimentoId = table.Column<short>(nullable: true),
                    MedicaoPrecoAguaTaxaMinima = table.Column<bool>(nullable: false),
                    MedicaoPrecoGasTaxaMinima = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicao", x => x.MedicaoId);
                    table.ForeignKey(
                        name: "IMEDICAO1",
                        column: x => x.FuncionarioId,
                        principalTable: "Funcionario",
                        principalColumn: "FuncionarioId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "IMEDICAO3",
                        columns: x => new { x.CondominioId, x.CondominioAbastecimentoId },
                        principalTable: "CondominioAbastecimento",
                        principalColumns: new[] { "CondominioId", "CondominioAbastecimentoId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "IMEDICAO2",
                        columns: x => new { x.CondominioId, x.CondominioTorresId },
                        principalTable: "CondominioTorres",
                        principalColumns: new[] { "CondominioId", "CondominioTorresId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Unidade",
                columns: table => new
                {
                    UnidadeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnidadeDsc = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    CondominioTorresId = table.Column<short>(nullable: false),
                    CondominioId = table.Column<short>(nullable: false),
                    ClienteId = table.Column<decimal>(type: "decimal(18, 0)", nullable: true),
                    UnidadeUltimoHidrometroId = table.Column<int>(nullable: false),
                    UnidadeUltimoGasometroId = table.Column<int>(nullable: false),
                    UnidadeIdExport = table.Column<string>(unicode: false, fixedLength: true, maxLength: 6, nullable: true),
                    UnidadeInformativoDigital = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unidade", x => x.UnidadeId);
                    table.ForeignKey(
                        name: "IUNIDADE4",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "IUNIDADE1",
                        columns: x => new { x.CondominioId, x.CondominioTorresId },
                        principalTable: "CondominioTorres",
                        principalColumns: new[] { "CondominioId", "CondominioTorresId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MedicaoPrecoAgua",
                columns: table => new
                {
                    MedicaoId = table.Column<int>(nullable: false),
                    MedicaoPrecoAguaId = table.Column<short>(nullable: false),
                    MedicaoPrecoAguaQtd = table.Column<decimal>(type: "smallmoney", nullable: false),
                    MedicaoPrecoAguaValor = table.Column<decimal>(type: "decimal(15, 6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__MedicaoP__262D37E1C626B19B", x => new { x.MedicaoId, x.MedicaoPrecoAguaId });
                    table.ForeignKey(
                        name: "IMEDICAOPRECOAGUA1",
                        column: x => x.MedicaoId,
                        principalTable: "Medicao",
                        principalColumn: "MedicaoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MedicaoPrecoGas",
                columns: table => new
                {
                    MedicaoId = table.Column<int>(nullable: false),
                    MedicaoPrecoGasId = table.Column<short>(nullable: false),
                    MedicaoPrecoGasQtd = table.Column<decimal>(type: "smallmoney", nullable: false),
                    MedicaoPrecoGasValor = table.Column<decimal>(type: "decimal(15, 6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__MedicaoP__2CBFEC45C7B9A606", x => new { x.MedicaoId, x.MedicaoPrecoGasId });
                    table.ForeignKey(
                        name: "IMEDICAOPRECOGAS1",
                        column: x => x.MedicaoId,
                        principalTable: "Medicao",
                        principalColumn: "MedicaoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AgendamentoVistoria",
                columns: table => new
                {
                    AgendamentoVistCod = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgendamentoVistData = table.Column<DateTime>(type: "datetime", nullable: false),
                    AgendamentoVistObs = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    AgendamentoVistContato = table.Column<short>(nullable: false),
                    AgendamentoVistDataResp = table.Column<DateTime>(type: "datetime", nullable: true),
                    AgendamentoVistResposta = table.Column<string>(unicode: false, nullable: true),
                    UnidadeId = table.Column<int>(nullable: false),
                    AgendamentoVistContatoTexto = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    AgendamentoVistProtocolo = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    AgendamentoVistTitulo = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    AlertaId = table.Column<short>(nullable: true),
                    AgendamentoVistSituacao = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Agendame__5553F15D7884B149", x => x.AgendamentoVistCod);
                    table.ForeignKey(
                        name: "IAGENDAMENTOVISTORIA2",
                        column: x => x.AlertaId,
                        principalTable: "Alerta",
                        principalColumn: "AlertaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "IAGENDAMENTOVISTORIA1",
                        column: x => x.UnidadeId,
                        principalTable: "Unidade",
                        principalColumn: "UnidadeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MedicaoItem",
                columns: table => new
                {
                    MedicaoId = table.Column<int>(nullable: false),
                    UnidadeId = table.Column<int>(nullable: false),
                    MedicaoItemObs = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    MedicaoItemTotalAgua = table.Column<decimal>(type: "decimal(15, 6)", nullable: false),
                    MedicaoItemTotalGas = table.Column<decimal>(type: "decimal(15, 6)", nullable: false),
                    MedicaoItemMsgBoleto = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    ContaStatus = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    ContaDataOcorrencia = table.Column<DateTime>(type: "datetime", nullable: false),
                    ContaPgtoPor = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    ContaPgtoEm = table.Column<DateTime>(type: "datetime", nullable: false),
                    MedicaoItemRetorno = table.Column<string>(unicode: false, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__MedicaoI__AAF4BB3D55007DB3", x => new { x.MedicaoId, x.UnidadeId });
                    table.ForeignKey(
                        name: "IMEDICAOITEM",
                        column: x => x.ContaPgtoPor,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "IMEDICAOMEDICAOITEM2",
                        column: x => x.MedicaoId,
                        principalTable: "Medicao",
                        principalColumn: "MedicaoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "IMEDICAOMEDICAOITEM1",
                        column: x => x.UnidadeId,
                        principalTable: "Unidade",
                        principalColumn: "UnidadeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PerfilUnidades",
                columns: table => new
                {
                    PerfilId = table.Column<short>(nullable: false),
                    UnidadeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PerfilUn__8AEE09BDFDDBA307", x => new { x.PerfilId, x.UnidadeId });
                    table.ForeignKey(
                        name: "IPERFILPERFILUNIDADES2",
                        column: x => x.PerfilId,
                        principalTable: "Perfil",
                        principalColumn: "PerfilId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "IPERFILPERFILUNIDADES1",
                        column: x => x.UnidadeId,
                        principalTable: "Unidade",
                        principalColumn: "UnidadeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UnidadeGasometro",
                columns: table => new
                {
                    UnidadeId = table.Column<int>(nullable: false),
                    GasometroId = table.Column<int>(nullable: false),
                    GasometroMeasurer = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    GasometroDevice = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    GasometroValorInicial = table.Column<decimal>(type: "smallmoney", nullable: true),
                    GasometroStatus = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    GasometroTipoMedicao = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__UnidadeG__6485D9BDD13B1A71", x => new { x.UnidadeId, x.GasometroId });
                    table.ForeignKey(
                        name: "IUNIDADEGASOMETRO2",
                        column: x => x.UnidadeId,
                        principalTable: "Unidade",
                        principalColumn: "UnidadeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UnidadeHidrometro",
                columns: table => new
                {
                    UnidadeId = table.Column<int>(nullable: false),
                    HidrometroId = table.Column<int>(nullable: false),
                    HidrometroMeasurer = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    HidrometroDevice = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    HidrometroValorInicial = table.Column<decimal>(type: "smallmoney", nullable: true),
                    HidrometroStatus = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    HidrometroTipoMedicao = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__UnidadeH__D659DB28A62077AA", x => new { x.UnidadeId, x.HidrometroId });
                    table.ForeignKey(
                        name: "IUNIDADEHIDROMETRO1",
                        column: x => x.UnidadeId,
                        principalTable: "Unidade",
                        principalColumn: "UnidadeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AgendamentoVistoriaTram",
                columns: table => new
                {
                    AgendamentoVistTramCod = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgendamentoVistCod = table.Column<int>(nullable: false),
                    AgendamentoVistTramData = table.Column<DateTime>(type: "datetime", nullable: false),
                    AgendamentoVistTramUsuario = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    AgendamentoVistTramAcao = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    AgendamentoVistTramTexto = table.Column<string>(unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Agendame__FB8CBCC88CF2B08F", x => x.AgendamentoVistTramCod);
                    table.ForeignKey(
                        name: "IAGENDAMENTOVISTORIATRAM1",
                        column: x => x.AgendamentoVistCod,
                        principalTable: "AgendamentoVistoria",
                        principalColumn: "AgendamentoVistCod",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MedicaoItemGasometro",
                columns: table => new
                {
                    MedicaoId = table.Column<int>(nullable: false),
                    UnidadeId = table.Column<int>(nullable: false),
                    GasometroId = table.Column<int>(nullable: false),
                    MedicaoItemGasGasometro = table.Column<decimal>(type: "smallmoney", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__MedicaoI__EA52B41D628AC2AB", x => new { x.MedicaoId, x.UnidadeId, x.GasometroId });
                    table.ForeignKey(
                        name: "IMEDICAOITEMGASOMETRO2",
                        columns: x => new { x.MedicaoId, x.UnidadeId },
                        principalTable: "MedicaoItem",
                        principalColumns: new[] { "MedicaoId", "UnidadeId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "IMEDICAOITEMGASOMETRO1",
                        columns: x => new { x.UnidadeId, x.GasometroId },
                        principalTable: "UnidadeGasometro",
                        principalColumns: new[] { "UnidadeId", "GasometroId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MedicaoItemHidrometro",
                columns: table => new
                {
                    MedicaoId = table.Column<int>(nullable: false),
                    UnidadeId = table.Column<int>(nullable: false),
                    HidrometroId = table.Column<int>(nullable: false),
                    MedicaoItemAguaHidrometro = table.Column<decimal>(type: "smallmoney", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__MedicaoI__B17F7434E80B9AB9", x => new { x.MedicaoId, x.UnidadeId, x.HidrometroId });
                    table.ForeignKey(
                        name: "IMEDICAOITEMHIDROMETRO2",
                        columns: x => new { x.MedicaoId, x.UnidadeId },
                        principalTable: "MedicaoItem",
                        principalColumns: new[] { "MedicaoId", "UnidadeId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "IMEDICAOITEMHIDROMETRO1",
                        columns: x => new { x.UnidadeId, x.HidrometroId },
                        principalTable: "UnidadeHidrometro",
                        principalColumns: new[] { "UnidadeId", "HidrometroId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IABASTECIMENTOAGUA1",
                table: "AbastecimentoAgua",
                column: "FornecedorId");

            migrationBuilder.CreateIndex(
                name: "IAGENDAMENTOVISTORIA2",
                table: "AgendamentoVistoria",
                column: "AlertaId");

            migrationBuilder.CreateIndex(
                name: "IAGENDAMENTOVISTORIA1",
                table: "AgendamentoVistoria",
                column: "UnidadeId");

            migrationBuilder.CreateIndex(
                name: "IAGENDAMENTOVISTORIATRAM1",
                table: "AgendamentoVistoriaTram",
                column: "AgendamentoVistCod");

            migrationBuilder.CreateIndex(
                name: "IALERTA1",
                table: "Alerta",
                column: "CondominioId");

            migrationBuilder.CreateIndex(
                name: "IALERTA2",
                table: "Alerta",
                column: "FuncionarioId");

            migrationBuilder.CreateIndex(
                name: "IBAIRRO1",
                table: "Bairro",
                column: "CidadeId");

            migrationBuilder.CreateIndex(
                name: "ICIDADE1",
                table: "Cidade",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "ICONDOMINIO3",
                table: "Condominio",
                column: "CondominioBairroId");

            migrationBuilder.CreateIndex(
                name: "ICONDOMINIO1",
                table: "Condominio",
                column: "CondominioFornecedorAguaId");

            migrationBuilder.CreateIndex(
                name: "ICONDOMINIO2",
                table: "Condominio",
                column: "CondominioFornecedorGasId");

            migrationBuilder.CreateIndex(
                name: "ICONDOMINIOABASTECIMENTO1",
                table: "CondominioAbastecimento",
                column: "FornecedorId");

            migrationBuilder.CreateIndex(
                name: "UCONDOMINIOPRECOAGUAQTD",
                table: "CondominioPrecoAgua",
                columns: new[] { "CondominioId", "PrecoAguaQtd" });

            migrationBuilder.CreateIndex(
                name: "UCONDOMINIOPRECOGASQTD",
                table: "CondominioPrecoGas",
                columns: new[] { "CondominioId", "PrecoGasQtd" });

            migrationBuilder.CreateIndex(
                name: "IESTADO1",
                table: "Estado",
                column: "PaisId");

            migrationBuilder.CreateIndex(
                name: "IFUNCIONARIO2",
                table: "Funcionario",
                column: "FuncaoId");

            migrationBuilder.CreateIndex(
                name: "ULOGACESSODATA",
                table: "LogAcesso",
                column: "LogAcessoData");

            migrationBuilder.CreateIndex(
                name: "ILOGACESSO1",
                table: "LogAcesso",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IMEDICAO1",
                table: "Medicao",
                column: "FuncionarioId");

            migrationBuilder.CreateIndex(
                name: "UMEDICAODATA",
                table: "Medicao",
                column: "MedicaoData");

            migrationBuilder.CreateIndex(
                name: "IMEDICAO3",
                table: "Medicao",
                columns: new[] { "CondominioId", "CondominioAbastecimentoId" });

            migrationBuilder.CreateIndex(
                name: "IMEDICAO2",
                table: "Medicao",
                columns: new[] { "CondominioId", "CondominioTorresId" });

            migrationBuilder.CreateIndex(
                name: "IMEDICAOITEM",
                table: "MedicaoItem",
                column: "ContaPgtoPor");

            migrationBuilder.CreateIndex(
                name: "IMEDICAOMEDICAOITEM1",
                table: "MedicaoItem",
                column: "UnidadeId");

            migrationBuilder.CreateIndex(
                name: "IMEDICAOITEMGASOMETRO1",
                table: "MedicaoItemGasometro",
                columns: new[] { "UnidadeId", "GasometroId" });

            migrationBuilder.CreateIndex(
                name: "IMEDICAOITEMHIDROMETRO1",
                table: "MedicaoItemHidrometro",
                columns: new[] { "UnidadeId", "HidrometroId" });

            migrationBuilder.CreateIndex(
                name: "INOTIFICACAO1",
                table: "Notificacao",
                column: "CondominioId");

            migrationBuilder.CreateIndex(
                name: "IOBJETO1",
                table: "Objeto",
                column: "ModuloId");

            migrationBuilder.CreateIndex(
                name: "UOBJETONOME",
                table: "Objeto",
                column: "ObjetoNome",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IOBJETO2",
                table: "Objeto",
                column: "ObjetoPaiId");

            migrationBuilder.CreateIndex(
                name: "IOBJETOACAO1",
                table: "ObjetoAcao",
                column: "AcaoId");

            migrationBuilder.CreateIndex(
                name: "IPERFILMENU1",
                table: "PerfilMenu",
                column: "ModuloId");

            migrationBuilder.CreateIndex(
                name: "IPERFILOBJETO",
                table: "PerfilObjeto",
                column: "ObjetoId");

            migrationBuilder.CreateIndex(
                name: "IPERFILOBJETOACOES1",
                table: "PerfilObjetoAcoes",
                columns: new[] { "ObjetoId", "AcaoId" });

            migrationBuilder.CreateIndex(
                name: "IPERFILPERFILUNIDADES1",
                table: "PerfilUnidades",
                column: "UnidadeId");

            migrationBuilder.CreateIndex(
                name: "IPESSOA1",
                table: "Pessoa",
                column: "BairroId");

            migrationBuilder.CreateIndex(
                name: "IQUESTSOCIALCONDOMINIO1",
                table: "QuestSocialCondominio",
                column: "QuestSocialId");

            migrationBuilder.CreateIndex(
                name: "IQUESTSOCIALPESSOA1",
                table: "QuestSocialPessoa",
                columns: new[] { "QuestSocialId", "QuestSocialAlternativaId" });

            migrationBuilder.CreateIndex(
                name: "IUNIDADE4",
                table: "Unidade",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IUNIDADE1",
                table: "Unidade",
                columns: new[] { "CondominioId", "CondominioTorresId" });

            migrationBuilder.CreateIndex(
                name: "IUSUARIO2",
                table: "Usuario",
                column: "PerfilId");

            migrationBuilder.CreateIndex(
                name: "UUSUARIOLOGIN",
                table: "Usuario",
                column: "UsuarioLogin",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AbastecimentoAgua");

            migrationBuilder.DropTable(
                name: "AgendamentoVistoriaTram");

            migrationBuilder.DropTable(
                name: "CondominioPrecoAgua");

            migrationBuilder.DropTable(
                name: "CondominioPrecoGas");

            migrationBuilder.DropTable(
                name: "LogAcesso");

            migrationBuilder.DropTable(
                name: "measurings");

            migrationBuilder.DropTable(
                name: "MedicaoItemGasometro");

            migrationBuilder.DropTable(
                name: "MedicaoItemHidrometro");

            migrationBuilder.DropTable(
                name: "MedicaoPrecoAgua");

            migrationBuilder.DropTable(
                name: "MedicaoPrecoGas");

            migrationBuilder.DropTable(
                name: "Noticia");

            migrationBuilder.DropTable(
                name: "Notificacao");

            migrationBuilder.DropTable(
                name: "ParSis");

            migrationBuilder.DropTable(
                name: "Patrimonio");

            migrationBuilder.DropTable(
                name: "PerfilMenu");

            migrationBuilder.DropTable(
                name: "PerfilObjetoAcoes");

            migrationBuilder.DropTable(
                name: "PerfilUnidades");

            migrationBuilder.DropTable(
                name: "PessoaDependente");

            migrationBuilder.DropTable(
                name: "QuestSocialCondominio");

            migrationBuilder.DropTable(
                name: "QuestSocialPessoa");

            migrationBuilder.DropTable(
                name: "AgendamentoVistoria");

            migrationBuilder.DropTable(
                name: "UnidadeGasometro");

            migrationBuilder.DropTable(
                name: "MedicaoItem");

            migrationBuilder.DropTable(
                name: "UnidadeHidrometro");

            migrationBuilder.DropTable(
                name: "ObjetoAcao");

            migrationBuilder.DropTable(
                name: "PerfilObjeto");

            migrationBuilder.DropTable(
                name: "QuestSocialAlternativa");

            migrationBuilder.DropTable(
                name: "Alerta");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Medicao");

            migrationBuilder.DropTable(
                name: "Unidade");

            migrationBuilder.DropTable(
                name: "Acao");

            migrationBuilder.DropTable(
                name: "Objeto");

            migrationBuilder.DropTable(
                name: "QuestSocial");

            migrationBuilder.DropTable(
                name: "Perfil");

            migrationBuilder.DropTable(
                name: "Funcionario");

            migrationBuilder.DropTable(
                name: "CondominioAbastecimento");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "CondominioTorres");

            migrationBuilder.DropTable(
                name: "Modulo");

            migrationBuilder.DropTable(
                name: "Funcao");

            migrationBuilder.DropTable(
                name: "Condominio");

            migrationBuilder.DropTable(
                name: "Fornecedor");

            migrationBuilder.DropTable(
                name: "Pessoa");

            migrationBuilder.DropTable(
                name: "Bairro");

            migrationBuilder.DropTable(
                name: "Cidade");

            migrationBuilder.DropTable(
                name: "Estado");

            migrationBuilder.DropTable(
                name: "Pais");
        }
    }
}
