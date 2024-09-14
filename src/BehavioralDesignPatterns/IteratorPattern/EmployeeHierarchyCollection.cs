namespace IteratorPattern
{
    public class EmployeeHierarchyCollection : IIterableCollection
    {

        private readonly List<Employee> _employees;

        public EmployeeHierarchyCollection()
        {
            _employees = new List<Employee>()
            {
                new Employee(1, "Mahmoud"),
                new Employee(2, "Ahmed")
            };
        }

        public List<Employee> GetEmployees()
        {
            return _employees;
        }

        public IEmployeeHierarchyIterator CreateEmployeeDirectReportIterator()
        {
            return new EmployeeDirectReportIterator(this);
        }

        public IEmployeeHierarchyIterator CreateEmployeeCoWorkerIterator()
        {
            return new EmployeeCoWorkerIterator(this);
        }

        public IEmployeeHierarchyIterator CreateEmployeeSubOrdinateIterator()
        {
            return new EmployeeSubOrdinateIterator(this);
        }
    }

}
