using BethanysPieShopHRM.Shared.Model;
using Microsoft.AspNetCore.Components.QuickGrid;
using System.Security.Cryptography;

namespace BethanysPieShopHRM.Components.Pages
{
    public partial class InternationalEmployeeOverview
    {
        private List<Employee> _employees = [];
        private string titleFilter = string.Empty;

        PaginationState pagination = new() { ItemsPerPage = 10 };

        IQueryable<Employee>? itemsQueryable;

        protected override void OnInitialized()
        {
            var allCharacters = "abcdefghijklmnopqrstuvwxyz";


            for (int i = 1; i < 100; i++)
            {
                var firstName = RandomNumberGenerator.GetString(allCharacters, 20);
                var lastName= RandomNumberGenerator.GetString(allCharacters, 20);

                _employees.Add(new Employee() { EmployeeId = i, FirstName = firstName, LastName = lastName, BirthDate = DateTime.Now });

            }
            itemsQueryable = _employees.AsQueryable();
        }
    }
}
