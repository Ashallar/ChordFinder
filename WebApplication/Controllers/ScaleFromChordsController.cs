using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MidiControllerProject.Library.Chords;
using MidiControllerProject.Library.Scales;
using WebApplication.Models;
using MidiControllerProject.Library.Notes;

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

        [HttpPost]
        public JsonResult GetMatchingScales(List<string> chords)
         {
            List<Chord> chordsList = new List<Chord>();


            foreach (string chord in chords)
            {
                chordsList.Add(new Chord(chord));
            }

            List<Note> distinctNotes = chordsList.GetDistinctNotesFromChordList();
            List<Scale> matchingScales = ScalesBook.GetMatchingScales(distinctNotes);

            return Json(matchingScales.Select(x => x.ScaleName).ToList());
        }

        [HttpGet]
        public ActionResult OnScaleSelected(string scaleName)
        {
            // TODO: Need to understand why view isn't loading properly

            Scale scale = ScalesBook.GetAllScales().Find(x => x.ScaleName.Equals(scaleName));

            return this.View("scaledetails", scale);
        }
    }
}