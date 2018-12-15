using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Githuberson.Application.Models;
using Githuberson.Application.Models.Blip;
using Githuberson.Application.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Githuberson.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GitHubController : ControllerBase
    {
        private readonly IGitHubService gitHubService;
        public GitHubController(IGitHubService gitHubService)
        {
            this.gitHubService = gitHubService;
        }

        [HttpGet]
        public async Task<ActionResult<BlipDocument>> Get()
        {
            var result = await this.gitHubService.GetRepositories();
            return Ok(result);
        }
    }
}