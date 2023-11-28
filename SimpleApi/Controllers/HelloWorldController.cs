using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class HelloWorldController : ControllerBase
{
    [HttpGet]
    public ActionResult<string> Get()
    {
        return "Hello, World!";
    }
}
