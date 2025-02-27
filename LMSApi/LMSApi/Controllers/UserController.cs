using LMSApi.IRepository;
using LMSApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace LMSApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController: ControllerBase
    {
        private readonly IRepoUser _userRepository;
        public UserController(IRepoUser userRepository)
        {
            _userRepository = userRepository;
        }
        [HttpPost("CreateUser")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        public IActionResult CreateUser(Users _user)
        {
            try
            {
                var response = _userRepository.CreateUserRepo(_user);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An unexpected error occurred: " + ex.Message);
            }
           
        }
        [HttpGet("GetUser")]
        [ProducesResponseType(typeof(List<>), StatusCodes.Status200OK)]
        public IActionResult GetUser()
        {
            try
            {
                var response = _userRepository.GetUserrepo();
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An unexpected error occurred: " + ex.Message);
            }
           
        }
        [HttpPost("UserLeaveBalance")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        public IActionResult UserLeaveBalance(UserLeaveBalances _userLeaveBalance)
        {
            try
            {
                var response = _userRepository.UserLeaveBalanceRepo(_userLeaveBalance);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An unexpected error occurred: " + ex.Message);
            }
           
        }
        [HttpGet("GetUserLeaveBalance")]
        [ProducesResponseType(typeof(List<>), StatusCodes.Status200OK)]
        public IActionResult GetUserLeaveBalance()
        {
            try
            {
                var response = _userRepository.GetUserLeaveBalancerepo();
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An unexpected error occurred: " + ex.Message);
            }
           
        }
        [HttpPost("UserLeaveApplication")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        public IActionResult UserLeaveApplication(LeaveApplications _userLeaveApplication)
        {
            try
            {
                var response = _userRepository.UserLeaveApplicationRepo(_userLeaveApplication);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An unexpected error occurred: " + ex.Message);
            }
           
        }
        
    }
}
