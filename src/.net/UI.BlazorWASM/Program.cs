using Core.Interfaces.DataLayer;
using Core.Interfaces.ECommerceItems;
using Core.Interfaces.Services;

using DataLayer.FakeDatabase;

using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

using Services.FakeService;

using System;
using System.Net.Http;
using System.Threading.Tasks;

using UI.BlazorWASM.Models.ECommerceItems;

namespace UI.BlazorWASM
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            ServiceConfig(builder.Services);

            await builder.Build().RunAsync();
        }

        private static void ServiceConfig(IServiceCollection services)
        {
            services.AddTransient<ILaptop, LaptopModel>()
                    .AddTransient<IMobilePhone, MobilePhoneModel>();

            services.AddTransient<ILaptopDataLayer<ILaptop>, LaptopDataLayer<ILaptop>>()
                    .AddTransient<IMobilePhoneDataLayer<IMobilePhone>, MobilePhoneDataLayer<IMobilePhone>>()
                    .AddSingleton<ILaptopService<ILaptop>, LaptopService<ILaptop>>()
                    .AddSingleton<IMobilePhoneService<IMobilePhone>, MobilePhoneService<IMobilePhone>>();
        }
    }
}