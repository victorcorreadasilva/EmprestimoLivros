using EmprestimoLivros.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace EmprestimoLivros.Data
{
    public class ApplicationDbContext : DbContext
    {
        #region Construtor

#pragma warning disable IDE0290 // Usar construtor primário
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        #endregion Construtor

        #region Tabela

        [Description("Tabela Emprestimo")]
        public DbSet<EmprestimoModel> Emprestimo { get; set; }

        #endregion Tabela
    }
}
