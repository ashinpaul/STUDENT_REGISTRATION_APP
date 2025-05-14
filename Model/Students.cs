using System.ComponentModel.DataAnnotations;

namespace machine_test.Model
{
    public class Students
    {
        public int Id { get; set; }
        [Required]
        public string FName { get; set; }
        public string? LName { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public DateTime DoB { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }

        public string Course { get; set; }

        public string CName { get; set; }

        public int Percentage { get; set; }
        public DateTime YofP { get; set; }
    }
    public class LoginCred
    {
        public int StId { get; set; }
        public string Password { get; set; }
    }
}
