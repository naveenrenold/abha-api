using AbhaApi.DataLayer;
using AbhaApi.Validator.Model;
using FluentValidation;
using Microsoft.AspNetCore.Identity;

namespace AbhaApi.Startup
{
    public static class DependencyInjectionConfig
    {
        public static void AddDependencies(this WebApplicationBuilder builder)
        {
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.Scan(scan => scan
            .FromAssemblyOf<FormDL>() // or any known type in the same assembly
            .AddClasses(classes => classes.Where(type => type.Name.EndsWith("DL")))
            .AsImplementedInterfaces()
            .WithScopedLifetime());

            builder.Services.AddValidatorsFromAssemblyContaining<FormValidator>();
        }
    }
}
