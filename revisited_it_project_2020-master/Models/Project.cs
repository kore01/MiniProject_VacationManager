using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Vacation_Manager.Models
{
    public class Project
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public List<Team> Teams { get; set; }
        
    }
}
