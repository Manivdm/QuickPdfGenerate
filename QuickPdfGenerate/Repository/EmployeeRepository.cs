using QuickPdfGenerate.IRepository;
using QuickPdfGenerate.Models;

namespace QuickPdfGenerate.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public List<Employee> GetEmployees()
        {
            var employees = new List<Employee>();
            employees.Add(new Employee() { Id = 1, Name = "Emp001", salary = 12000 });
            employees.Add(new Employee() { Id = 2, Name = "Emp002", salary = 15000 });
            employees.Add(new Employee() { Id = 3, Name = "Emp003", salary = 22000 });
            employees.Add(new Employee() { Id = 4, Name = "Emp004", salary = 9000 });
            employees.Add(new Employee() { Id = 5, Name = "Emp005", salary = 35000 });
            employees.Add(new Employee() { Id = 6, Name = "Emp006", salary = 159000 });
            return employees;
        }
    }
}
