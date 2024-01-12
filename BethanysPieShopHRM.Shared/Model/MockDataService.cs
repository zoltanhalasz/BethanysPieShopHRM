namespace BethanysPieShopHRM.Shared.Model
{
    public class MockDataService
    {
        private static List<Employee>? _employees = default!;

        public static List<Employee>? Employees
        {
            get
            {
                _employees ??= InitializeMockEmployees();

                return _employees;
            }
        }

        private static List<Employee> InitializeMockEmployees()
        {
            var e1 = new Employee
            {
                BirthDate = new DateTime(1989, 3, 11),
                Email = "bethany@bethanyspieshop.com",
                EmployeeId = 1,
                FirstName = "Bethany",
                LastName = "Smith",
            };

            var e2 = new Employee
            {
                BirthDate = new DateTime(1979, 1, 16),
                Email = "gill@bethanyspieshop.com",
                EmployeeId = 2,
                FirstName = "Gill",
                LastName = "Cleeren",
            };

            var e3 = new Employee
            {
                BirthDate = new DateTime(1979, 1, 16),
                Email = "jane@bethanyspieshop.com",
                EmployeeId = 3,
                FirstName = "Jane",
                LastName = "Doe",
            };

            return new List<Employee>() { e1, e2, e3 };
        }


    }
}
