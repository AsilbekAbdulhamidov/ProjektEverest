using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Direction { get; set; }
        public virtual Interviewer Interviewer { get; set; }
        public int InterviewerId { get; set; }
        public DateTime InterviewTime { get; set; }
        public double PayStatus { get; set; }
        
        public int IntervieweeId { get;set; }

        public virtual Interviewee Interviewee { get; set; }
        public bool AdministratorPermission { get; set; } = false;
        public bool ConfirmationOfConversation { get; set; }

    }
}
