using DependencyInversion_After.Contracts;

namespace DependencyInversion_After.Classes
{
    public class EmployeeService
    {
        private readonly IEmployeeRepository _repository;
        public EmployeeService(IEmployeeRepository repository)
        {
            _repository = repository;
        }
        public void AddEmployee(Employee employee)
        {
            //Validate Employee
            _repository.AddEmployee(employee);
        }

        public Employee GetEmployee(int id)
        {
            var employee = _repository.GetEmployee(id);
            //some logic
            return employee;
        }

        public List<Employee> GetEmployees()
        {
            var employees = _repository.GetEmployees();
            //some logic
            return employees;
        }
    }
}
