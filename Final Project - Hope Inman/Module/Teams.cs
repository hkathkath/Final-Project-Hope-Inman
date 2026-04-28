using Microsoft.EntityFrameworkCore;

namespace Final_Project___Hope_Inman.Module
{
    public class Teams
    {
        
        public int id { get; set; }
        public string? football { get; set; }
        public string? baseball { get; set; }
        public string? basketball { get; set; }
        public string? soccer { get; set; }
        public string? hockey { get; set; }
    }
}
