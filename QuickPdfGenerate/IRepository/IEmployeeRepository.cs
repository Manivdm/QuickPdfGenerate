using QuickPdfGenerate.Models;

namespace QuickPdfGenerate.IRepository
{
    public interface IEmployeeRepository
    {
        List<Employee> GetEmployees();
    }
}
