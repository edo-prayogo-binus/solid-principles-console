namespace solid_principles_console.Models
{
    public class DeveloperReport
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Level { get; set; } = string.Empty;
        public int WorkingHours { get; set; }
        public double HourlyRate { get; set; }
    }
}
