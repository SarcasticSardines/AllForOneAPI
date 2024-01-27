
using AllForOneAPI.Services.ReverseAlpha;
using Microsoft.AspNetCore.Mvc;

namespace AllForOneAPI.Controllers;

    [ApiController]
    [Route("api/[controller]")]
    public class ReverseAlphaController : ControllerBase
    {
        private readonly IReverseAlphaService _reverseAlphaService;

        public ReverseAlphaController(IReverseAlphaService reverseAlphaService)
        {
            _reverseAlphaService = reverseAlphaService;
        }

    [HttpGet]
    [Route("GetRAlpha/{reverseAlpha}")]

    public string GetRAlpha(string reverseAlpha)
    {
        return _reverseAlphaService.GetRAlpha(reverseAlpha);
    }

    }
