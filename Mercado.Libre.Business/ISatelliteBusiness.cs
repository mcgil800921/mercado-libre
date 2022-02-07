using Mercado.Libre.Business.Dtos;

namespace Mercado.Libre.Business
{
    public interface ISatelliteBusiness
    {
        ResponseTopSecretDto TopSecret(RequestTopSecretDto requestTopSecretDto);
    }
}
