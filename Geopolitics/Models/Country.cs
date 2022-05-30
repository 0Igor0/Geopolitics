using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Geopolitics.Models
{
    [Table("Countries")]
    public class Country
    {
        [Key]
        public int CountryId { get; set; }
        [Required(ErrorMessage ="O nome do país deve ser informado")]
        [StringLength(80, MinimumLength =10, ErrorMessage ="O nome deve ter no minimo 0 e no máximo 100")]
        [Display(Name ="Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "O nome do país deve ser informado")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "A descrição deve ter no minimo 0 e no máximo 100")]
        [Display(Name = "Descrição do país")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Informe a população do país")]
        [Display(Name = "Population")]
        [Column(TypeName ="decimal(10,2)")]
        [Range(1,10000000000, ErrorMessage = "A população do país deve estar entre 1 e 10000000000")]
        public double Population { get; set; }
        [Display(Name = "Caminho Imagem Normal")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        public string ImgUrl { get; set; }
        [Display(Name = "é escolhido")]
        public bool IsChosen { get; set; }
        public int ContinentID { get; set; }
        public virtual Continent Continent { get; set; }// propriedade de navegação



    }
}
