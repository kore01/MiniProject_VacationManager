using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project_Vacation_Manager.Models;

namespace Project_Vacation_Manager.Data
{
    public class Project_Vacation_ManagerContext : DbContext
    {
        public Project_Vacation_ManagerContext (DbContextOptions<Project_Vacation_ManagerContext> options)
            : base(options)
        {
        }

        public DbSet<Project_Vacation_Manager.Models.Team> Team { get; set; }

        public DbSet<Project_Vacation_Manager.Models.Vacation> Vacation { get; set; }

        public DbSet<Project_Vacation_Manager.Models.Project> Project { get; set; }
    }
}
