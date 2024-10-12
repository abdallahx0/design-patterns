namespace CompositePattern
{
    public class Department : IOrganisationUnit
    {
        private readonly List<IOrganisationUnit> _organisationUnits;

        public Department()
        {
            _organisationUnits = new List<IOrganisationUnit>();
        }

        public void AddOrganisationUnit(IOrganisationUnit organisationUnit)
        {
            _organisationUnits.Add(organisationUnit);
        }

        public decimal CalculateTotalSalary()
        {
            return _organisationUnits.Sum(unit => unit.CalculateTotalSalary());
        }
    }
}
