using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidiControllerProject.Library.Notes;

namespace MidiControllerProject.Library.Scales
{
    public class GSharpMinorScale : Scale
    {
        public GSharpMinorScale()
        {
            this.ScaleName = "G# Minor scale";

            this.Notes.Add(new Note(NoteType.GSharp));
            this.Notes.Add(new Note(NoteType.ASharp));
            this.Notes.Add(new Note(NoteType.B));
            this.Notes.Add(new Note(NoteType.CSharp));
            this.Notes.Add(new Note(NoteType.DSharp));
            this.Notes.Add(new Note(NoteType.E));
            this.Notes.Add(new Note(NoteType.FSharp));
        }
    }
}
