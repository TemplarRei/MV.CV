namespace MV.CV.Web.Controllers
{
    using System.Web.Mvc;

    using Microsoft.AspNet.Identity;

    using Services.Data;

    public class HomeController : BaseController
    {
        private IProfileServices profiles;

        public HomeController(IProfileServices profiles)
        {
            this.profiles = profiles;
        }

        public ActionResult Index()
        {
            this.ViewBag.Url = this.profiles.GetUrlForCurrentUser(this.User.Identity.GetUserId());

            return this.View();
        }
    }
}
