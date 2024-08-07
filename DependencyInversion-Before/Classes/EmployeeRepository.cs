namespace DependencyInversion_Before.Classes
{
    public class EmployeeRepository
    {
        private readonly List<Employee> _employees;
        public EmployeeRepository()
        {
            _employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }

        public Employee GetEmployee(int id)
        {
            return _employees.FirstOrDefault(e => e.Id == id);
        }

        public List<Employee> GetEmployees()
        {
            return _employees;
        }
    }
}
