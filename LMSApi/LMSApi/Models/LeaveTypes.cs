using System.ComponentModel.DataAnnotations;

namespace LMSApi.Models
{
    public class LeaveTypes
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
