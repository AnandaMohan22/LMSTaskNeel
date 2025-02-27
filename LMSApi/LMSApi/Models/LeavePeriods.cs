using System.ComponentModel.DataAnnotations;

namespace LMSApi.Models
{
    public class LeavePeriods
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
