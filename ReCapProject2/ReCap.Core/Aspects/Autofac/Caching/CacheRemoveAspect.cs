using Castle.DynamicProxy;
using ReCap.Core.CrossCuttingConcerns.Caching;
using ReCap.Core.Utilities.Interceptors;
using ReCap.Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;

namespace ReCap.Core.Aspects.Autofac.Caching
{
    public class CacheRemoveAspect : MethodInterception
    {
        private string _pattern;
        private ICacheManager _cacheManager;

        public CacheRemoveAspect(string pattern)
        {
            _pattern = pattern;
            _cacheManager = ServiceTool.ServiceProvider.GetService<ICacheManager>();
        }

        protected override void OnSuccess(IInvocation invocation)
        {
            _cacheManager.RemoveByPattern(_pattern);
        }
    }
}
