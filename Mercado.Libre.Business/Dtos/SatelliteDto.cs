using System.ComponentModel.DataAnnotations;

namespace Mercado.Libre.Business.Dtos
{
    public class SatelliteDto
    {
        [Required]
        public decimal Distance { get; set; }
        [Required]
        public string[] Message { get; set; }
    }
}
