namespace LMSApi.Models
{
    public class LeaveApplications
    {
        public int ID { get; set; }
        public int UserId { get; set; }
        public int LeaveTypeId { get; set; }
        public int LeavePeriodId { get; set; }
        public int RequestedDays { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
