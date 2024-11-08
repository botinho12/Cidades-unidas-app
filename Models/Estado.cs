using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CidadesUnidasApp.Models
{
    public class Estado
    {
        [Key]
        public int EstadoId { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Estado:")] 
        public string EstadoNome { get; set; }

        [Required]
        [StringLength(2)]
        [Display(Name = "UF:")] 
        public string EstadoSigla { get; set; }

        public List<Cidade> Cidades { get; set; }
    }
}