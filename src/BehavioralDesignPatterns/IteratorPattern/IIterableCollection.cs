namespace IteratorPattern
{
    public interface IIterableCollection
    {
        public IEmployeeHierarchyIterator CreateEmployeeDirectReportIterator();
        public IEmployeeHierarchyIterator CreateEmployeeCoWorkerIterator();
        public IEmployeeHierarchyIterator CreateEmployeeSubOrdinateIterator();
    }
}
