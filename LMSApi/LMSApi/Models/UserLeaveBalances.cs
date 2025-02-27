using System.ComponentModel.DataAnnotations;

namespace LMSApi.Models
{
    public class UserLeaveBalances
    {
        [Key]
        public int ID { get; set; }
        public int UserID { get; set; }
        public int LeaveTypeID { get; set; }
        public int AllocatedDays { get; set; }
        public int UsedDays { get; set; }
        public int LeavePeriodId{ get; set; }
    }
}
