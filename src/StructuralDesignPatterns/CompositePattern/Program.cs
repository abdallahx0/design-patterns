using CompositePattern;

Department hrDepartment = new Department();
hrDepartment.AddOrganisationUnit(new Employee("Ahmed", 10000));
hrDepartment.AddOrganisationUnit(new Employee("Ali", 20000));

Department subDepartment = new Department();
subDepartment.AddOrganisationUnit(new Employee("Mohamed", 7000));
hrDepartment.AddOrganisationUnit(subDepartment);

Console.WriteLine("Total Salaries: " + hrDepartment.CalculateTotalSalary());
