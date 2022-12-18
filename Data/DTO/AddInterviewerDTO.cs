using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO
{
    public class AddInterviewerDTO //ADmin seniorlarni kiritishi
    {
       
        public string? Name { get; set; }
        public string? Dagree { get; set; }
        public string? Number { get; set; }
        public string? Experience { get; set; }
        public string? Projects { get; set; }

        public string? ImageUrl { get; set; }

        
    }
}
