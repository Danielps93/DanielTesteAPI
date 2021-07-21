using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTesteCodeBlox.Models
{
    public class Apresentacao
    {
        public Apresentacao()
        {
            rotas = new List<string>();
            rotas.Add("/produtos");
        }
        
        private List<string> rotas { get; set; }

        public string Mensagem { get { return "Api Teste CodeBlox"; } }
        public List<string> Rotas { get { return this.rotas; } }

    }
}
