namespace MV.CV.Web.Controllers
{
    using System.Web.Mvc;

    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            //var jokes = this.jokes.GetRandomJokes(3).To<JokeViewModel>().ToList();
            //var categories =
            //    this.Cache.Get(
            //        "categories",
            //        () => this.jokeCategories.GetAll().To<JokeCategoryViewModel>().ToList(),
            //        30 * 60);
            //var viewModel = new IndexViewModel
            //{
            //    Jokes = jokes,
            //    Categories = categories
            //};

            return this.View();
        }
    }
}
