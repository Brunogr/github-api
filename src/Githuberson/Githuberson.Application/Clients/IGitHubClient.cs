using Githuberson.Application.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Githuberson.Application.Clients
{

    [Headers("Accept: application/vnd.github.v3+json", "user-agent: netcore")]
    public interface IGitHubClient
    {

        [Get("/search/repositories?q=user:takenet+language:C%23&")]
        Task<RepositoryWrapper> GetTakeRepositories();


        //[Get("/search/repositories?q=user:{user}+language:C%23&")]
        //Task<RepositoryWrapper> GetRepositories(string user);
    }
}
