namespace IteratorPattern
{
    public class EmployeeDirectReportIterator : IEmployeeHierarchyIterator
    {
        private readonly EmployeeHierarchyCollection _employeeHierarchyCollection;
        private int _currentPosition = 0;

        public EmployeeDirectReportIterator(EmployeeHierarchyCollection employeeHierarchyCollection)
        {
            _employeeHierarchyCollection = employeeHierarchyCollection;
        }

        public bool HasNext()
        {
            return _currentPosition < _employeeHierarchyCollection.GetEmployees().Count;
        }

        public Employee GetNext()
        {
            Console.WriteLine("Iterating through [EmployeeDirectReportIterator]");

            return _employeeHierarchyCollection.GetEmployees()[_currentPosition++];
        }
    }
}
