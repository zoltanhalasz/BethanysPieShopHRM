using BethanysPieShopHRM.Shared.Model;
using System.Net.Http.Json;

namespace BethanysPieShopHRM.Client.Data
{
    public class EmployeeStoreClient: IEmployeeStore
    {
        private readonly HttpClient _http;

        public EmployeeStoreClient(HttpClient http)
        {
            _http = http;
        }

        public async Task<string> AddEmployee(Employee employee)
        {
            var response = await _http.PostAsJsonAsync("api/employees", employee);
            return await response.Content.ReadAsStringAsync();
        }

        public Task<IEnumerable<Employee>> GetAllEmployees()
        {
            throw new NotImplementedException();
        }

        public Task<Employee?> GetEmployee(string id)
        {
            throw new NotImplementedException();
        }
    }
}
