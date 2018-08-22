using System.Data.Entity;


namespace Aula2108_CodeFirst.Modelos.DAL
{
    //Deve herdar da DBcontext
    public class Contexto : DbContext
    {
        public Contexto() : base("nomeStringConexao")
        {

        }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }

    }
}
