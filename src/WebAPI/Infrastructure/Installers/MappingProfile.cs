using AutoMapper;
using System;
using System.Reflection;
using System.Linq;
using WebAPI.Application.Common;

namespace WebAPI.Infrastructure.Installers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            ApplyMappingFromAssemlby(Assembly.GetExecutingAssembly());
        }

        private void ApplyMappingFromAssemlby(Assembly assembly)
        {
            var types = assembly.GetExportedTypes()
                                .Where(t => t.GetInterfaces()
                                             .Any(i => i.IsGenericType
                                                    && i.GetGenericTypeDefinition() == typeof(IMapFrom<>)))
                                .ToList();

            foreach (var type in types)
            {
                var instance = Activator.CreateInstance(type);
                var methodInfo = type.GetMethod("Mapping")
                    ?? type.GetInterface("IMapFrom`1")
                           .GetMethod("Mapping");

                methodInfo?.Invoke(instance, new object[] { this });
            }
        }
    }
}