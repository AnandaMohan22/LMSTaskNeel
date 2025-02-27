using LMSApi.IRepository;
using LMSApi.Models;

namespace LMSApi.Repository
{
    public class RepoLeavePeriod : IRepoLeavePeriod
    {
        private readonly AppDbContext dbContext;
        public RepoLeavePeriod(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<LeavePeriods> GetLeavePeriodrepo()
        {
            List<LeavePeriods> leavePeriodList = new List<LeavePeriods>();
            try
            {
                leavePeriodList = dbContext.LeavePeriods.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return leavePeriodList;
        }
        public string CreateLeavePeriod(LeavePeriods _leavePeriods)
        {
            var message = string.Empty;
            try
            {
                var leavePeriod = new LeavePeriods
                {
                    Name = _leavePeriods.Name,
                    StartDate = _leavePeriods.StartDate,
                    EndDate = _leavePeriods.EndDate,
                    CreatedDate = DateTime.Now
                };
                dbContext.LeavePeriods.Add(leavePeriod);
                dbContext.SaveChanges();
                message = "Created";

            }
            catch (Exception ex)
            {
                message = "Error, " + ex.Message + "";
            }
            return message;
        }
        public List<LeaveTypes> GetLeaveTyperepo()
        {
            List<LeaveTypes> leaveTypeList = new List<LeaveTypes>();
            try
            {
                leaveTypeList = dbContext.LeaveTypes.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return leaveTypeList;
        }
    }
}
