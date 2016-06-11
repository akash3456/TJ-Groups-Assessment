using PairingTest.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PairingTest.Web.Controllers
{
    public class AnswerController : Controller
    {
        //
        // GET: /Answer/

        public ViewResult Index()
        {
            return View(new AnswerViewModel());
        }

    }
}
