namespace MVCExample.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CompanyId { get; set; }
    }

    public class EmployeesByCompanyPickerViewModel
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public Employee[] Employees { get; set; }
    }

    public interface IDataProvider
    {
        Company[] GetCompanies();
        Employee[] GetEmployees();
    }

    public class DataProvider : IDataProvider
    {
        public Company[] GetCompanies()
        {
            return new[]
            {
                new Company {Id = 1, Name = "KORE"},
                new Company {Id = 2, Name = "Acme"}
            };
        }

        public Employee[] GetEmployees()
        {
            return new[]
            {
                new Employee { Id = 101, Name = "Arnold", CompanyId = 1},
                new Employee { Id = 102, Name = "John",   CompanyId = 1},
                new Employee { Id = 103, Name = "Victor", CompanyId = 1},
                new Employee { Id = 104, Name = "TA",     CompanyId = 2},
                new Employee { Id = 105, Name = "Joel",   CompanyId = 2},
                new Employee { Id = 106, Name = "Dmitry", CompanyId = 2},
            };
        }
    }
}