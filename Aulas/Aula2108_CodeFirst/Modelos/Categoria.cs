﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2108_CodeFirst.Modelos
{
    class Categoria
    {
        [Key]
        public int CategoriaID { get; set; }
        [Required]
        public string Nome { get; set; }
        public string Descricao { get; set; }

        //Relacionamaneto Categoria  <--> Produto
        public virtual ICollection<Produto> _Produtos { get; set; }
    }
}
