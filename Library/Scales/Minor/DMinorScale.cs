using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidiControllerProject.Library.Notes;

namespace MidiControllerProject.Library.Scales
{
    public class DMinorScale : Scale
    {
        public DMinorScale()
        {
            this.ScaleName = "D Minor scale";

            this.Notes.Add(new Note(NoteType.D));
            this.Notes.Add(new Note(NoteType.E));
            this.Notes.Add(new Note(NoteType.F));
            this.Notes.Add(new Note(NoteType.G));
            this.Notes.Add(new Note(NoteType.A));
            this.Notes.Add(new Note(NoteType.ASharp));
            this.Notes.Add(new Note(NoteType.C));
        }
    }
}
