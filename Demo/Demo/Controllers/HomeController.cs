using System.Web.Mvc;
using Demo.Models;

namespace Demo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Create 
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Index(Person person)
        {
            if (ModelState.IsValid)
            {
                //TODO save person model somewhere
            }
            return View(person);
        }
    }
}