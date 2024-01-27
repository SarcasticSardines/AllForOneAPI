
using AllForOneAPI.Services.FeedMe;
using Microsoft.AspNetCore.Mvc;

namespace AllForOneAPI.Controllers;

    [ApiController]
    [Route("api/[controller]")]
    public class FeedMeController : ControllerBase
    {
    private readonly IFeedMeService _feedMeService;

    public FeedMeController(IFeedMeService feedMeService)
    {
        _feedMeService = feedMeService;
    }
    [HttpGet]
    [Route("GetFood/{myChoice}")]

    public string GetFood(string myChoice)
    {
        return _feedMeService.GetFood(myChoice);
    }
}
