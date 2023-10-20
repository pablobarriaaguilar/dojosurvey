// This brings all the MVC features we need to this file
using Microsoft.AspNetCore.Mvc;
// Be sure to use your own project's namespace here! 
namespace Dojosurvey.Controllers;   
public class DojoController : Controller   // Remember inheritance?    
{      
    [HttpGet]
    [Route("")]
    public ViewResult Index()
    {
        return View();
    }

   [HttpPost("process")]
    public IActionResult Process(Survey surv ){


    return View("Result", surv);
    }
}

