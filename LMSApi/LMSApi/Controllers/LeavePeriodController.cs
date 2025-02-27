using LMSApi.IRepository;
using LMSApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace LMSApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class LeavePeriodController : ControllerBase
    {
        private readonly IRepoLeavePeriod _leavePeriodRepository;
        public LeavePeriodController(IRepoLeavePeriod leavePeriodRepository)
        {
            _leavePeriodRepository = leavePeriodRepository;
        }

        [HttpPost("CreateLeavePeriod")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        public IActionResult CreateLeavePeriod(LeavePeriods _leavePeriods)
        {
            try
            {
                var response = _leavePeriodRepository.CreateLeavePeriod(_leavePeriods);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An unexpected error occurred: " + ex.Message);
            }
        }
        [HttpGet("GetLeavePeriod")]
        [ProducesResponseType(typeof(List<>), StatusCodes.Status200OK)]
        public IActionResult GetLeavePeriod()
        {
            try
            {
                var response = _leavePeriodRepository.GetLeavePeriodrepo();
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An unexpected error occurred: " + ex.Message);
            }
           
        }
        [HttpGet("GetLeaveType")]
        [ProducesResponseType(typeof(List<>), StatusCodes.Status200OK)]
        public IActionResult GetLeaveType()
        {
            try
            {
                var response = _leavePeriodRepository.GetLeaveTyperepo();
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An unexpected error occurred: " + ex.Message);
            }

        }
    }
}
