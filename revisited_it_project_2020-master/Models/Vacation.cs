using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Vacation_Manager.Models
{
    public class Vacation
    {
        public int Id { get; set; }

        public string User { get; set; }

        [DataType(DataType.Date)]
        public DateTime FromDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime ToDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateCreation { get; set; }

  
        public Boolean IsIll { get; set; }

    
        public Boolean IsConf { get; set; }
    }
}
