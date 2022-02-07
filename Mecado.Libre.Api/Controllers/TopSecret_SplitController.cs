using Mercado.Libre.Business;
using Mercado.Libre.Business.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Mecado.Libre.Api.Controllers
{
    public class TopSecret_SplitController : BaseController
    {
        private readonly ISatelliteBusiness SateliteBusiness;

        public TopSecret_SplitController(
            ISatelliteBusiness sateliteBusiness
            )
        {
            SateliteBusiness = sateliteBusiness ?? throw new ArgumentNullException(nameof(sateliteBusiness));
        }

        [HttpGet]

        public async Task<ActionResult> Get()
        {
            return await ResponseService<ResponseTopSecretDto>(SateliteBusiness.TopSecret());
        }

        [HttpPost]
        [Route("{Name}")]

        public async Task<ActionResult> Post(string Name, SatelliteDto satelliteDto)
        {
            return await ResponseService<SatelliteDto>(SateliteBusiness.Create(satelliteDto));
        }
    }
}
