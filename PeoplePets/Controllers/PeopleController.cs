using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PeoplePets.BusinessLayer;
using PeoplePets.BusinessLayer.Interface;

namespace PeoplePets.Controllers
{
    public class PeopleController : Controller
    {

        private readonly IPeople _people;

        public PeopleController(IPeople people)
        {
            _people = people;
        }

        // GET: People
        public ActionResult Cats()
        {
            return View((List<Owner>)_people.GetOwnerCatNames());
        }
    }
}