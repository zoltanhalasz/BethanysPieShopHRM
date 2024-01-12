using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BethanysPieShopHRM.Shared.Model
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "First name is too long.")]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [StringLength(50, ErrorMessage = "Last name is too long.")]
        public string LastName { get; set; } = string.Empty;

        public DateTime BirthDate { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        
    }
}
