using BethanysPieShopHRM.Shared.Model;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShopHRM.Components.Pages
{
    public partial class EmployeeOverview
    {
        public List<Employee> Employees { get; set; } = default!;

        private string Title = "Employee overview";

        [Inject]
        public IEmployeeStore? EmployeeStore { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Employees = (await EmployeeStore.GetAllEmployees()).ToList();
        }
    }
}
