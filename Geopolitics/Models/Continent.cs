using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Geopolitics.Models
{
    [Table("Contnents")]
    public class Continent
    {
        [Key]
        public int ContinentID { get; set; }
        [StringLength(100, ErrorMessage = "O Tamanho máximo é 100 caracteres")]
        [Required(ErrorMessage = "Informe o nome do continente")]
        [Display(Name = "Nome")]
        public string ContinentName { get; set; }
        [StringLength(200, ErrorMessage = "O Tamanho máximo é 200 caracteres")]
        [Required(ErrorMessage = "Informe a descrição do continente")]
        [Display(Name = "Nome")]
        public string Description { get; set; }
        public List<Country> Countries { get; set; }

    }
}
