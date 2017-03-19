using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidiControllerProject.Library.Notes;

namespace MidiControllerProject.Library.Scales
{
    public class FSharpMinorScale : Scale
    {
        public FSharpMinorScale()
        {
            this.ScaleName = "F# Minor scale";

            this.Notes.Add(new Note(NoteType.F));
            this.Notes.Add(new Note(NoteType.G));
            this.Notes.Add(new Note(NoteType.GSharp));
            this.Notes.Add(new Note(NoteType.ASharp));
            this.Notes.Add(new Note(NoteType.C));
            this.Notes.Add(new Note(NoteType.CSharp));
            this.Notes.Add(new Note(NoteType.DSharp));
        }
    }
}
