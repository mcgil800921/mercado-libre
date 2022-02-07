using Mercado.Libre.Business.Common;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Net;

namespace Mecado.Libre.Api.App_start
{
    public static class MiddlewareException
    {
        public static void MiddlewareExceptionConfig(this IApplicationBuilder app, IloggerMl<Startup> ml)
        {
            app.UseExceptionHandler(appError =>
            {
                appError.Run(async context =>
                {
                    context.Response.ContentType = "application/json";
                    IExceptionHandlerFeature contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                    _ = ml.SetError(contextFeature.Error);
                    HttpStatusCode Code = HttpStatusCode.InternalServerError;
                    if (Enum.IsDefined(typeof(HttpStatusCode), contextFeature.Error.HResult)) Code = (HttpStatusCode)contextFeature.Error.HResult;
                    context.Response.StatusCode = (int)Code;
                    await context.Response.WriteAsync(JsonConvert.SerializeObject(new { message = contextFeature.Error.Message }));
                });
            });
        }
    }
}
