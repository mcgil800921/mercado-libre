using System.Collections.Generic;

namespace Mercado.Libre.Business.Dtos
{
    public class RequestTopSecretDto
    {
        public ICollection<SatelliteAvancedDto> Satellites { get; set; }
    }
}
