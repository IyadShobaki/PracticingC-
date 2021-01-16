namespace LinkedListImplementation
{
    public class EmployeeNode
    {
        public Employee Employee { get; set; }
        public EmployeeNode Next { get; set; }

        public EmployeeNode(Employee employee)
        {
            Employee = employee;
        }
    }
}
