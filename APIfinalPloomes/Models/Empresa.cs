using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIfinalPloomes.Models
{
    public class Empresa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Ramo { get; set; }
        public int CNPJ { get; set; }

        public List<Servico> Servicos { get; set; }


    }
}
