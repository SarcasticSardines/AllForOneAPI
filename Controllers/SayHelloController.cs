
using AllForOneAPI.Services.SayHello;
using Microsoft.AspNetCore.Mvc;

namespace AllForOneAPI.Controllers;

    [ApiController]
    [Route("api/[controller]")]
    public class SayHelloController : ControllerBase
    {
    private readonly ISayHelloService _sayHelloService;

    public SayHelloController(ISayHelloService sayHelloService)
    {
        _sayHelloService = sayHelloService;
    }

    [HttpGet]
    [Route("GetName/{userName}")]

    public string GetName(string userName){
        return _sayHelloService.GetName(userName);
    }
}
