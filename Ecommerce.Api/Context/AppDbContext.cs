using Ecommerce.Api.Entities;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace Ecommerce.Api.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Carrinho>? Carrinhos { get; set; }
        public DbSet<CarrinhoItem>? CarrinhoItens { get; set; }
        public DbSet<Categoria>? Categorias { get; set; }
        public DbSet<Produto>? Produtos { get; set; }
        public DbSet<Pessoa>? Pessoas { get; set; }
        public DbSet<Cliente>? Clientes { get; set; }
        public DbSet<Funcionario>? Funcionarios { get; set; }
        public DbSet<Email>? Emails { get; set; }
        public DbSet<Telefone>? Telefones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>().HasData(new Categoria
            {
                Id = 1,
                Nome = "Ortopédico",
                IconCSS = "fas fa-spa"
            });
            modelBuilder.Entity<Categoria>().HasData(new Categoria
            {
                Id = 2,
                Nome = "Hospitalar",
                IconCSS = "fas fa-spa"
            });
            modelBuilder.Entity<Categoria>().HasData(new Categoria
            {
                Id = 3,
                Nome = "Fisioterapia",
                IconCSS = "fas fa-spa"
            });
            modelBuilder.Entity<Categoria>().HasData(new Categoria
            {
                Id = 4,
                Nome = "Acessibilidade",
                IconCSS = "fas fa-spa"
            });
            modelBuilder.Entity<Cliente>().HasData(new Cliente
            {
                PessoaId = 1,
                Nome = "Pedro Soldera",
                CPF = "12345678910",
                Status = 1,
                Email = "pedro.soldera@hotmail.com",
                Password = "manco321"
            });
            modelBuilder.Entity<Cliente>().HasData(new Cliente
            {
                PessoaId = 2,
                Nome = "Gabriel Tozato",
                CPF = "09876543211",
                Status = 1,
                Email = "gabriel.tozato@hotmail.com",
                Password = "beaba123"
            });
            modelBuilder.Entity<Funcionario>().HasData(new Funcionario
            {
                PessoaId = 3,
                Nome = "Ana Nicolly",
                CPF = "45693287694",
                Status = 2,
                Email = "gabriel.tozato@hotmail.com",
                Password = "beaba123"
            });
            //Ortopedico
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 1,
                Nome = "Tornozeleira Tamanho pequeno",
                Descricao = "Para compressão da articulação do tornozelo no tratamento e prevenção do edema de entorses, tendinites, bursites e artrite reumatóide.",
                ImagemUrl = "/Imagens/Ortopedico/Ortopedico1.png",
                Preco = 40,
                Quantidade = 100,
                CategoriaId = 1,
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 2,
                Nome = "Tipoia promocional Tamanho Grande",
                Descricao = "Produto indicado para descanso e sustentação do membro superior (braço e antebraço) em casos de fraturas, engessamentos, lesões, pós-operatórios e sequelas de AVC.",
                ImagemUrl = "/Imagens/Ortopedico/Ortopedico2.png",
                Preco = 14,
                Quantidade = 100,
                CategoriaId = 1,
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 3,
                Nome = "Tala para punho lado esquerdo Tamanho pequeno",
                Descricao = "Prevenção e tratamento contra tendinite, artrite reumatoide, artrose, lesões ligamentares, síndrome do túnel do corpo, tenossinovite, LER/DORT, prevenção da recidiva na prática de atividades",
                ImagemUrl = "/Imagens/Ortopedico/Ortopedico3.png",
                Preco = 34,
                Quantidade = 100,
                CategoriaId = 1,
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 4,
                Nome = "Tala Polegar Ajustavel",
                Descricao = "A Tala Polegar Ajustável Bilateral NeoSoft proporciona proteção e estabilidade ao punho e ao polegar. A compressão é regulável para maior conforto.",
                ImagemUrl = "/Imagens/Ortopedico/Ortopedico4.png",
                Preco = 28,
                Quantidade = 100,
                CategoriaId = 1,
            });
            //Hospitalar
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 5,
                Nome = "Termômetro Digital Infravermelho",
                Descricao = "Termômetro de testa, com capacidade de aferir temperatura tanto de objetos quanto de seres humanos.",
                ImagemUrl = "/Imagens/Hospitalar/Hospitalar1.png",
                Preco = 109,
                Quantidade = 100,
                CategoriaId = 2,
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 6,
                Nome = "Termometro Clinico Digital",
                Descricao = "Termômetro clínico digital Domotherm Incoterm.",
                ImagemUrl = "/Imagens/Hospitalar/Hospitalar2.png",
                Preco = 12,
                Quantidade = 100,
                CategoriaId = 2,
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 7,
                Nome = "Seringa descartável 60ml sem agulha",
                Descricao = "Desenvolvida para aplicação de medicamentos pela via parenteral e coleta de sangue.",
                ImagemUrl = "/Imagens/Hospitalar/Hospitalar3.png",
                Preco = 3,
                Quantidade = 100,
                CategoriaId = 2,
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 8,
                Nome = "Suporte Coletor De Material Perfurocortante",
                Descricao = "Termômetro clínico digital Domotherm Incoterm.",
                ImagemUrl = "/Imagens/Hospitalar/Hospitalar4.png",
                Preco = 27,
                Quantidade = 100,
                CategoriaId = 2,
            });
            //Fisioterapia
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 9,
                Nome = "Bola Fisioball 75CM",
                Descricao = "BOLA FISIOBALL 75CM CINZA ORTHOPAUHER.",
                ImagemUrl = "/Imagens/Fisioterapia/Fisioterapia1.png",
                Preco = 124,
                Quantidade = 100,
                CategoriaId = 3,
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 10,
                Nome = "Balança corporal digital",
                Descricao = "Tecnologia, Inovação à Serviço dos Cuidados da sua Saúde! - Equipada com 4 sensores de medição de massa - Plataforma de vidro temperado de 280x260 mm e espessura da 5mm - Acionamento por pressão.",
                ImagemUrl = "/Imagens/Fisioterapia/Fisioterapia2.png",
                Preco = 67,
                Quantidade = 100,
                CategoriaId = 3,
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 11,
                Nome = "Bolinha Fisioterapia Anti Stress",
                Descricao = "Confeccionado em poliuretano com formato de esfera. MODO DE USO Segurar com a palma da mão e fazer moviventos de aperto (flexão).",
                ImagemUrl = "/Imagens/Fisioterapia/Fisioterapia3.png",
                Preco = 5,
                Quantidade = 100,
                CategoriaId = 3,
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 12,
                Nome = "Halteres Bola Pintado 3kg",
                Descricao = "Intensifica a produção de potência muscular, ensina o corpo a maneira de absorver força e redirecioná-la.",
                ImagemUrl = "/Imagens/Fisioterapia/Fisioterapia4.png",
                Preco = 47,
                Quantidade = 100,
                CategoriaId = 3,
            });
            //Acessibilidade
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 13,
                Nome = "Palmilha Sob Gel",
                Descricao = "Eliminação de impacto e pressão. Indicada especialmente para atleta, ginastas e esportistas em geral.",
                ImagemUrl = "/Imagens/Acessibilidade/Acessibilidade1.png",
                Preco = 87,
                Quantidade = 100,
                CategoriaId = 4,
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 14,
                Nome = "Tubogel recortável para calos",
                Descricao = "Conforto, alívio das dores, calos, calosidades, elimina o atrito e pressão interdigital e protege os dedos do roce nos calçados. Pode ser recortado no tamanho desejado. Permite utilização de medicação tópica",
                ImagemUrl = "/Imagens/Acessibilidade/Acessibilidade2.png",
                Preco = 21,
                Quantidade = 100,
                CategoriaId = 4,
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 15,
                Nome = "Travesseiro hospitalar",
                Descricao = "onforto para ser utilizado em ambientes de saúde. Capa resistente a água, de fácil higienização. Travesseiro durável. Maior conforto para dormir.",
                ImagemUrl = "/Imagens/Acessibilidade/Acessibilidade3.png",
                Preco = 77,
                Quantidade = 100,
                CategoriaId = 4,
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 16,
                Nome = "Suporte super neck pillow grafite",
                Descricao = "Espuma com memória para maior conforto e sustentação da cervical.",
                ImagemUrl = "/Imagens/Acessibilidade/Acessibilidade4.png",
                Preco = 81,
                Quantidade = 100,
                CategoriaId = 4,

            });

        }
    }
}
