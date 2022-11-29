using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SistemaEmprestimoBancos.Bancos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmprestimoBancos.Conexao
{
    public class BancoContext : DbContext
    {
        public DbSet<Banco>? bancos { get; set; }
        

       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=;Initial Catalog=;User ID=;Password=;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }


    }
}
