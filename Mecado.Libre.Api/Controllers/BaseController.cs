using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Mecado.Libre.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        protected async Task<ObjectResult> ResponseService<T>(T response)
        {
            return await Task.Run(
                () =>
                {
                    return new ObjectResult(response)
                    {
                        StatusCode = (int)HttpStatusCode.OK
                    };
                });
        }
    }
}
