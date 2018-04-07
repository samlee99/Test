using Microsoft.AspNetCore.Mvc;

namespace OdeToFood.Controllers
{
    [Route("company/[controller]/[action]")] // using the controller token needs to be in square brackets, and it tells the MVC framework the name of the controller from the class name.
    public class AboutController
    {
        public string Phone()
        {
            return "1+555+555+5555";
        }
        
        public string Address()
        {
            return "USA";
        }
    }
}
