using Microsoft.EntityFrameworkCore;
using ProjetoWebApi.Models;

namespace ProjetoWebApi.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
        : base(options)
        {
        }

        public DbSet<BankAccount> BankAccounts { get; set; }
    }

}