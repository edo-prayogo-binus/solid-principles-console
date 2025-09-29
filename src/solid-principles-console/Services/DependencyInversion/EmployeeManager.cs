using solid_principles_console.Enums;
using solid_principles_console.Models;

namespace solid_principles_console.Services.DependencyInversion
{
    public class EmployeeManager : IEmployeeSearchable
    {
        #region prop and ctor
        private readonly List<Employee> _employees;

        public EmployeeManager()
        {
            _employees = new List<Employee>();
        }
        #endregion

        #region main method

        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }

        public int GetTotalEmployees() => _employees.Count;

        public IEnumerable<Employee> GetEmployeesByGenderAndPosition(Gender gender, Position position)
            => _employees.Where(emp => emp.Gender == gender && emp.Position == position);
        #endregion
    }
}
