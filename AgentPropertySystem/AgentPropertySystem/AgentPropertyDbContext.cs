using AgentPropertySystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgentPropertySystem
{
    public class AgentPropertyDbContext:DbContext
    {
        private readonly IConfiguration _configuration;
        public AgentPropertyDbContext(IConfiguration configuration, DbContextOptions<AgentPropertyDbContext> options) : base(options)
        {
            _configuration = configuration;
        }
        public DbSet<AgentDetail> AgentDetails { get; set; }
        public DbSet<PropertyDetail> PropertyDetails { get; set; }
    }
}
