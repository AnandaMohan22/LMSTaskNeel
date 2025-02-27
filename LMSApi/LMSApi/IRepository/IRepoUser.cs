using LMSApi.Models;

namespace LMSApi.IRepository
{
    public interface IRepoUser
    {
        string CreateUserRepo(Users _user);
        string UserLeaveBalanceRepo(UserLeaveBalances _user);
        string UserLeaveApplicationRepo(LeaveApplications _user);
        List<Users> GetUserrepo();
        List<UserLeaveBalances> GetUserLeaveBalancerepo();
    }
}
