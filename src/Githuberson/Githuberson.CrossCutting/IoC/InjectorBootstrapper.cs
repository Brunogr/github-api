using Githuberson.Application.Clients;
using Githuberson.Application.Services;
using Githuberson.Application.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Serialization;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;

namespace Githuberson.CrossCutting.IoC
{
    public static class InjectorBootstrapper
    {
        public static IServiceCollection RegisterServices(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddScoped<IGitHubService, GitHubService>();

            serviceCollection.AddScoped<IGitHubClient>(ctx =>
            {
                return RestService.For<IGitHubClient>(configuration.GetSection("Github:Host").Value,
                new RefitSettings
                {
                    JsonSerializerSettings = new Newtonsoft.Json.JsonSerializerSettings
                    {
                        ContractResolver = new CamelCasePropertyNamesContractResolver(),
                        ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                    }
                });
            });

            return serviceCollection;
        }
    }
}
