using solid_principles_console.Enums;

namespace solid_principles_console.Services.DependencyInversion
{
    public class EmployeeStatistics
    {
        #region prop and ctor
        private readonly IEmployeeSearchable _emp;

        public EmployeeStatistics(IEmployeeSearchable emp)
        {
            _emp = emp;
        }
        #endregion

        #region main method

        public int CountFemaleManagers() 
            => _emp.GetEmployeesByGenderAndPosition(Gender.Female, Position.Manager).Count();
        #endregion
    }
}
