using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIfinalPloomes.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Cidade_Res { get; set; }

        public Servico Servico { get; set; }

        public int IdServico { get; set; }

    }
}
