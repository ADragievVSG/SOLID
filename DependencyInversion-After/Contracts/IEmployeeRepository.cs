using DependencyInversion_After.Classes;

namespace DependencyInversion_After.Contracts
{
    public interface IEmployeeRepository
    {
        void AddEmployee(Employee employee);
        Employee GetEmployee(int id);
        List<Employee> GetEmployees();
    }
}
