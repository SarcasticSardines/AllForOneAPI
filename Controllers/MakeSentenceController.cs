
using AllForOneAPI.Services.MakeSentence;
using Microsoft.AspNetCore.Mvc;

namespace AllForOneAPI.Controllers;

    [ApiController]
    [Route("api/[controller]")]
    public class MakeSentenceController : ControllerBase
    {
    private readonly IMakeSentenceService _makeSentenceService;

    public MakeSentenceController(IMakeSentenceService makeSentenceService)
    {
        _makeSentenceService = makeSentenceService;
    }

    [HttpGet]
    [Route("GetBoth/{myName}/{myZodiac}")]

    public string GetBoth(string myName, string myZodiac)
    {
        return _makeSentenceService.GetBoth(myName, myZodiac);
    }
}
