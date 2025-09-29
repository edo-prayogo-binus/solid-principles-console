using solid_principles_console.Models;
using solid_principles_console.Services.SingleResponsibilities;

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
        #endregion
    }
}
