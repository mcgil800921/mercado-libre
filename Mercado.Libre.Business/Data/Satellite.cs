using System.ComponentModel.DataAnnotations;

namespace Mercado.Libre.Business.Data
{
    public class Satellite
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public decimal Distance { get; set; }
        [Required]
        public string Message { get; set; }
    }
}
