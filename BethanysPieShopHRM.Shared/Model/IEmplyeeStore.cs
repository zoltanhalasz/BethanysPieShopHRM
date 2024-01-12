namespace BethanysPieShopHRM.Shared.Model
{
    public interface IEmployeeStore
    {
        Task<IEnumerable<Employee>> GetAllEmployees();

        Task<Employee?> GetEmployee(string id);

        Task<string> AddEmployee(Employee employee);
    }
}