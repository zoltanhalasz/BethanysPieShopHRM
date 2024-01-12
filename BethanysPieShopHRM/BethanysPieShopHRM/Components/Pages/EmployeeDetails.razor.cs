using BethanysPieShopHRM.Shared.Model;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShopHRM.Components.Pages
{
    public partial class EmployeeDetails
    {
        [Parameter]
        public string EmployeeId { get; set; }
        public Employee Employee { get; set; } = new Employee();

        [Inject]
        public IEmployeeStore? EmployeeStore { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Employee = await EmployeeStore.GetEmployee(EmployeeId);
        }
    }
}
