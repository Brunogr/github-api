using System;
using System.Collections.Generic;
using System.Text;

namespace Githuberson.Application.Models
{
    public class RepositoryWrapper
    {
        public int Total_count { get; set; }
        public List<GitRepository> Items { get; set; }
    }
    public class GitRepository
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Full_name { get; set; }
        public Owner Owner { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }
        public DateTime Pushed_at { get; set; }
    }

    public class Owner
    {
        public string Avatar_url { get; set; }        
    }

}
