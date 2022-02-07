using Mercado.Libre.Business.Common;
using Mercado.Libre.Business.Dtos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mercado.Libre.Business.Data
{
    public class SatelliteData : ISatelliteData
    {
        private readonly ApiContext ApiContext;

        public SatelliteData(ApiContext apiContext)
        {
            ApiContext = apiContext ?? throw new ArgumentNullException(nameof(apiContext));
        }
        public SatelliteDto Create(SatelliteDto satelliteDto)
        {
            Satellite satellite = new Satellite()
            {
                Distance = satelliteDto.Distance,
                Message = JsonConvert.SerializeObject(satelliteDto.Message)
            };

            ApiContext.Satellites.Add(satellite);
            ApiContext.SaveChanges();
            return satelliteDto;
        }
        public ICollection<SatelliteDto> GetAll()
        {
            ICollection<Satellite> result = ApiContext.Satellites.Local.ToList();
            return result.Clone<Satellite, SatelliteDto>();
        }
    }
}
