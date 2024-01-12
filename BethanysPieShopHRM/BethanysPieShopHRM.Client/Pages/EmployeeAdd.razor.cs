using BethanysPieShopHRM.Shared.Model;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShopHRM.Client.Pages
{
    public partial class EmployeeAdd
    {
        [Inject]
        public IEmployeeStore? EmployeeStoreClient { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Parameter]
        public string? EmployeeId { get; set; }

        public Employee Employee { get; set; } = new Employee();

        protected string Message = string.Empty;
        protected string StatusClass = string.Empty;
        protected bool Saved;


        protected override async Task OnInitializedAsync()
        {
            Employee = new Employee { BirthDate = DateTime.Now };
        }

        protected async Task HandleValidSubmit()
        {
            var addedEmployee = await EmployeeStoreClient.AddEmployee(Employee);
            NavigationManager.NavigateTo($"/employeedetails/{addedEmployee}");
        }

        protected async Task HandleInvalidSubmit()
        {
            StatusClass = "alert-danger";
            Message = "There are some validation errors. Please try again.";
        }

        protected void NavigateToOverview()
        {
            NavigationManager.NavigateTo("/employeeoverview");
        }
    }
}
