using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ResultadosAlunosMVC.Models
{
    public class Nota
    {
        /// Add: [Models] Context
        ///      public DbSet<Nota> Notas { get; set; }
        /// add-migration Notas -context Context
        /// Update-Database Notas -context Context
        public int Id { get; set; }

        [Range(0, 10)]
        [Required]
        public int Nota1 { get; set; }
        [Range(0, 10)]
        [Required]
        public int Nota2 { get; set; }
        [Range(0, 10)]
        [Required]
        public int Nota3 { get; set; }
        [Range(0, 10)]
        [Required]
        public int Nota4 { get; set; }
        [Range(0, 100)]
        [Required]
        [Display(Name = "Faltas")]
        public int Falta { get; set; }
        public int AlunoId { get; set; }
        [Display(Name = "Media")]
        public int Media
        {
            get
            {
                return ((Nota1 + Nota2 + Nota3 + Nota4)/4);
            }
        }
        [Display(Name = "Resultado")]
        public string Resultado
        {
            get
            {
                string retorno = "APROVADO";
                if (Media < 7)
                {
                    retorno = "Reprovado por MEDIA";
                }
                else if(Falta>10)
                {
                    retorno = "Reprovado por FALTAS";
                }
                return retorno;
            }
        }
        public Aluno Aluno { get; set; }
    }
}
