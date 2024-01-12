namespace BethanysPieShopHRM.Shared.Model
{
    public class EmployeeStore : IEmployeeStore
    {
        private readonly Dictionary<string, Employee> employees;

        public EmployeeStore()
        {
            employees = [];

            foreach (var e in MockDataService.Employees)
            {
                employees.Add(e.EmployeeId.ToString(), e);
            }
        }

        public async Task<string> AddEmployee(Employee employee)
        {
            employee.EmployeeId = employees.Count + 1;

            employees.Add(employee.EmployeeId.ToString(), employee);
            return await Task.FromResult(employee.EmployeeId.ToString());
        }

        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            await Task.Delay(3000);

            return employees.Values;
        }

        public Task<Employee?> GetEmployee(string id)
        {
            employees.TryGetValue(id, out var employee);
            return Task.FromResult(employee);
        }
    }
}
