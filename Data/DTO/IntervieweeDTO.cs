using Microsoft.AspNetCore.Http;

namespace Data.DTO
{
    public class IntervieweeDTO   //stajorlarni oq'shish
    {
        
        public string? FullName { get; set; }
        public string? Dagree { get; set; }
        public string? Experience { get; set; }
        public string? Number { get; set; }
        public string? Login { get; set; }
        public string? Password { get; set; }
        public IFormFile Image { get; set; }

       
       

    }
}
