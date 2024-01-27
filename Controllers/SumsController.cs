using AllForOneAPI.Services.Sums;
using Microsoft.AspNetCore.Mvc;

namespace AllForOneAPI.Controllers;

    [ApiController]
    [Route("api/[controller]")]
    public class SumsController : ControllerBase
    {
    private readonly ISumsService _sumsService;

    public SumsController(ISumsService sumsService)
    {
        _sumsService = sumsService;
    }

    [HttpGet]
    [Route("GetNumbers/{num1}/{num2}")]

    public string GetNumbers(string num1, string num2)
        {
            return _sumsService.GetNumbers(num1, num2);
        }
}
