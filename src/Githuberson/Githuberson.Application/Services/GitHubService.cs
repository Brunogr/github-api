﻿using Githuberson.Application.Clients;
using Githuberson.Application.Models;
using Githuberson.Application.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Serialization;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Githuberson.Application.Services
{
    public class GitHubService : IGitHubService
    {
        IGitHubClient gitHubClient;
        public GitHubService(IConfiguration configuration)
        {
            this.gitHubClient = RestService.For<IGitHubClient>(configuration.GetSection("Github:Host").Value,
                new RefitSettings
                {
                    JsonSerializerSettings = new Newtonsoft.Json.JsonSerializerSettings
                    {
                        ContractResolver = new CamelCasePropertyNamesContractResolver(),
                        ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                    }
                });
        }

        public async Task<List<GitRepository>> GetRepositories()
        {
            var result = await this.gitHubClient.GetTakeRepositories();
            
            return result.Items.OrderBy(o => o.Created_at).Take(5).ToList();
        }
    }
}
