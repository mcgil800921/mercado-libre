using Mercado.Libre.Business.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mercado.Libre.Business
{
    public class SatelliteBusiness : ISatelliteBusiness
    {
        public ResponseTopSecretDto TopSecret(RequestTopSecretDto requestTopSecretDto)
        {
            ResponseTopSecretDto responseTopSecretDto = new ResponseTopSecretDto();
            responseTopSecretDto.Message = GetMessage(requestTopSecretDto.Satellites.Select(x => x.Message).ToArray());
            responseTopSecretDto.Position = GetLocation(requestTopSecretDto.Satellites.Select(x => x.Distance).ToArray());

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
