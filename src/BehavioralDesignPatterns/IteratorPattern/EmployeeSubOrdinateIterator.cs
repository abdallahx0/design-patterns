namespace IteratorPattern
{
    public class EmployeeSubOrdinateIterator : IEmployeeHierarchyIterator
    {
        private readonly EmployeeHierarchyCollection _employeeHierarchyCollection;
        private int _currentPosition = 0;

        public EmployeeSubOrdinateIterator(EmployeeHierarchyCollection employeeHierarchyCollection)
        {
            _employeeHierarchyCollection = employeeHierarchyCollection;
        }

        public bool HasNext()
        {
            return _currentPosition < _employeeHierarchyCollection.GetEmployees().Count;
        }

        public Employee GetNext()
        {
            Console.WriteLine("Iterating through [EmployeeSubOrdinateIterator]");

            return _employeeHierarchyCollection.GetEmployees()[_currentPosition++];
        }
    }
}
