
using AllForOneAPI.Services.Magic8;
using Microsoft.AspNetCore.Mvc;

namespace AllForOneAPI.Controllers;

    [ApiController]
    [Route("api/[controller]")]
    public class Magic8Controller : ControllerBase
    {
    private readonly IMagic8Service _magic8Service;

    public Magic8Controller(IMagic8Service magic8Service)
    {
        _magic8Service = magic8Service;
    }
    
    [HttpGet]
    [Route("GetMagic/{myQuestion}")]

    public string GetMagic(string myQuestion)
    {
        return _magic8Service.GetMagic(myQuestion);
    }

}
