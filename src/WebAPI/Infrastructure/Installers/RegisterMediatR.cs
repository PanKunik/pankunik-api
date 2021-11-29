using WebAPI.Infrastructure.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MediatR;

namespace WebAPI.Infrastructure.Installers
{
    public class RegisterMediatR : IServiceRegistration
    {
        public void Register(IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(typeof(Startup));
        }
    }
}