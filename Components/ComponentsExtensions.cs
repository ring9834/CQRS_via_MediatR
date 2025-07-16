using Microsoft.Extensions.DependencyInjection;

namespace Components;

public static class ComponentsExtensions
{
    public static IServiceCollection AddComponents(this IServiceCollection services)
    {
        // a placeholder created during initial project setup, with the intention of adding service registrations later
        return services;
    }
}