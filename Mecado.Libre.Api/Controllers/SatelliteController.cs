using Mercado.Libre.Business;
using Mercado.Libre.Business.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Mecado.Libre.Api.Controllers
{
    public class SatelliteController : BaseController
    {
        private readonly ISatelliteBusiness SateliteBusiness;

        public SatelliteController(
            ISatelliteBusiness sateliteBusiness
            )
        {
            SateliteBusiness = sateliteBusiness ?? throw new ArgumentNullException(nameof(sateliteBusiness));
        }

        [HttpPost]
        public async Task<ActionResult> topsecret(RequestTopSecretDto requestTopSecretDto)
        {
            return await ResponseService<ResponseTopSecretDto>(SateliteBusiness.TopSecret(requestTopSecretDto));
        }
    }
}
