using LMSApi.IRepository;
using LMSApi.Models;
using Microsoft.EntityFrameworkCore;

namespace LMSApi.Repository
{
    public class RepoUser : IRepoUser
    {
       
        private readonly AppDbContext dbContext;
        public RepoUser(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<Users> GetUserrepo()
        {
            List<Users> userList = new List<Users>();
            try
            {
                userList = dbContext.Users.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return userList;
        }
        public string CreateUserRepo(Users _user)
        {
            var message = string.Empty;
            try
            {
                var user = new Users
                {
                   FullName = _user.FullName,
                   Email = _user.Email,
                   CreatedAt = DateTime.Now
                };
                dbContext.Users.Add(user);
                dbContext.SaveChanges();
                message = "Created";

            }
            catch (Exception ex)
            {
                message = "Error, " + ex.Message + "";
            }
            return message;
        }
        public string UserLeaveBalanceRepo(UserLeaveBalances _userLeaveBalanceRepo)
        {
            var message = string.Empty;
            try
            {
                var userLeaveBalance = new UserLeaveBalances
                {
                    UserID = _userLeaveBalanceRepo.UserID,
                    LeaveTypeID = _userLeaveBalanceRepo.LeaveTypeID,
                    AllocatedDays = _userLeaveBalanceRepo.AllocatedDays,
                    LeavePeriodId = _userLeaveBalanceRepo.LeavePeriodId,
                    UsedDays = 0
                };
                dbContext.UserLeaveBalances.Add(userLeaveBalance);
                dbContext.SaveChanges();
                message = "Created";

            }
            catch (Exception ex)
            {
                message = "Error, " + ex.Message + "";
            }
            return message;
        }
        public string UserLeaveApplicationRepo(LeaveApplications _leaveApplications)
        {
            var message = string.Empty;
            try
            { 
                var userLeaveBalance = dbContext.UserLeaveBalances.Where(x=>x.UserID== _leaveApplications.UserId && x.LeaveTypeID == _leaveApplications.LeaveTypeId && x.LeavePeriodId == _leaveApplications.LeavePeriodId).FirstOrDefault();

                if (userLeaveBalance == null || userLeaveBalance.AllocatedDays - userLeaveBalance.UsedDays < _leaveApplications.RequestedDays)
                {
                    message = "Insufficient leave balance";
                }
                else
                {
                    var leaveApplication = new LeaveApplications
                    {
                        UserId = _leaveApplications.UserId,
                        LeaveTypeId = _leaveApplications.LeaveTypeId,
                        LeavePeriodId = _leaveApplications.LeavePeriodId,
                        RequestedDays = _leaveApplications.RequestedDays,
                        Status = "Approved"
                    };

                    userLeaveBalance.UsedDays += _leaveApplications.RequestedDays;

                    dbContext.LeaveApplications.Add(leaveApplication);
                    dbContext.SaveChanges();
                    message = "Created";
                }
            }
            catch (Exception ex)
            {
                message = "Error, " + ex.Message + "";
            }
            return message;
        }
        public List<UserLeaveBalances> GetUserLeaveBalancerepo()
        {
            List<UserLeaveBalances> userList = new List<UserLeaveBalances>();
            try
            {
                userList = dbContext.UserLeaveBalances.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return userList;
        }
        
    }
}
