using Githuberson.Application.Clients;
using Githuberson.Application.Models;
using Githuberson.Application.Models.Blip;
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
        private readonly IGitHubClient gitHubClient;
        public GitHubService(IConfiguration configuration, IGitHubClient gitHubClient)
        {
            this.gitHubClient = gitHubClient;
        }

        public async Task<BlipDocument> GetRepositories()
        {
            var result = await this.gitHubClient.GetTakeRepositories();

            var document = new BlipDocument(result.Items.OrderBy(o => o.Created_at).Take(5)
                .Select(item => 
                    new CarouselDocument(
                            new CarouselHeader(item.Full_name, item.Name, item.Owner.Avatar_url)
                        )
                    ).ToArray()
                );
            
            return document;
        }
    }
}
