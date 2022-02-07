using Mercado.Libre.Business.Dtos;
using System.Collections.Generic;

namespace Mercado.Libre.Business.Data
{
    public interface ISatelliteData
    {
        SatelliteDto Create(SatelliteDto satelliteDto);
        ICollection<SatelliteDto> GetAll();
    }
}
