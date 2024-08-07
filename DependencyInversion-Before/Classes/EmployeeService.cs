namespace DependencyInversion_Before.Classes
{
    public class EmployeeService
    {
        private readonly EmployeeRepository _repository;
        public EmployeeService()
        {
            _repository = new EmployeeRepository();
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
