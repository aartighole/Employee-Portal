using System.ComponentModel.DataAnnotations;

namespace EmployeePortal.Models
{
    public class Login
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public DateTime CreatedBy { get; set; }
        [Required]
        public DateTime LastLoggedIn { get; set; }
    }
}
       