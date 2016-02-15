namespace Mvcv.Web.Controllers
{
    using System.Web.Mvc;

    public class JokesController : BaseController
    {
        public JokesController()
        {
        }

        public ActionResult ById(string id)
        {
            return this.View();
        }
    }
}
