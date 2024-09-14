namespace IteratorPattern
{
    public class EmployeeCoWorkerIterator : IEmployeeHierarchyIterator
    {
        private readonly EmployeeHierarchyCollection _employeeHierarchyCollection;
        private int _currentPosition = 0;

        public EmployeeCoWorkerIterator(EmployeeHierarchyCollection employeeHierarchyCollection)
        {
            _employeeHierarchyCollection = employeeHierarchyCollection;
        }

        public bool HasNext()
        {
            return _currentPosition < _employeeHierarchyCollection.GetEmployees().Count;
        }

        public Employee GetNext()
        {
            Console.WriteLine("Iterating through [EmployeeCoWorkerIterator]");

            return _employeeHierarchyCollection.GetEmployees()[_currentPosition++];
        }
    }
}
