
using AllForOneAPI.Services.OddorEven;
using Microsoft.AspNetCore.Mvc;

namespace AllForOneAPI.Controllers;

    [ApiController]
    [Route("api/[controller]")]
    public class OddorEvenController : ControllerBase
    {
        private readonly IOddorEvenService _oddorEvenService;

        public OddorEvenController(IOddorEvenService oddorEvenService)
        {
            _oddorEvenService = oddorEvenService;
        }

    [HttpGet]
    [Route("GetEorO/{myNum}")]

    public string GetEorO(string myNum)
    {
        return _oddorEvenService.GetEorO(myNum);
    }

    }
