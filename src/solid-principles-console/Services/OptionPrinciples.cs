using solid_principles_console.Models;
using solid_principles_console.Services.OpenClosed;
using solid_principles_console.Services.SingleResponsibility;

namespace solid_principles_console.Services
{
    public static class OptionPrinciples
    {
        #region main method
        public static void SingleResponsibilityPrinciple(string rootPathFolderShared)
        {
            Helper.PrintHeader("Start of SRP Example");
            // Creating a work report and adding entries
            var report = new WorkReport();
            report.AddEntry(new WorkReportEntry { ProjectCode = "123Ds", ProjectName = "Project1", SpentHours = 5 });
            report.AddEntry(new WorkReportEntry { ProjectCode = "987Fc", ProjectName = "Project2", SpentHours = 3 });
            Console.WriteLine(report.ToString());

            // Saving the report to a file
            var saver = new FileSaver();
            saver.SaveToFile(rootPathFolderShared, "WorkReport.txt", report);
            Helper.PrintHeader("End of SRP Example");
        }

        public static void OpenClosedPrinciple(string rootPathFolderShared)
        {
            Helper.PrintHeader("Start of OCP Example");
            var devCalculations = new List<BaseSalaryCalculator>
            {
                new SeniorDevSalaryCalculator(new DeveloperReport {Id = 1, Name = "Dev1", Level = "Senior developer", HourlyRate = 30.5, WorkingHours = 160 }),
                new JuniorDevSalaryCalculator(new DeveloperReport {Id = 2, Name = "Dev2", Level = "Junior developer", HourlyRate = 20, WorkingHours = 150 }),
                new SeniorDevSalaryCalculator(new DeveloperReport {Id = 3, Name = "Dev3", Level = "Senior developer", HourlyRate = 30.5, WorkingHours = 180 })
            };
            var calculator = new SalaryCalculator(devCalculations);
            Console.WriteLine($"Sum of all the developer salaries is {calculator.CalculateTotalSalaries()} dollars");
            Helper.PrintHeader("End of OCP Example");
        }
        #endregion
    }
}
