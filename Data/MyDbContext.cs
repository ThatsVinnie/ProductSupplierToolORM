using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class MyDbContext : DbContext
    {
        // Definição de entidades para a base de dados
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Product> Products { get; set; }


        // Método para recuperar a connection string com o banco MYSQL
        private static string GetConnectionString()
        {
            string connectionString = ConfigurationManager.AppSettings["MySqlConnection"];
            return connectionString;
        }

        // Método de ativação da string de conexão
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(GetConnectionString(), new MySqlServerVersion(new Version(8, 0, 35)));
        }
    }
}
