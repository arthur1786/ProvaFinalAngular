using Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.Models
{
    //Classe que reprenta o banco de dados dentro da aplicação
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :
            base(options)
        { }

        public DbSet<Usuario> Usuarios {get;set;}
        public DbSet<ImcModels> Imcs {get;set;}

        
    }
}