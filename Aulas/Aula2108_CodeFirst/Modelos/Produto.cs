using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2108_CodeFirst.Modelos
{
    class Produto
    {
        
        public int ProdutoID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public decimal Imposto { get; set; }
        
        //Relacionamaneto Produto  <--> Categoria
        //Chave Estrangeira
        public int CategoriaID { get; set; }

        //Propriedade de Navegação
        public virtual Categoria _Categoria { get; set; }

    }
}
