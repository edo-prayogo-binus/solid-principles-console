using solid_principles_console.Enums;
using solid_principles_console.Models;
using solid_principles_console.Services.DependencyInversion;
using solid_principles_console.Services.InterfaceSegregation;
using solid_principles_console.Services.LiskovSubstitution;
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

        public static void OpenClosedPrinciple()
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

        public static void LiskovSubstitutionPrinciple()
        {
            Helper.PrintHeader("Start of LSP Example");
            var numbers = new int[] { 5, 7, 9, 8, 1, 6, 4 };
            SumCalculator sum = new SumCalculator(numbers);
            Console.WriteLine($"The sum of all the numbers: {sum.Calculate()}");
            Console.WriteLine();
            SumCalculator evenSum = new EvenNumbersSumCalculator(numbers);
            Console.WriteLine($"The sum of all the even numbers: {evenSum.Calculate()}");
            Helper.PrintHeader("End of LSP Example");
        }

        public static void InterfaceSegregationPrinciple()
        {
            Helper.PrintHeader("Start of ISP Example");
            Helper.PrintHeader("Typical vehicle example:");
            // Implementation would go here
            Helper.PrintHeader("A car that can only drive:");
            ICar car = new Car();
            car.Drive();
            Console.WriteLine();

            Helper.PrintHeader("A plane that can only fly:");
            IAirplane airplane = new Airplane();
            airplane.Fly();
            Console.WriteLine();

            Helper.PrintHeader("A multi functional car that can both drive and fly:");
            IMultiFunctionalVehicle multiFunctionalVehicle = new MultiFunctionalCar(new Car(), new Airplane());
            multiFunctionalVehicle.Drive();
            multiFunctionalVehicle.Fly();
            Console.WriteLine();

            Helper.PrintHeader("End of ISP Example");
        }

        public static void DependencyInversionPrinciple()
        {
            Helper.PrintHeader("Start of DIP Example");
            // Implementation would go here
            var empManager = new EmployeeManager();
            empManager.AddEmployee(new Employee { Name = "Leen", Gender = Gender.Female, Position = Position.Manager });
            empManager.AddEmployee(new Employee { Name = "Mike", Gender = Gender.Male, Position = Position.Administrator });
            empManager.AddEmployee(new Employee { Name = "Oscar", Gender = Gender.Male, Position = Position.Executive });
            empManager.AddEmployee(new Employee { Name = "Sara", Gender = Gender.Female, Position = Position.Manager });

            Console.WriteLine($"Total number of employees in our company is: {empManager.GetTotalEmployees()}");

            var stats = new EmployeeStatistics(empManager);
            Console.WriteLine($"Number of female managers in our company is: {stats.CountFemaleManagers()}");

            Helper.PrintHeader("End of DIP Example");
        }
        #endregion
    }
}
