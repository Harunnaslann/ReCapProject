using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ReCap.Business.DependencyResolvers.Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseServiceProviderFactory(new AutofacServiceProviderFactory())//Service saðlayýcýsý olarak AutofacServiceProviderFactory kullanacaðýmýzý belirtiyoruz.
                .ConfigureContainer<ContainerBuilder>(builder=>
                {
                    builder.RegisterModule(new AutofacBusinessModule());//Oluþturduðumuz AutofacBusinessModule'i API ye implemente ettik.
                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
