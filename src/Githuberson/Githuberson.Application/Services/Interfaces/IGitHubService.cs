using Githuberson.Application.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Githuberson.Application.Services.Interfaces
{
    public interface IGitHubService
    {
        Task<List<GitRepository>> GetRepositories();
    }
}
