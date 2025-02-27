using LMSApi.Models;

namespace LMSApi.IRepository
{
    public interface IRepoLeavePeriod
    {
        string CreateLeavePeriod(LeavePeriods _leavePeriods);
        List<LeavePeriods> GetLeavePeriodrepo();
        List<LeaveTypes> GetLeaveTyperepo();
    }
}
