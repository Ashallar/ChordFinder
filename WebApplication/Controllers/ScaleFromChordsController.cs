using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MidiControllerProject.Library.Chords;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class ScaleFromChordsController : Controller
    {
        // GET: ScaleFromChords
        public ActionResult Index()
        {
            ScaleFromChordsModel model = new ScaleFromChordsModel();
            model.AvailableChords = ChordsBook.GetAllChords();

            return View("Index", model);
        }
    }
}