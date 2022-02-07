using System.ComponentModel.DataAnnotations;

namespace Mercado.Libre.Business.Dtos
{
    public class SatelliteAvancedDto: SatelliteDto
    {
        [Required]
        public string Name { get; set; }
    }
}
