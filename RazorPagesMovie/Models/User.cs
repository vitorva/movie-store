using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class User
    {

        private DateTime createdAt;

        private DateTime updatedAt;

        public User()
        {
            createdAt = DateTime.UtcNow;
            updatedAt = DateTime.UtcNow;
        }

        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreatedAt
        {
            get { return createdAt; }
            set { createdAt = DateTime.SpecifyKind(value, DateTimeKind.Utc); }
        }

        [DataType(DataType.Date)]
        public DateTime UpdatedAt
        {
            get { return updatedAt; }
            set { updatedAt = DateTime.SpecifyKind(value, DateTimeKind.Utc); }
        }
    }
}
