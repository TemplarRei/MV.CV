namespace MV.CV.Web.Controllers
{
    using System.Web.Mvc;
    using Data.Models;
    using Services.Data;

    public class LanguageController : Controller
    {
        private readonly ILanguageServices languages;

        public LanguageController(ILanguageServices languages)
        {
            this.languages = languages;
        }

        [HttpGet]
        [Authorize]
        public ActionResult AddLanguage()
        {
            return this.View();
        }

        [HttpPost]
        [Authorize]
        public ActionResult AddLanguage(Language language)
        {
            this.languages.Add(language, 1);
            return this.RedirectToAction("Edit", "Profile");
        }
    }
}
