namespace FP.Patterns.Singleton.Exercice1
{
    internal class EmployeeRegister
    {
        private static EmployeeRegister _instance;
        private List<Employee> _employees;

        private EmployeeRegister()
        {
            _employees = new List<Employee>();
        }

        public static EmployeeRegister Instance
        {
            get
            {
                if (_instance is null)
                {
                    _instance = new EmployeeRegister();
                }

                return _instance;
            }
        }

        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }

        public void RemoveEmployee(string id)
        {
            var employee = GetEmployee(id);

            _employees.Remove(employee);
        }

        public Employee GetEmployee(string id)
        {
            var employee = _employees.FirstOrDefault(e => e.Id == id);

            if (employee is null)
            {
                throw new Exception("Employee not found");
            }

            return employee;
        }
    }
}
