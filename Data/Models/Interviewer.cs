namespace Data.Models
{
    public class Interviewer
    {
        public int Id { get; set; } 
        public string? Name { get; set; }
        public string? Dagree { get; set; }
        public string? Number { get; set; }
        public string? Experience { get; set; }
        public string? Projects { get; set; }
       
        public string? ImageUrl { get; set; }
        public Category? Category { get; set; }
        public Interviewee? interviewee { get; set; }

    }
}