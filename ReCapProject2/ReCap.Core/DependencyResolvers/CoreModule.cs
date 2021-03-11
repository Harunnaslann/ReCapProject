using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using ReCap.Core.CrossCuttingConcerns.Caching;
using ReCap.Core.CrossCuttingConcerns.Caching.Microsoft;
using ReCap.Core.Utilities.IoC;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Core.DependencyResolvers
{
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection serviceCollection)
        {
            serviceCollection.AddMemoryCache();
            serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            serviceCollection.AddSingleton<ICacheManager, MemoryCacheManager>();
            serviceCollection.AddSingleton<Stopwatch>();
        }
    }
}
