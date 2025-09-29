using solid_principles_console.Enums;

namespace solid_principles_console.Models
{
    public class Employee
    {
        public string Name { get; set; } = string.Empty;
        public Gender Gender { get; set; }
        public Position Position { get; set; }
    }
}
