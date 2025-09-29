using solid_principles_console.Enums;
using solid_principles_console.Models;

namespace solid_principles_console.Services.DependencyInversion
{
    public interface IEmployeeSearchable
    {
        IEnumerable<Employee> GetEmployeesByGenderAndPosition(Gender gender, Position position);
    }
}
