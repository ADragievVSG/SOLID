using DependencyInversion_After.Contracts;

namespace DependencyInversion_After.Classes
{
    public class EmployeeDBRepository : IEmployeeRepository
    {
        public void AddEmployee(Employee employee)
        {
            //add employee to DB
        }

        public Employee GetEmployee(int id)
        {
            //get employee from db
            return new Employee();
        }

        public List<Employee> GetEmployees()
        {
            //get employees from db
            return new List<Employee>();
        }
    }
}
