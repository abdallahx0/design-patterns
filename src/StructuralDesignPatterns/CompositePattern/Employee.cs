namespace CompositePattern
{
    public class Employee(string name, decimal salary) : IOrganisationUnit
    {
        public decimal CalculateTotalSalary()
        {
            return salary;
        }
    }

}
