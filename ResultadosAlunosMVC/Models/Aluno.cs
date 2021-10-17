using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ResultadosAlunosMVC.Models
{
    public class Aluno
    {
        public int Id { get; set; }

        [StringLength(80, MinimumLength = 3)]
        [Required]
        [Display(Name = "Aluno")]
        public string Nome { get; set; }

        //public List<Nota> Nota { get; set; }
        //public List<TesteModel> TesteModel { get; set; }
        ///public int NotaId { get; set; }
        
        public Nota Notas { get; set; }
    }

}
