using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace TodoApp.Controllers
{
    [Route("api/[controller]")] // we define the routing that our controller going to use
    [ApiController] // We need to specify the type of the controller to let .Net core know
    public class TodoController : ControllerBase
    {
        [Route("TestRun")] // define the routing for this action
        [HttpGet]

        public ActionResult TestRun()
        {
            return Ok("success");
        }
    }
}