namespace FP.Patterns.Singleton.Exercice1
{
    internal class Employee
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Id { get; set; }

        public Employee(string name, string lastName, string id)
        {
            Name = name;
            LastName = lastName;
            Id = id;
        }
    }
}
