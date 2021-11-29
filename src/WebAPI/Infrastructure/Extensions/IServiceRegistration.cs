using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace WebAPI.Infrastructure.Extensions
{
    public interface IServiceRegistration
    {
        void Register(IServiceCollection services, IConfiguration configuration);
    }
}