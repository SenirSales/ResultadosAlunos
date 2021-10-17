using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResultadosAlunosMVC.Models
{
    public class Context : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Nota> Notas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Resultadosalunos;Integrated Security=true");
        }

        public void SetModified(Aluno Aluno)
        {
            throw new NotImplementedException();
        }
    }
}
