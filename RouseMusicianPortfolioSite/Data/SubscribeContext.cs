using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RouseMusicianPortfolioSite.Data
{
    public class SubscribeContext : DbContext 
    {
        public SubscribeContext(DbContextOptions<SubscribeContext> options) : base(options)
        {

        }

        public DbSet<RouseMusicianPortfolioSite.Models.Subscribe> Subscribe { get; set; }
    }
}
