
using Domain.Enums;

namespace Domain.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Fullname { get; set; }

        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public UserRole Role { get; set; }

        public decimal Balance { get; set; }

        public string CardNumber { get; set; }

    }
}
