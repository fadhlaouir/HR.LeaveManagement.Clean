using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace HR.LeaveManagement.Application
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly()); // auto mapper is used to map between different objects in the application
            services.AddMediatR(Assembly.GetExecutingAssembly()); // mediator is used to send requests to the application layer

            return services;
        }
    }
}
