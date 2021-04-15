using ServicingAPI.Classes;
using ServicingAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;

namespace ServicingAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SubmitDealController : ControllerBase
    {
        private readonly ILogger<SubmitDealController> _logger;
        private ISubmitDealService _SubmitDealService;

        public SubmitDealController(ILogger<SubmitDealController> logger, ISubmitDealService dealService)
        {
            _logger = logger;
            _SubmitDealService = dealService;
        }

        [Authorize]
        [HttpPost("SubmitDeal")]
        public IActionResult AskQuestion(SubmitDealRequest submitDealRequest)
        {
            SubmitDealResponse SubmitDealResponse = _SubmitDealService.SubmitDeal(submitDealRequest);

            return Ok(SubmitDealResponse);
        }
    }
}