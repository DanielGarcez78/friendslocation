using FriendsLocation.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FriendsLocation.Api.Data.Context
{
    public class FriendsLocationContext : DbContext
    {

        public FriendsLocationContext()
        {

        }

        public FriendsLocationContext(DbContextOptions<FriendsLocationContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
           .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
           .AddJsonFile("appsettings.json")
           .Build();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("FriendsDB"));
        }

        public DbSet<Friend> Friend { get; set; }


    }
}
