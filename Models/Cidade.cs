using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CidadesUnidasApp.Models
{
    public class Cidade
    {
        [Key]
        public int CidadeId { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Cidade:")] 
        public string CidadeNome { get; set; }

        [ForeignKey("Estado")]
        [Display(Name = "Estado:")] 
        public int EstadoId { get; set; }
        public Estado Estado { get; set; }
    }
}