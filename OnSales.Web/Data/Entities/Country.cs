using System.ComponentModel.DataAnnotations;

namespace OnSales.Web.Data.Entities
{
    public class Country
    {
        public int Id { get; set; }
        [Display(Name = "Paìs")]
        [MaxLength(50, ErrorMessage = "El {0} Campo debe tener mas de  {1} caracter.")]
        [Required(ErrorMessage = "El Campo {0}  es obligatorio.")]
        public string NameCountry { get; set; }
    }
}
