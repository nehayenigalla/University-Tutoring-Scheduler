using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace EFCode.Models
{
    public class RegisterViewModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public long Phone { get; set; }
        public string Course { get; set; }
        public string Level { get; set; }


        public string Username { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]

        public string ConfirmPassword { get; set; }
        public bool PasswordsMatch()
        {
            return Password == ConfirmPassword;
        }
        public string DateOfBirth { get; set; }

        public string Email { get; set; }

        public string UserType { get; set; }
    }
}