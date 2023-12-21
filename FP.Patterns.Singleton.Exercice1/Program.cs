using FP.Patterns.Singleton.Exercice1;

var employeeRegister = EmployeeRegister.Instance;

var employee = new Employee("Juan", "Perez", "123456");
var employee2 = new Employee("Pedro", "Perez", "123457");
var employee3 = new Employee("Maria", "Perez", "123458");

employeeRegister.AddEmployee(employee);
employeeRegister.AddEmployee(employee2);
employeeRegister.AddEmployee(employee3);

var employeeRegister2 = EmployeeRegister.Instance;

var employee4 = employeeRegister2.GetEmployee("123457");

Console.WriteLine(employee4.Name);