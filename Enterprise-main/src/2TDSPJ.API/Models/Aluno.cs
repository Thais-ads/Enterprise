using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _2TDSPJ.API.Models
{
    public class Aluno
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AlunoId { get; set; }

        [Required(ErrorMessage ="Nome Obrigatorio")]
        public string Name { get; set; }

        [Required(ErrorMessage = " Obrigatorio")]
        public bool Ativo { get; set; }
    }
}
