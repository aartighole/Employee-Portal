using System.ComponentModel.DataAnnotations;

namespace EmployeePortal.Models
{
    public class Employee_new
    {
        [Key] 
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public string Department { get; set; }
        public DateTime JoiningDate { get; set; } = DateTime.Now;
    }
}
 