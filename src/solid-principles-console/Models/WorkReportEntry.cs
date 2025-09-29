namespace solid_principles_console.Models
{
    public class WorkReportEntry
    {
        public string ProjectCode { get; set; } = string.Empty;
        public string ProjectName { get; set; } = string.Empty;
        public int SpentHours { get; set; }
    }
}
