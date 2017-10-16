using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Models
{
    public class HackathonContext : DbContext
    {
        public HackathonContext(DbContextOptions<HackathonContext> options)
            : base(options)
        {

        }

        public DbSet<ScoreTable> ScoreTable { get; set; }

    }
}