using Mercado.Libre.Business.Dtos;
using System.Threading.Tasks;

namespace Mercado.Libre.Business
{
    public interface ISatelliteBusiness
    {
        ResponseTopSecretDto TopSecret(RequestTopSecretDto requestTopSecretDto);
        ResponseTopSecretDto TopSecret();
        SatelliteDto Create(SatelliteDto satelliteDto);
    }
}
