using AutoMapper;
using System.Collections.Generic;

namespace Mercado.Libre.Business.Common
{
    public static class AutoMapper
    {
        public static TNew Clone<TOriginal, TNew>(this TOriginal obj)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TOriginal, TNew>();
            });
            var mapper = config.CreateMapper();
            var result = mapper.Map<TOriginal, TNew>(obj);
            return result;
        }
        public static ICollection<TNew> Clone<TOriginal, TNew>(this ICollection<TOriginal> obj)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TOriginal, TNew>();
            });
            var mapper = config.CreateMapper();
            var result = mapper.Map<ICollection<TNew>>(obj);
            return result;
        }
    }
}
