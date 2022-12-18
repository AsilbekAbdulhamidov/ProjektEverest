using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO
{
    public class AdminApprovalDTO  //Admin suhbatlarni ko'rishi
    {
        

        public string? Direction { get; set; }
       
        public int InterviewerId { get; set; }   //senior idsi
        public DateTime InterviewTime { get; set; }
        public double PayStatus { get; set; }

        public int IntervieweeId { get; set; }      // stajor idsi

        public bool AdministratorPermission { get; set; } 
    }
}
