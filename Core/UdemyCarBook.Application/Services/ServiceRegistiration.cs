using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Application.Services
{
    public static class ServiceRegistiration //static olmasını unutma!
        //constructor uygulanan tüm methodlar için dependency injection eklenmiş oldu.
        //cqrs'ten fark adım 6

    {
        public static void AddApplicationServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(
                typeof(ServiceRegistiration).Assembly));
        }
    }
}
