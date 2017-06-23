using MidiControllerProject.Library.Chords;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class ScaleFromChordsModel
    {
        public ScaleFromChordsModel()
        {
            this.AvailableChords = new List<Chord>();
            this.SelectedChords = new List<Chord>();
        }

        public List<Chord> AvailableChords { get; set; }

        public List<Chord> SelectedChords { get; set; }
    }
}