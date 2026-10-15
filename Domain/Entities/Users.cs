using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Users
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        [Phone]
        public string PhoneNumber { get; set; } = string.Empty;
    }
}
