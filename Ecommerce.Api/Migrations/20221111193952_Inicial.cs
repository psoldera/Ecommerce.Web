using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce.Api.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carrinhos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PessoaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carrinhos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IconCSS = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pessoas",
                columns: table => new
                {
                    PessoaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Credito = table.Column<double>(type: "float", nullable: true),
                    Salario = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas", x => x.PessoaId);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagemUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produtos_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Emails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnderecoEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PessoaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Emails_Pessoas_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoas",
                        principalColumn: "PessoaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Telefones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroTelefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PessoaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Telefones_Pessoas_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoas",
                        principalColumn: "PessoaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarrinhoItens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarrinhoID = table.Column<int>(type: "int", nullable: false),
                    ProdutoId = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarrinhoItens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarrinhoItens_Carrinhos_CarrinhoID",
                        column: x => x.CarrinhoID,
                        principalTable: "Carrinhos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarrinhoItens_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "Id", "IconCSS", "Nome" },
                values: new object[,]
                {
                    { 1, "fas fa-spa", "Ortopédico" },
                    { 2, "fas fa-spa", "Hospitalar" },
                    { 3, "fas fa-spa", "Fisioterapia" },
                    { 4, "fas fa-spa", "Acessibilidade" }
                });

            migrationBuilder.InsertData(
                table: "Pessoas",
                columns: new[] { "PessoaId", "CPF", "Credito", "Discriminator", "Email", "Nome", "Password", "Status" },
                values: new object[,]
                {
                    { 1, "12345678910", 0.0, "Cliente", "pedro.soldera@hotmail.com", "Pedro Soldera", "manco321", 1 },
                    { 2, "09876543211", 0.0, "Cliente", "gabriel.tozato@hotmail.com", "Gabriel Tozato", "beaba123", 1 }
                });

            migrationBuilder.InsertData(
                table: "Pessoas",
                columns: new[] { "PessoaId", "CPF", "Discriminator", "Email", "Nome", "Password", "Salario", "Status" },
                values: new object[] { 3, "45693287694", "Funcionario", "gabriel.tozato@hotmail.com", "Ana Nicolly", "beaba123", 0.0, 2 });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "CategoriaId", "Descricao", "ImagemUrl", "Nome", "Preco", "Quantidade" },
                values: new object[,]
                {
                    { 1, 1, "Para compressão da articulação do tornozelo no tratamento e prevenção do edema de entorses, tendinites, bursites e artrite reumatóide.", "/Imagens/Ortopedico/Ortopedico1.png", "Tornozeleira Tamanho pequeno", 40m, 100 },
                    { 2, 1, "Produto indicado para descanso e sustentação do membro superior (braço e antebraço) em casos de fraturas, engessamentos, lesões, pós-operatórios e sequelas de AVC.", "/Imagens/Ortopedico/Ortopedico2.png", "Tipoia promocional Tamanho Grande", 14m, 100 },
                    { 3, 1, "Prevenção e tratamento contra tendinite, artrite reumatoide, artrose, lesões ligamentares, síndrome do túnel do corpo, tenossinovite, LER/DORT, prevenção da recidiva na prática de atividades", "/Imagens/Ortopedico/Ortopedico3.png", "Tala para punho lado esquerdo Tamanho pequeno", 34m, 100 },
                    { 4, 1, "A Tala Polegar Ajustável Bilateral NeoSoft proporciona proteção e estabilidade ao punho e ao polegar. A compressão é regulável para maior conforto.", "/Imagens/Ortopedico/Ortopedico4.png", "Tala Polegar Ajustavel", 28m, 100 },
                    { 5, 2, "Termômetro de testa, com capacidade de aferir temperatura tanto de objetos quanto de seres humanos.", "/Imagens/Hospitalar/Hospitalar1.png", "Termômetro Digital Infravermelho", 109m, 100 },
                    { 6, 2, "Termômetro clínico digital Domotherm Incoterm.", "/Imagens/Hospitalar/Hospitalar2.png", "Termometro Clinico Digital", 12m, 100 },
                    { 7, 2, "Desenvolvida para aplicação de medicamentos pela via parenteral e coleta de sangue.", "/Imagens/Hospitalar/Hospitalar3.png", "Seringa descartável 60ml sem agulha", 3m, 100 },
                    { 8, 2, "Termômetro clínico digital Domotherm Incoterm.", "/Imagens/Hospitalar/Hospitalar4.png", "Suporte Coletor De Material Perfurocortante", 27m, 100 },
                    { 9, 3, "BOLA FISIOBALL 75CM CINZA ORTHOPAUHER.", "/Imagens/Fisioterapia/Fisioterapia1.png", "Bola Fisioball 75CM", 124m, 100 },
                    { 10, 3, "Tecnologia, Inovação à Serviço dos Cuidados da sua Saúde! - Equipada com 4 sensores de medição de massa - Plataforma de vidro temperado de 280x260 mm e espessura da 5mm - Acionamento por pressão.", "/Imagens/Fisioterapia/Fisioterapia2.png", "Balança corporal digital", 67m, 100 },
                    { 11, 3, "Confeccionado em poliuretano com formato de esfera. MODO DE USO Segurar com a palma da mão e fazer moviventos de aperto (flexão).", "/Imagens/Fisioterapia/Fisioterapia3.png", "Bolinha Fisioterapia Anti Stress", 5m, 100 },
                    { 12, 3, "Intensifica a produção de potência muscular, ensina o corpo a maneira de absorver força e redirecioná-la.", "/Imagens/Fisioterapia/Fisioterapia4.png", "Halteres Bola Pintado 3kg", 47m, 100 },
                    { 13, 4, "Eliminação de impacto e pressão. Indicada especialmente para atleta, ginastas e esportistas em geral.", "/Imagens/Acessibilidade/Acessibilidade1.png", "Palmilha Sob Gel", 87m, 100 },
                    { 14, 4, "Conforto, alívio das dores, calos, calosidades, elimina o atrito e pressão interdigital e protege os dedos do roce nos calçados. Pode ser recortado no tamanho desejado. Permite utilização de medicação tópica", "/Imagens/Acessibilidade/Acessibilidade2.png", "Tubogel recortável para calos", 21m, 100 },
                    { 15, 4, "onforto para ser utilizado em ambientes de saúde. Capa resistente a água, de fácil higienização. Travesseiro durável. Maior conforto para dormir.", "/Imagens/Acessibilidade/Acessibilidade3.png", "Travesseiro hospitalar", 77m, 100 },
                    { 16, 4, "Espuma com memória para maior conforto e sustentação da cervical.", "/Imagens/Acessibilidade/Acessibilidade4.png", "Suporte super neck pillow grafite", 81m, 100 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarrinhoItens_CarrinhoID",
                table: "CarrinhoItens",
                column: "CarrinhoID");

            migrationBuilder.CreateIndex(
                name: "IX_CarrinhoItens_ProdutoId",
                table: "CarrinhoItens",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Emails_PessoaId",
                table: "Emails",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_CategoriaId",
                table: "Produtos",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Telefones_PessoaId",
                table: "Telefones",
                column: "PessoaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarrinhoItens");

            migrationBuilder.DropTable(
                name: "Emails");

            migrationBuilder.DropTable(
                name: "Telefones");

            migrationBuilder.DropTable(
                name: "Carrinhos");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Pessoas");

            migrationBuilder.DropTable(
                name: "Categorias");
        }
    }
}
