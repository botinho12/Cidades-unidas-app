using Microsoft.EntityFrameworkCore;
using CidadesUnidasApp.Models;

namespace CidadesUnidasApp.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Estado> Estados { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
    }
}