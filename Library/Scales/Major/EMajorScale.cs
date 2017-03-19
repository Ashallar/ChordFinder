using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidiControllerProject.Library.Notes;

namespace MidiControllerProject.Library.Scales
{
    public class EMajorScale : Scale
    {
        public EMajorScale()
        {
            this.Notes.Add(new Note(NoteType.E));
            this.Notes.Add(new Note(NoteType.FSharp));
            this.Notes.Add(new Note(NoteType.GSharp));
            this.Notes.Add(new Note(NoteType.A));
            this.Notes.Add(new Note(NoteType.B));
            this.Notes.Add(new Note(NoteType.CSharp));
            this.Notes.Add(new Note(NoteType.DSharp));

            this.ScaleName = "E Major scale";
        }
    }
}
