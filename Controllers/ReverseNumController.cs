
using AllForOneAPI.Services.ReverseNum;
using Microsoft.AspNetCore.Mvc;

namespace AllForOneAPI.Controllers;

    [ApiController]
    [Route("api/[controller]")]
    public class ReverseNumController : ControllerBase
    {
    private readonly IReverseNumService _reverseNumService;

    public ReverseNumController(IReverseNumService reverseNumService)
    {
        _reverseNumService = reverseNumService;
    }

    [HttpGet]
    [Route("GetRNum/{reverseNum}")]

    public string GetRNum(string reverseNum)
    {
        return _reverseNumService.GetRNum(reverseNum);
    }

}
