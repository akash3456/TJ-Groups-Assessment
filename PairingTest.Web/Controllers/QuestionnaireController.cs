using System.Web.Mvc;
using PairingTest.Web.Models;
using System.Net.Http;

namespace PairingTest.Web.Controllers
{
    public class QuestionnaireController : Controller
    {
          /* ASYNC ACTION METHOD... IF REQUIRED... */
//        public async Task<ViewResult> Index()
//        {
//        }

        public ViewResult Index()
        {
            return View(new QuestionnaireViewModel());
        }

        
    }
}
