using solid_principles_console.Models;

namespace solid_principles_console.Services.SingleResponsibility
{
    public class WorkReport
    {
        #region prop and ctor
        // This class has a single responsibility: managing work report entries.
        private readonly List<WorkReportEntry> _entries;
        public WorkReport()
        {
            _entries = new List<WorkReportEntry>();
        }
        #endregion

        #region main method

        // Methods to manage work report entries
        public void AddEntry(WorkReportEntry entry) => _entries.Add(entry);

        // Method to remove an entry by index
        public void RemoveEntryAt(int index) => _entries.RemoveAt(index);

        // Override ToString to provide a string representation of the report
        public override string ToString() =>
            string.Join(Environment.NewLine, _entries.Select(x => $"Code: {x.ProjectCode}, Name: {x.ProjectName}, Hours: {x.SpentHours}"));
        #endregion
    }
}
