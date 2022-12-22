﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkPlayers
{
    internal class PlayerContext :DbContext
    {
  

            public DbSet<Player> Player { get; set; }
            public DbSet<Team> Team { get; set; }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
            optionsBuilder.UseSqlServer("Data Source=localhost;Database=DBPlayers;" +
                "Integrated Security=True;TrustServerCertificate=True");
            }
        }
}
