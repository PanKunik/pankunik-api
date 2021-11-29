using WebAPI.Infrastructure.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace WebAPI.Infrastructure.Installers
{
    public class RegisterAutoMapper : IServiceRegistration
    {
        public void Register(IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(typeof(Startup).Assembly);
        }
    }
}