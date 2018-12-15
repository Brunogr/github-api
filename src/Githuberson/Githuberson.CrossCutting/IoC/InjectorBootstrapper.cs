using Githuberson.Application.Services;
using Githuberson.Application.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Githuberson.CrossCutting.IoC
{
    public static class InjectorBootstrapper
    {
        public static IServiceCollection RegisterServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IGitHubService, GitHubService>();

            return serviceCollection;
        }
    }
}
