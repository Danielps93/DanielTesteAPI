using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteCodeBlox.Models
{
    public class Produto
    {

        public int IdProduto { get; set; }

        public string Nome { get; set; }

        public double Preco { get; set; }

        public string Descricao { get; set; }

        public int Quantidade { get; set; }

        public string Tipo { get; set; }

        public string DtCadastro { get; set; }
        
    }


}

