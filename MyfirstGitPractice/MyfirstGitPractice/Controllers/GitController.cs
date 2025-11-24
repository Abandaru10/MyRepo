using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyfirstGitPractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GitController : ControllerBase
    {
        public GitController() { }
        public GitController(string apiKey) { }

        public void addedFromGitHub(){ }

        public void addedForAnotherTest(){}
            
    }
}
