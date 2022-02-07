using Mercado.Libre.Business.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mercado.Libre.Business.Data;

namespace Mercado.Libre.Business
{
    public class SatelliteBusiness : ISatelliteBusiness
    {
        private readonly ISatelliteData SatelliteData;
        public SatelliteBusiness(ISatelliteData satelliteData)
        {
            SatelliteData = satelliteData ?? throw new ArgumentNullException(nameof(satelliteData));
        }
        public SatelliteDto Create(SatelliteDto satelliteDto)
        {
            return SatelliteData.Create(satelliteDto);
        }

        public ResponseTopSecretDto TopSecret(RequestTopSecretDto requestTopSecretDto)
        {
            ResponseTopSecretDto responseTopSecretDto = new ResponseTopSecretDto();
            responseTopSecretDto.Message = GetMessage(requestTopSecretDto.Satellites.Select(x => x.Message).ToArray());
            responseTopSecretDto.Position = GetLocation(requestTopSecretDto.Satellites.Select(x => x.Distance).ToArray());

            return responseTopSecretDto;

        }

        public ResponseTopSecretDto TopSecret()
        {
            ResponseTopSecretDto responseTopSecretDto = new ResponseTopSecretDto();
            ICollection<SatelliteDto> sas = SatelliteData.GetAll();
            return responseTopSecretDto;
        }

        private PositionDto GetLocation(ICollection<decimal> messages)
        {
            return new PositionDto() { X = 0, Y = 0 };
        }
        private string GetMessage(ICollection<string[]> messages)
        {
            int length = 0;
            string[] result = new string[length];
            foreach (string[] item in messages)
            {
                if (length == 0)
                {
                    length = item.Length;
                    result = new string[length];
                }
                for (int i = 0; i < length; i++)
                {
                    if (!string.IsNullOrEmpty(item[i]))
                        result[i] = item[i];
                }
            }
            return String.Join(" ", result);
        }
    }
}
