using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidiControllerProject.Library.Notes;

namespace MidiControllerProject.Library.Scales
{
    public class EMinorScale : Scale
    {
        public EMinorScale()
        {
            this.ScaleName = "E Minor scale";

            this.Notes.Add(new Note(NoteType.E));
            this.Notes.Add(new Note(NoteType.FSharp));
            this.Notes.Add(new Note(NoteType.G));
            this.Notes.Add(new Note(NoteType.A));
            this.Notes.Add(new Note(NoteType.B));
            this.Notes.Add(new Note(NoteType.C));
            this.Notes.Add(new Note(NoteType.D));
        }
    }
}
