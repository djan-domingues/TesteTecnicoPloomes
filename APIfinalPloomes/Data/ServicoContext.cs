using APIfinalPloomes.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace APIfinalPloomes.Data
{
    public class ServicoContext : DbContext
    {
        public ServicoContext(DbContextOptions<ServicoContext> options) : base(options) { }

        public DbSet<Servico> Servicos { get; set; }

        public DbSet<Empresa> Empresas { get; set; }

        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfiguration configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", false, true)
            .Build();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("ServerConnection"));
        }

    }
}
