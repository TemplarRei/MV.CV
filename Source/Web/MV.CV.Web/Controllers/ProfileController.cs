namespace MV.CV.Web.Controllers
{
    using System.Web.Mvc;

    public class ProfileController : Controller
    {
        [HttpGet]
        [Authorize]
        public ActionResult Create()
        {
            return this.View();
        }
    }
}