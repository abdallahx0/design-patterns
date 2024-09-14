
using IteratorPattern;

EmployeeHierarchyCollection employeeHierarchyCollection = new EmployeeHierarchyCollection();
var iterators = new List<IEmployeeHierarchyIterator>()
{
    employeeHierarchyCollection.CreateEmployeeDirectReportIterator(),
    employeeHierarchyCollection.CreateEmployeeCoWorkerIterator(),
    employeeHierarchyCollection.CreateEmployeeSubOrdinateIterator(),

};

iterators.ForEach(c =>
{
    while (c.HasNext())
    {
        Console.WriteLine(c.GetNext().Name);
    }

    Console.WriteLine("================");
});
