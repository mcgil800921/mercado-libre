using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado.Libre.Business.Common
{
    public interface IloggerMl<TCategory>
    {
        Task SetError(Exception exception);
        Task SetLog(string message);
    }
}
