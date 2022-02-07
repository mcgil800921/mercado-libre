using Mercado.Libre.Business;
using Mercado.Libre.Business.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Mecado.Libre.Api.Controllers
{
    public class TopSecretController : BaseController
    {
        private readonly ISatelliteBusiness SateliteBusiness;

        public TopSecretController(
            ISatelliteBusiness sateliteBusiness
            )
        {
            SateliteBusiness = sateliteBusiness ?? throw new ArgumentNullException(nameof(sateliteBusiness));
        }

        [HttpPost]
        public async Task<ActionResult> Post(RequestTopSecretDto requestTopSecretDto)
        {
            return await ResponseService<ResponseTopSecretDto>(SateliteBusiness.TopSecret(requestTopSecretDto));
        }
    }
}
