using System.ComponentModel.DataAnnotations;

namespace LMSApi.Models
{
    public class Users
    {
        [Key]
        public int ID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
