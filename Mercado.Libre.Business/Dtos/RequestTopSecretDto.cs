using System.Collections.Generic;

namespace Mercado.Libre.Business.Dtos
{
    public class RequestTopSecretDto
    {
        public ICollection<SatelliteDto> Satellites { get; set; }
    }
}
