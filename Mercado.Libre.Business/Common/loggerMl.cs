using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado.Libre.Business.Common
{
    public class loggerMl<TCategory> : IloggerMl<TCategory>
    {
        private readonly ILogger<TCategory> Logger;

        public loggerMl(ILogger<TCategory> logger)
        {
            Logger = logger??  throw new ArgumentNullException(nameof(logger));
        }
        public Task SetError(Exception exception)
        {
            Logger.LogError(exception,exception.Message);
            return Task.FromResult(true);
        }

        public Task SetLog(string message)
        {
            Logger.LogInformation(message);
            return Task.FromResult(true);
        }
    }
}
