namespace IteratorPattern
{
    public interface IEmployeeHierarchyIterator
    {
        public bool HasNext();
        public Employee GetNext();
    }
}
