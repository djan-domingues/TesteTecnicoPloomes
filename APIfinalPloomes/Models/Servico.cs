using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIfinalPloomes.Models
{
    public class Servico
    {
        public int Id { get; set; }

        public string Tipo { get; set; }

        public double Preco { get; set; }

        public Empresa Empresa { get; set; }

        public int IdEmpresa { get; set; }


    }
}
