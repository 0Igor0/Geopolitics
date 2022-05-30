using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Geopolitics.Models
{
    [Table("SelectedCountries")]
    public class SelectedCountries
    {
        public int SelectedCountriesId { get; set; }
        public Country Country { get; set; }

        public int Ammount { get; set; }
        [StringLength(200)]
        public string SelectedId { get; set; }
    }
}
