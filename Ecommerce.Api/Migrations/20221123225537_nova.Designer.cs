﻿// <auto-generated />
using Ecommerce.Api.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ecommerce.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221123225537_nova")]
    partial class nova
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Ecommerce.Api.Entities.Carrinho", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("PessoaId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Carrinhos");
                });

            modelBuilder.Entity("Ecommerce.Api.Entities.CarrinhoItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CarrinhoId")
                        .HasColumnType("int");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CarrinhoId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("CarrinhoItens");
                });

            modelBuilder.Entity("Ecommerce.Api.Entities.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("IconCSS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categorias");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IconCSS = "fas fa-spa",
                            Nome = "Ortopédico"
                        },
                        new
                        {
                            Id = 2,
                            IconCSS = "fas fa-spa",
                            Nome = "Hospitalar"
                        },
                        new
                        {
                            Id = 3,
                            IconCSS = "fas fa-spa",
                            Nome = "Fisioterapia"
                        },
                        new
                        {
                            Id = 4,
                            IconCSS = "fas fa-spa",
                            Nome = "Acessibilidade"
                        });
                });

            modelBuilder.Entity("Ecommerce.Api.Entities.Email", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("EnderecoEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PessoaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId");

                    b.ToTable("Emails");
                });

            modelBuilder.Entity("Ecommerce.Api.Entities.Pessoa", b =>
                {
                    b.Property<int>("PessoaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PessoaId"), 1L, 1);

                    b.Property<string>("CPF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("PessoaId");

                    b.ToTable("Pessoas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Pessoa");
                });

            modelBuilder.Entity("Ecommerce.Api.Entities.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagemUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Produtos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoriaId = 1,
                            Descricao = "Para compressão da articulação do tornozelo no tratamento e prevenção do edema de entorses, tendinites, bursites e artrite reumatóide.",
                            ImagemUrl = "/Imagens/Ortopedico/Ortopedico1.png",
                            Nome = "Tornozeleira Tamanho pequeno",
                            Preco = 40m,
                            Quantidade = 100
                        },
                        new
                        {
                            Id = 2,
                            CategoriaId = 1,
                            Descricao = "Produto indicado para descanso e sustentação do membro superior (braço e antebraço) em casos de fraturas, engessamentos, lesões, pós-operatórios e sequelas de AVC.",
                            ImagemUrl = "/Imagens/Ortopedico/Ortopedico2.png",
                            Nome = "Tipoia promocional Tamanho Grande",
                            Preco = 14m,
                            Quantidade = 100
                        },
                        new
                        {
                            Id = 3,
                            CategoriaId = 1,
                            Descricao = "Prevenção e tratamento contra tendinite, artrite reumatoide, artrose, lesões ligamentares, síndrome do túnel do corpo, tenossinovite, LER/DORT, prevenção da recidiva na prática de atividades",
                            ImagemUrl = "/Imagens/Ortopedico/Ortopedico3.png",
                            Nome = "Tala para punho lado esquerdo Tamanho pequeno",
                            Preco = 34m,
                            Quantidade = 100
                        },
                        new
                        {
                            Id = 4,
                            CategoriaId = 1,
                            Descricao = "A Tala Polegar Ajustável Bilateral NeoSoft proporciona proteção e estabilidade ao punho e ao polegar. A compressão é regulável para maior conforto.",
                            ImagemUrl = "/Imagens/Ortopedico/Ortopedico4.png",
                            Nome = "Tala Polegar Ajustavel",
                            Preco = 28m,
                            Quantidade = 100
                        },
                        new
                        {
                            Id = 5,
                            CategoriaId = 2,
                            Descricao = "Termômetro de testa, com capacidade de aferir temperatura tanto de objetos quanto de seres humanos.",
                            ImagemUrl = "/Imagens/Hospitalar/Hospitalar1.png",
                            Nome = "Termômetro Digital Infravermelho",
                            Preco = 109m,
                            Quantidade = 100
                        },
                        new
                        {
                            Id = 6,
                            CategoriaId = 2,
                            Descricao = "Termômetro clínico digital Domotherm Incoterm.",
                            ImagemUrl = "/Imagens/Hospitalar/Hospitalar2.png",
                            Nome = "Termometro Clinico Digital",
                            Preco = 12m,
                            Quantidade = 100
                        },
                        new
                        {
                            Id = 7,
                            CategoriaId = 2,
                            Descricao = "Desenvolvida para aplicação de medicamentos pela via parenteral e coleta de sangue.",
                            ImagemUrl = "/Imagens/Hospitalar/Hospitalar3.png",
                            Nome = "Seringa descartável 60ml sem agulha",
                            Preco = 3m,
                            Quantidade = 100
                        },
                        new
                        {
                            Id = 8,
                            CategoriaId = 2,
                            Descricao = "Termômetro clínico digital Domotherm Incoterm.",
                            ImagemUrl = "/Imagens/Hospitalar/Hospitalar4.png",
                            Nome = "Suporte Coletor De Material Perfurocortante",
                            Preco = 27m,
                            Quantidade = 100
                        },
                        new
                        {
                            Id = 9,
                            CategoriaId = 3,
                            Descricao = "BOLA FISIOBALL 75CM CINZA ORTHOPAUHER.",
                            ImagemUrl = "/Imagens/Fisioterapia/Fisioterapia1.png",
                            Nome = "Bola Fisioball 75CM",
                            Preco = 124m,
                            Quantidade = 100
                        },
                        new
                        {
                            Id = 10,
                            CategoriaId = 3,
                            Descricao = "Tecnologia, Inovação à Serviço dos Cuidados da sua Saúde! - Equipada com 4 sensores de medição de massa - Plataforma de vidro temperado de 280x260 mm e espessura da 5mm - Acionamento por pressão.",
                            ImagemUrl = "/Imagens/Fisioterapia/Fisioterapia2.png",
                            Nome = "Balança corporal digital",
                            Preco = 67m,
                            Quantidade = 100
                        },
                        new
                        {
                            Id = 11,
                            CategoriaId = 3,
                            Descricao = "Confeccionado em poliuretano com formato de esfera. MODO DE USO Segurar com a palma da mão e fazer moviventos de aperto (flexão).",
                            ImagemUrl = "/Imagens/Fisioterapia/Fisioterapia3.png",
                            Nome = "Bolinha Fisioterapia Anti Stress",
                            Preco = 5m,
                            Quantidade = 100
                        },
                        new
                        {
                            Id = 12,
                            CategoriaId = 3,
                            Descricao = "Intensifica a produção de potência muscular, ensina o corpo a maneira de absorver força e redirecioná-la.",
                            ImagemUrl = "/Imagens/Fisioterapia/Fisioterapia4.png",
                            Nome = "Halteres Bola Pintado 3kg",
                            Preco = 47m,
                            Quantidade = 100
                        },
                        new
                        {
                            Id = 13,
                            CategoriaId = 4,
                            Descricao = "Eliminação de impacto e pressão. Indicada especialmente para atleta, ginastas e esportistas em geral.",
                            ImagemUrl = "/Imagens/Acessibilidade/Acessibilidade1.png",
                            Nome = "Palmilha Sob Gel",
                            Preco = 87m,
                            Quantidade = 100
                        },
                        new
                        {
                            Id = 14,
                            CategoriaId = 4,
                            Descricao = "Conforto, alívio das dores, calos, calosidades, elimina o atrito e pressão interdigital e protege os dedos do roce nos calçados. Pode ser recortado no tamanho desejado. Permite utilização de medicação tópica",
                            ImagemUrl = "/Imagens/Acessibilidade/Acessibilidade2.png",
                            Nome = "Tubogel recortável para calos",
                            Preco = 21m,
                            Quantidade = 100
                        },
                        new
                        {
                            Id = 15,
                            CategoriaId = 4,
                            Descricao = "onforto para ser utilizado em ambientes de saúde. Capa resistente a água, de fácil higienização. Travesseiro durável. Maior conforto para dormir.",
                            ImagemUrl = "/Imagens/Acessibilidade/Acessibilidade3.png",
                            Nome = "Travesseiro hospitalar",
                            Preco = 77m,
                            Quantidade = 100
                        },
                        new
                        {
                            Id = 16,
                            CategoriaId = 4,
                            Descricao = "Espuma com memória para maior conforto e sustentação da cervical.",
                            ImagemUrl = "/Imagens/Acessibilidade/Acessibilidade4.png",
                            Nome = "Suporte super neck pillow grafite",
                            Preco = 81m,
                            Quantidade = 100
                        });
                });

            modelBuilder.Entity("Ecommerce.Api.Entities.Telefone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("NumeroTelefone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PessoaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId");

                    b.ToTable("Telefones");
                });

            modelBuilder.Entity("Ecommerce.Api.Entities.Cliente", b =>
                {
                    b.HasBaseType("Ecommerce.Api.Entities.Pessoa");

                    b.Property<double>("Credito")
                        .HasColumnType("float");

                    b.HasDiscriminator().HasValue("Cliente");

                    b.HasData(
                        new
                        {
                            PessoaId = 1,
                            CPF = "12345678910",
                            Email = "pedro.soldera@hotmail.com",
                            Nome = "Pedro Soldera",
                            Password = "manco321",
                            Status = 1,
                            Credito = 0.0
                        },
                        new
                        {
                            PessoaId = 2,
                            CPF = "09876543211",
                            Email = "gabriel.tozato@hotmail.com",
                            Nome = "Gabriel Tozato",
                            Password = "beaba123",
                            Status = 1,
                            Credito = 0.0
                        });
                });

            modelBuilder.Entity("Ecommerce.Api.Entities.Funcionario", b =>
                {
                    b.HasBaseType("Ecommerce.Api.Entities.Pessoa");

                    b.Property<double>("Salario")
                        .HasColumnType("float");

                    b.HasDiscriminator().HasValue("Funcionario");

                    b.HasData(
                        new
                        {
                            PessoaId = 3,
                            CPF = "45693287694",
                            Email = "gabriel.tozato@hotmail.com",
                            Nome = "Ana Nicolly",
                            Password = "beaba123",
                            Status = 2,
                            Salario = 0.0
                        });
                });

            modelBuilder.Entity("Ecommerce.Api.Entities.CarrinhoItem", b =>
                {
                    b.HasOne("Ecommerce.Api.Entities.Carrinho", "Carrinho")
                        .WithMany("Itens")
                        .HasForeignKey("CarrinhoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ecommerce.Api.Entities.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Carrinho");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("Ecommerce.Api.Entities.Email", b =>
                {
                    b.HasOne("Ecommerce.Api.Entities.Pessoa", null)
                        .WithMany("Emails")
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Ecommerce.Api.Entities.Produto", b =>
                {
                    b.HasOne("Ecommerce.Api.Entities.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("Ecommerce.Api.Entities.Telefone", b =>
                {
                    b.HasOne("Ecommerce.Api.Entities.Pessoa", null)
                        .WithMany("Telefones")
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Ecommerce.Api.Entities.Carrinho", b =>
                {
                    b.Navigation("Itens");
                });

            modelBuilder.Entity("Ecommerce.Api.Entities.Pessoa", b =>
                {
                    b.Navigation("Emails");

                    b.Navigation("Telefones");
                });
#pragma warning restore 612, 618
        }
    }
}